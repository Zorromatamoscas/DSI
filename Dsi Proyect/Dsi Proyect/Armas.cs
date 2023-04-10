using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Dsi_Proyect
{
    public class Armas
    {
        public string Id;
        public Image Imagen;
        public string Nombre;
        public int X;
        public int Y;
        public Armas() { }
    }
    public class ListaArmas
    {
        public static List<Armas> weapons = new List<Armas>()
        {
            new Armas()
            {
                Id = "Sword 1",
                Nombre = "Espada de madera",
                X = 150,
                Y = 150
            },
            new Armas()
            {
                Id = "Sword 2",
                Nombre = "Espada de piedra",
                X = 100,
                Y = 100
            },
            new Armas()
            {
                Id = "Sword 3",
                Nombre = "Espada de acero",
                X = 50,
                Y = 50
            },
            new Armas()
            {
                Id = "Sword 4",
                Nombre = "Espada de oro",
                X = 200,
                Y = 200
            },
            new Armas()
            {
                Id = "Sword 5",
                Nombre = "Espada de diamante",
                X = 250,
                Y = 250
            }
        };
    }
}
