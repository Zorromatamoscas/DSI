using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public sealed partial class WeaponStore : Page
    {
        public WeaponStore()
        {
            this.InitializeComponent();
        }

        private void WeaponView_ItemClick(object sender, ItemClickEventArgs e)
        {
            Armas w = e.ClickedItem as Armas;
            ATK.Text = w.Ataque.ToString();
            DEF.Text = w.Defensa.ToString();
            Cost.Text = w.Coste.ToString();
            WeaponImage.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "\\" + w.Source));
            switch (w.BuenoContra)
            {
                case "Arco": GoodVs.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "\\Assets\\bowIcon.png"));
                    break;
                case "Espada": GoodVs.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "\\Assets\\swordIcon.png"));
                    break;
                case "Escudo": GoodVs.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "\\Assets\\shieldIcon.png"));
                    break;
                default:
                    GoodVs.Source = null;
                    break;
            }
        }
        private void Sword_Click(object sender, RoutedEventArgs e)
        {
            WeaponView.ItemsSource = ListaArmas.Swordweapons;
        }

        private void Shield_Click(object sender, RoutedEventArgs e)
        {
            WeaponView.ItemsSource = ListaArmas.Shields;
        }

        private void Bow_Click(object sender, RoutedEventArgs e)
        {
            WeaponView.ItemsSource = ListaArmas.Bows;
        }

        private void specials_Click(object sender, RoutedEventArgs e)
        {
            WeaponView.ItemsSource = ListaArmas.specials;
        }
    }
}
