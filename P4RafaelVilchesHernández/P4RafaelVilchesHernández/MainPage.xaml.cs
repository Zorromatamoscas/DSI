using P4Pruebas;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Streams;
using Windows.UI.Core;
using Windows.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0xc0a

namespace P4
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Controlador GameControl = null;
        GameLoop gameLoop = null;

        public ObservableCollection<VMDron> ListaDrones { get; } = new ObservableCollection<VMDron>();
        public bool ArrastreMapa=false;
        public PointerPoint PtArrastreMapa;

        public MainPage()
        {
            this.InitializeComponent();
            GameControl = new Controlador();
            gameLoop = new GameLoop(this, GameControl);

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Cosntruye las listas de ModelView a partir de la lista Modelo 
            if (ListaDrones != null)
                foreach (Dron dron in Model.GetAllDrones())
                {
                    VMDron VMitem = new VMDron(dron);
                    ListaDrones.Add(VMitem);
                }
            gameLoop.GameTimerSetup();
            base.OnNavigatedTo(e);
        }
        public void ActualizaIU()
        {
            ContentControl MiDron = FocusManager.GetFocusedElement() as ContentControl;

            if (MiDron?.Parent == MiCanvas)
            {
                double X = 0, Y = 0, Angulo = 0;
                float Zoom = 0;
                X = (int)(X + 10 * GameControl.reading.RightThumbstickX);
                Y = (int)(Y - 10 * GameControl.reading.RightThumbstickY);
                Angulo = (int)(Angulo + 10 * GameControl.reading.RightTrigger);
                Angulo = (int)(Angulo - 10 * GameControl.reading.LeftTrigger);

                CompositeTransform Transformacion = MiDron.RenderTransform as CompositeTransform;
                Transformacion.TranslateX += X / myScrollView.ZoomFactor;
                Transformacion.TranslateY += Y / myScrollView.ZoomFactor;
                Transformacion.Rotation += Angulo;
                MiDron.RenderTransform = Transformacion;
                myScrollView.ChangeView(myScrollView.HorizontalOffset, myScrollView.VerticalOffset, myScrollView.ZoomFactor + Zoom);
            }
        }

        private void ImageGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            VMDron Sel = e.ClickedItem as VMDron;
            //MiTexto.Text = Sel.Explicacion;
            MiImagen.Source = Sel.Img.Source;
            CVDron MiDron = new CVDron(Sel, Sel.X, Sel.Y);
            MiCanvas.Children.Add(MiDron);
            MiDron.ManipulationMode = ManipulationModes.All;
            MiDron.ManipulationDelta += MiDron_ManipulationDelta;
            MiDron.KeyDown += MiDron_KeyDown;
            MiDron.UseSystemFocusVisuals = true;
        }

        private void MiCanvas_DragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Copy;
        }

        private async void MiCanvas_Drop(object sender, DragEventArgs e)
        {
            CVDron MiDron = null, MiDronG = null;
            Point PD = e.GetPosition(MiCanvas);
            var nombre = await e.DataView.GetTextAsync();
            foreach (VMDron vDron in ListaDrones)
                if (vDron.Nombre == nombre)
                {
                    MiDron = new CVDron(vDron as VMDron, PD.X, PD.Y);
                    MiDronG = new CVDron(vDron as VMDron, PD.X, PD.Y);
                }
            MiDron.ManipulationMode = ManipulationModes.All;
            MiDron.ManipulationDelta += MiDron_ManipulationDelta;
            MiDron.KeyDown += MiDron_KeyDown;
            MiDron.UseSystemFocusVisuals = true;
            MiCanvas.Children.Add(MiDron);
        }

        private void MiDron_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if(e.Key== Windows.System.VirtualKey.A)
            {
                var obj = sender as ContentControl;
                CompositeTransform Transformacion = obj.RenderTransform as CompositeTransform;
                Transformacion.TranslateX -= 1;
                obj.RenderTransform = Transformacion;
            }
            else if(e.Key == Windows.System.VirtualKey.D)
            {
                var obj = sender as ContentControl;
                CompositeTransform Transformacion = obj.RenderTransform as CompositeTransform;
                Transformacion.TranslateX += 1;
                obj.RenderTransform = Transformacion;
            }
            else if (e.Key == Windows.System.VirtualKey.W)
            {
                var obj = sender as ContentControl;
                CompositeTransform Transformacion = obj.RenderTransform as CompositeTransform;
                Transformacion.TranslateY -= 1;
                obj.RenderTransform = Transformacion;
            }
            else if (e.Key == Windows.System.VirtualKey.S)
            {
                var obj = sender as ContentControl;
                CompositeTransform Transformacion = obj.RenderTransform as CompositeTransform;
                Transformacion.TranslateY += 1;
                obj.RenderTransform = Transformacion;
            }
            else if (e.Key == Windows.System.VirtualKey.Q)
            {
                var obj = sender as ContentControl;
                CompositeTransform Transformacion = obj.RenderTransform as CompositeTransform;
                Transformacion.Rotation -= 1;
                obj.RenderTransform = Transformacion;
            }
            else if (e.Key == Windows.System.VirtualKey.E)
            {
                var obj = sender as ContentControl;
                CompositeTransform Transformacion = obj.RenderTransform as CompositeTransform;
                Transformacion.Rotation += 1;
                obj.RenderTransform = Transformacion;
            }
        }

        private void MiDron_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {

            var obj = sender as ContentControl;
            CompositeTransform Transformacion = obj.RenderTransform as CompositeTransform ;
            Transformacion.TranslateX -= e.Position.X;
            Transformacion.TranslateY -= e.Position.Y;
            Transformacion.Rotation += e.Delta.Rotation;
            obj.RenderTransform = Transformacion;
        }

        private void ImageGridView_DragItemsStarting(object sender,
DragItemsStartingEventArgs e)
        {
            VMDron Item = e.Items[0] as VMDron;
            string name = Item.Nombre.ToString();
            e.Data.SetText(name); //… Enviar el parámetro.
            e.Data.RequestedOperation= DataPackageOperation.Copy;
        }

        private void ScrollViewer_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            // Recoges el puntero que te llega cuando clicas y guardas como posicion inicial
            // También indicas con un booleano que estas moviendo la imagen
            // Por ultimo, cambias el puntero a la manita
            var Puntero = e.GetCurrentPoint(e.OriginalSource as Image);
            if (Puntero.Properties.IsRightButtonPressed == true)
            {
                ArrastreMapa = true;
                PtArrastreMapa = Puntero;
                Window.Current.CoreWindow.PointerCursor = new CoreCursor(CoreCursorType.Hand,0);
            }
        }

        private void ScrollViewer_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            // Si estabas moviendo el mapa, coge la posicion actual del puntero cada vez que lo muevas y restale la inicial para sacar 
            // cuanto tienes que mover la imagen y hacia donde
            // Saca tambien el zoom factor del scrollview del XAML para sus cosas raras
            var scroll = sender as ScrollViewer;
            if (ArrastreMapa)
            {
                myScrollView.ChangeView(scroll.HorizontalOffset - (e.GetCurrentPoint( e.OriginalSource as Image).Position.X - PtArrastreMapa.Position.X),
                   scroll.VerticalOffset-(e.GetCurrentPoint(e.OriginalSource as Image).Position.Y - PtArrastreMapa.Position.Y), myScrollView.ZoomFactor);
                e.Handled = true;
            }
        }

        private void ScrollViewer_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            // Cuando sueltas el boton, indica que ya no estas moviendo el mapa y devuelve el cursor a la flechita
            ArrastreMapa = false;
            Window.Current.CoreWindow.PointerCursor = new CoreCursor(CoreCursorType.Arrow, 0);
        }
    }
}
