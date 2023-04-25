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
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Dsi_Proyect
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class ProtectiveShop : Page
    {
        int gold = 2500;
        public ProtectiveShop()
        {
            this.InitializeComponent();
        }
        private void Permanent_Click(object sender, RoutedEventArgs e)
        {
            WeaponView.ItemsSource = ListaTattoos.PermanentTattoos;
        }

        private void Shield_Click(object sender, RoutedEventArgs e)
        {
            WeaponView.ItemsSource = ListaTattoos.Shields;
        }

        private void Temp_Click(object sender, RoutedEventArgs e)
        {
            WeaponView.ItemsSource = ListaTattoos.TempTattoos;
        }
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            App.TryGoBack();
        }
        private void WeaponView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListView lv = sender as ListView;
            Tattoos w = lv.SelectedItem as Tattoos;
            if (w != null)
            {
                ATK.Text = w.Ataque.ToString();
                DEF.Text = w.Defensa.ToString();
                Cost.Text = w.Coste.ToString();
                Crit.Text = w.Critico.ToString();
                WeaponImage.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(System.IO.Directory.GetCurrentDirectory() + "\\" + w.Source));
            }
        }
        private void Grid_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Escape)
            {
                App.TryGoBack();
                e.Handled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            gold -= (WeaponView.SelectedItem as Tattoos).Coste;
            myMoney.Text = gold.ToString();
        }
    }
}
