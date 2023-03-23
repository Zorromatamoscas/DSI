using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Playback;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace P4
{
    public class VMDron : Dron
    {
        public Image Img;
        public VMDron(Dron dron)
            {
            Id = dron.Id;
            Nombre = dron.Nombre;
            Imagen = dron.Imagen;
            Explicacion = dron.Explicacion;
            Estado = dron.Estado;
            Energia = dron.Energia;
            X = dron.X;
            Y = dron.Y;
            RX = dron.RX;
            RY = dron.RY;
            Img = new Image();
            string s = System.IO.Directory.GetCurrentDirectory() + "\\" + dron.Imagen;
            Img.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri(s));
            Img.Width = 50;
            Img.Height = 50;
        }
    }
    public class CVDron : ContentControl
    {
        public string Nombre;
        public Image Img;
        public CompositeTransform Transformacion;   //Nuevo: Traslación+Rotación
        public CVDron(VMDron dron, double X, double Y)
        {
            Nombre = dron.Nombre;
            Img = new Image();
            Img.Source = dron.Img.Source;
            Img.Width = 50;
            Img.Height = 50;
            this.Content = Img;
            Transformacion = new CompositeTransform();
            Transformacion.TranslateX = X;
            Transformacion.TranslateY = Y;
            this.RenderTransform = Transformacion;
        }
    }



}
