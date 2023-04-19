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
        public string Source;
        public string Nombre;
        public int Ataque;
        public int Defensa;
        public int Coste;
        public string BuenoContra;

        public Armas() { }
    }
    public class ListaArmas
    {
        public static List<Armas> Swordweapons = new List<Armas>()
        {
            new Armas()
            {
                Id = "Sword 1",
                Nombre = "Espada de madera",
                Source = "Assets\\Square44x44Logo.scale-200.png",
                Ataque = 20,
                Defensa= 5,
                Coste = 40,
                BuenoContra = "Arco"
            },
            new Armas()
            {
                Id = "Sword 2",
                Nombre = "Espada de piedra",
                Source = "Assets\\Square44x44Logo.scale-200.png",
                Ataque = 40,
                Defensa= 15,
                Coste = 100,
                BuenoContra = "Arco"
            },
            new Armas()
            {
                Id = "Sword 3",
                Nombre = "Espada de acero",
                Source = "Assets\\steelSword.png",
                Ataque = 75,
                Defensa= 25,
                Coste = 150,
                BuenoContra = "Arco"
            },
            new Armas()
            {
                Id = "Sword 4",
                Nombre = "Espada de oro",
                Source = "Assets\\Square44x44Logo.scale-200.png",
                Ataque = 150,
                Defensa= 15,
                Coste = 400,
                BuenoContra = "Arco"
            },
            new Armas()
            {
                Id = "Sword 5",
                Nombre = "Espada de diamante",
                Source = "Assets\\espadaDiamante.png",
                Ataque = 160,
                Defensa= 50,
                Coste = 1000,
                BuenoContra = "Arco"
            }
        };
        public static List<Armas> Shields = new List<Armas>()
        {
            new Armas()
            {
                Id = "Sword 1",
                Nombre = "Escudo de cartón",
                Source = "Assets\\Square44x44Logo.scale-200.png",
                Ataque = 10,
                Defensa= 15,
                Coste = 40,
                BuenoContra = "Espada"
            },
             new Armas()
            {
                Id = "Sword 1",
                Nombre = "Escudo de acero",
                Source = "Assets\\ironShield.png",
                Ataque = 15,
                Defensa= 40,
                Coste = 90,
                BuenoContra = "Espada"
            },
              new Armas()
            {
                Id = "Sword 1",
                Nombre = "Escudo Titánico",
                Source = "Assets\\titanShield.png",
                Ataque = 70,
                Defensa= 200,
                Coste = 1000,
                BuenoContra = "Espada"
            }
        };
        public static List<Armas> Bows = new List<Armas>()
        {
            new Armas()
            {
                Id = "Sword 1",
                Nombre = "Arco roto",
                Source = "Assets\\brokenBow.png",
                Ataque = 35,
                Defensa= 0 ,
                Coste = 50,
                BuenoContra = "Escudo"
            },
              new Armas()
            {
                Id = "Sword 1",
                Nombre = "Arco del progenitor",
                Source = "Assets\\firstBow.png",
                Ataque = 190,
                Defensa= 35,
                Coste = 1000,
                BuenoContra = "Escudo"
            },

        };
        public static List<Armas> specials = new List<Armas>()
        {
             new Armas()
            {
                Id = "Sword 1",
                Nombre = "poción",
                Source = "Assets\\pocion.png",
                Ataque = 70,
                Defensa= 0,
                Coste = 100,
                BuenoContra = "1"
            }
        };
    }
}
