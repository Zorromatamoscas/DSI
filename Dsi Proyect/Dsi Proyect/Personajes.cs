using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Dsi_Proyect
{
    public class Personajes
    {
        public string Id;
        public Image Imagen;
        public string Nombre;
        public int X;
        public int Y;
        public Personajes() { }
    }
    public class ListaPj
    {
        public static List<Personajes> personajes = new List<Personajes>()
        {
            new Personajes()
            {
                Id = "SwordUser 1",
                Nombre = "Bob Esponja",
                X = 150,
                Y = 150
            },
            new Personajes()
            {
                Id = "ShieldUser 1",
                Nombre = "Plancton",
                X = 100,
                Y = 100
            },
            new Personajes()
            {
                Id = "BowUser 1",
                Nombre = "Patricio",
                X = 50,
                Y = 50
            },
            new Personajes()
            {
                Id = "ShieldUser 2",
                Nombre = "Sr Cangrejo",
                X = 200,
                Y = 200
            },
            new Personajes()
            {
                Id = "SwordUser 2",
                Nombre = "Arenita",
                X = 250,
                Y = 250
            }
        };
    }
}
