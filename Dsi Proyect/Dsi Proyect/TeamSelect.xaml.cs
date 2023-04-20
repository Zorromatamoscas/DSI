using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Dsi_Proyect
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class TeamSelect : Page
    {
        bool allySpace1Used = false;
        bool allySpace2Used = false;
        public TeamSelect()
        {
            this.InitializeComponent();
        }

        private void OnKeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Escape)
            {
                App.TryGoBack();
                e.Handled = true;
            }
        }

        private void Ally2_Click(object sender, RoutedEventArgs e)
        {
            allySpace2Used = false;
            allySpace2.Source = null;
        }

        private void Ally1_Click(object sender, RoutedEventArgs e)
        {
            allySpace1Used = false;
            allySpace1.Source = null;
        }

        private void Sword_Click(object sender, RoutedEventArgs e)
        {
            ListView.ItemsSource = ListaPj.personajesEspada;
        }

        private void Shield_Click(object sender, RoutedEventArgs e)
        {
            ListView.ItemsSource = ListaPj.personajesEscudo;
        }

        private void Bow_Click(object sender, RoutedEventArgs e)
        {
            ListView.ItemsSource = ListaPj.personajesArco;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            App.TryGoBack();
        }

        //Boton de ready
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(allySpace1Used && allySpace2Used)
            {
                this.Frame.Navigate(typeof(MenuDeCombate));
            }
        }
        private void ListView_DragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {
            Personajes Item = e.Items[0] as Personajes;
            e.Data.SetText(Item.Tipo);
            e.Data.RequestedOperation = DataPackageOperation.Copy;
        }

        private void myCanvas_DragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.Copy;
        }

        private async void myCanvas_Drop(object sender, DragEventArgs e)
        {
            var tipo = await e.DataView.GetTextAsync();
            var objeto = sender as Button;
            ImageSource Mapicon = null;
            switch (tipo)
            {
                case "Sword":
                    Mapicon = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "\\Assets\\swordIcon.png"));
                    break;
                case "Shield":
                    Mapicon = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "\\Assets\\shieldIcon.png"));
                    break;
                case "Bow":
                    Mapicon = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "\\Assets\\bowIcon.png"));
                    break;

                default: break;
            }
            if(objeto == Ally_button_1)
            {
                allySpace1.Source= Mapicon;
                allySpace1Used=true;
            }
            else if(objeto == Ally_button_2)
            {
                allySpace2.Source = Mapicon;
                allySpace2Used=true;
            }
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Personajes pj = ListView.SelectedItem as Personajes;
            if (pj != null)
            {
                ATK.Text = pj.Ataque.ToString();
                DEF.Text = pj.Defensa.ToString();
                HP.Text = pj.Vida.ToString();
                Type.Text = pj.Tipo;
                Lv.Text = pj.Lv.ToString();
                pjImage.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "\\" + pj.Source));
            }
        }

        private void ListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Personajes pj = e.ClickedItem as Personajes;
            pjImage.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "\\" + pj.Source));
            ImageSource Mapicon = null;
            switch (pj.Tipo)
            {
                case "Sword":
                    Mapicon = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "\\Assets\\swordIcon.png"));
                    break;
                case "Shield":
                    Mapicon = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "\\Assets\\shieldIcon.png"));
                    break;
                case "Bow":
                    Mapicon = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "\\Assets\\bowIcon.png"));
                    break;

                default: break;
            }
            if (!allySpace1Used)
            {
                allySpace1.Source = Mapicon;
                allySpace1Used = true;
            }
            else if (!allySpace2Used)
            {
                allySpace2.Source = Mapicon;
                allySpace2Used = true;
            }
            else
            {
                allySpace1.Source = Mapicon;
                allySpace2Used = false;
            }
        }
    }
}
