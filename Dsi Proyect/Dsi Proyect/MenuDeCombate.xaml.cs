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
    public sealed partial class MenuDeCombate : Page
    {
        double enemyPrevValue = 100;
        double myPrevValue = 100;
        public MenuDeCombate()
        {
            this.InitializeComponent();
        }

        //VOLVER
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.TryGoBack();
        }

        //STORE
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(InitialShop));
        }

        private void Grid_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if(e.Key == Windows.System.VirtualKey.Escape)
            {
                App.TryGoBack();
                e.Handled = true;
            }
        }

        private void Button_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            enemyPrevValue = EnemyHp.Value;
            myPrevValue = myHp.Value;
            EnemyHp.Value -= 20;
            myHp.Value -= 15;
        }

        private void Button_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            EnemyHp.Value = enemyPrevValue;
            myHp.Value = myPrevValue;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            enemyPrevValue = EnemyHp.Value;
            myPrevValue = myHp.Value;
            myHp2.Value = myHp.Value;
        }

        private void Button_PointerEntered_1(object sender, PointerRoutedEventArgs e)
        {
            myPrevValue = myHp.Value;
            myHp.Value -= 15;
        }

        private void Button_PointerExited_1(object sender, PointerRoutedEventArgs e)
        {
            myHp.Value = myPrevValue;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            myPrevValue = myHp.Value;
            myHp2.Value = myHp.Value;
        }

        private void Button_PointerEntered_2(object sender, PointerRoutedEventArgs e)
        {
            myPrevValue = myHp.Value;
            myHp.Value +=20;
        }
    }
}
