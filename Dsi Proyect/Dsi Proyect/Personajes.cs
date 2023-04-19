using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace Dsi_Proyect
{
    public class Personajes
    {
        public string Id;
        public string Source;
        public string Nombre;
        public int Vida;
        public int Ataque;
        public int Defensa;
        public int Lv;
        public string Tipo;
        public Personajes() { }
    }
    public class ListaPj
    {
        public static List<Personajes> personajesEspada = new List<Personajes>()
        {
            new Personajes()
            {
                Id = "SwordUser 1",
                Nombre = "Bob Esponja",
                Vida = 250,
                Ataque = 140,
                Defensa = 100,
                Lv= 14,
                Tipo= "Sword",
                Source = "Assets\\bobesponja.png"
            },
            
            new Personajes()
            {
                Id = "SwordUser 2",
                Nombre = "Arenita",
                Vida = 230,
             Ataque = 190,
                Defensa = 80,
                Lv= 16,
                Tipo= "Sword",
                Source = "Assets\\arenita.png"
            }
        };
        public static List<Personajes> personajesEscudo = new List<Personajes>()
        {
            new Personajes()
            {
                Id = "ShieldUser 1",
                Nombre = "Plancton",
                Vida= 310,
               Ataque = 90,
                Defensa = 150,
                Lv= 15,
                Tipo= "Shield",
                Source = "Assets\\plancton.png"
            },

            new Personajes()
            {
                Id = "ShieldUser 2",
                Nombre = "Sr Cangrejo",
                Vida = 290,
                 Ataque = 100,
                Defensa = 140,
                Lv= 13,
                Tipo= "Shield",
                Source = "Assets\\srcangrejo.png"
            },
        };
        public static List<Personajes> personajesArco = new List<Personajes>()
        {
            new Personajes()
            {
                Id = "BowUser 1",
                Nombre = "Patricio",
                Vida = 190,
               Ataque = 180,
                Defensa = 70,
                Lv= 14,
                Tipo= "Bow",
                Source = "Assets\\patricio.png"
            },
        };
        public static List<Personajes> personajes = personajesEspada;
    }
}
