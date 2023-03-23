using P4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace P4Pruebas
{
    internal class GameLoop
    {
        //Manejar el Timer
        public DispatcherTimer GameTimer;
        MainPage MiPagina = null;
        Controlador MiControl = null;



        public GameLoop(Page Pagina, Controlador Control)
        {
            MiPagina = Pagina as MainPage;
            MiControl = Control;
            GameTimerSetup();
        }

        public void GameTimerSetup()
        {
            GameTimer = new DispatcherTimer();
            GameTimer.Tick += GameTimer_Tick;// dispatcherTimer_Tick;
            GameTimer.Interval = new TimeSpan(100000); //100000*10^-7s=1cs;

        }


        void GameTimer_Tick(object sender, object e)
        {   //Los Drones se simulan a nivel de aplicación cada 0.1s
            if (MiPagina != null)
            {
                if (MiControl != null)
                {
                    MiControl.LeeMando();                      //Lee GamePAd
                    MiControl.DetectaGestosMando();            //Detecta Gestos del Mando
                    MiControl.ZMMando();                       //ZonaMuerta JoyStick y Triggers
                    MiPagina.ActualizaIU();                    //Aplica cambios en IU y VM
                    MiControl.FeedBack();                      //Activa motores del Mando
                }
            }
        }
    }
        
}
