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
        public ObservableCollection<VMDron> ListaDrones { get; } = new ObservableCollection<VMDron>();
        public bool ArrastreMapa=false;
        public PointerPoint PtArrastreMapa;

        public MainPage()
        {
            this.InitializeComponent();
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
            base.OnNavigatedTo(e);
        }

        private void ImageGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var item = e.ClickedItem as VMDron;
            Texto.Text = item.Explicacion;
            MiImagen.Source = item.Img.Source;
            MiDron.SetValue(Canvas.LeftProperty, item.X - 20);
            MiDron.SetValue(Canvas.TopProperty, item.Y - 15);
            MiDron.Source = item.Img.Source;
        }

        private void MiCanvas_DragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Copy;
        }

        private async void MiCanvas_Drop(object sender, DragEventArgs e)
        {
            e.Data.RequestedOperation = DataPackageOperation.Copy;
                Point PD = e.GetPosition(MiCanvas);
            Image MiDron = new Image();
            var source = await e.DataView.GetTextAsync();
            var realSource = System.IO.Directory.GetCurrentDirectory() + "\\" + source;
            MiDron.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(realSource));
            MiDron.Width = ImageSlider.Value;
            MiDron.Height = ImageSlider.Value;
            //MiCanvas.Children.Clear();
            MiCanvas.Children.Add(MiDron);
            MiDron.SetValue(Canvas.LeftProperty, PD.X);
            MiDron.SetValue(Canvas.TopProperty,PD.Y);


            CompositeTransform Transformacion = new CompositeTransform();
            Transformacion.TranslateX = 0.0;
            Transformacion.TranslateY = 0.0;
            Transformacion.Rotation = 0;
            MiDron.RenderTransform = Transformacion;
            MiDron.ManipulationMode = ManipulationModes.All;
            MiDron.ManipulationDelta += MiDron_ManipulationDelta;

        }

        private void MiDron_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            var obj = sender as Image;
            CompositeTransform Transformacion = obj.RenderTransform as CompositeTransform ;
            Transformacion.TranslateX += e.Position.X;
            Transformacion.TranslateY += e.Position.Y;
            Transformacion.Rotation += e.Delta.Rotation;
            obj.RenderTransform = Transformacion;
        }

        private void ImageGridView_DragItemsStarting(object sender,
DragItemsStartingEventArgs e)
        {
            VMDron Item = e.Items[0] as VMDron;
            string source = Item.Imagen;
            e.Data.SetText(source); //… Enviar el parámetro.
            e.Data.RequestedOperation= DataPackageOperation.Copy;
        }

        private void ScrollViewer_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
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
            if (ArrastreMapa)
            {
                myScrollView.ChangeView(e.GetCurrentPoint(e.OriginalSource as Image).Position.X - PtArrastreMapa.Position.X,
                   e.GetCurrentPoint(e.OriginalSource as Image).Position.Y - PtArrastreMapa.Position.Y, myScrollView.ZoomFactor);
            }
        }

        private void ScrollViewer_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            ArrastreMapa = false;
            Window.Current.CoreWindow.PointerCursor = new CoreCursor(CoreCursorType.Arrow, 0);
        }
    }
}
