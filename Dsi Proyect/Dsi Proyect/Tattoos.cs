using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsi_Proyect
{
    public class Tattoos
    {
        public string Id;
        public string Source;
        public string Nombre;
        public int Ataque;
        public int Defensa;
        public int Coste;
        public int Critico;

        public Tattoos() { }
    }
    public class ListaTattoos
    {
        public static List<Tattoos> Shields = new List<Tattoos>()
        {
            new  Tattoos()
            {
                Id = "Sword 1",
                Nombre = "Tattoo de escudo",
                Source = "Assets\\shield.png",
                Ataque = 20,
                Defensa= 5,
                Coste = 40,
                Critico = 20
            },
            new  Tattoos()
            {
                Id = "Sword 2",
                Nombre = "Escudo de Hierro",
                Source = "Assets\\shield1.png",
                Ataque = 40,
                Defensa= 15,
                Coste = 100,
                Critico = 25
            },
            new Tattoos()
            {
                Id = "Sword 3",
                Nombre = "Escudo dorado",
                Source = "Assets\\shield2.png",
                Ataque = 75,
                Defensa= 25,
                Coste = 150,
                Critico = 30
            },
            new  Tattoos()
            {
                Id = "Sword 4",
                Nombre = "Tattoo espartano",
                Source = "Assets\\shield4.jpg",
                Ataque = 150,
                Defensa= 15,
                Coste = 400,
                Critico = 35
            },
            new Tattoos()
            {
                Id = "Sword 5",
                Nombre = "EscudUSA",
                Source = "Assets\\shield5.png",
                Ataque = 160,
                Defensa= 50,
                Coste = 1000,
                Critico = 40
            }
        };
        public static List<Tattoos> PermanentTattoos = new List<Tattoos>()
        {
            new  Tattoos()
            {
                Id = "Sword 1",
                Nombre = "Armadura de cuero",
                Source = "Assets\\armadura.png",
                Ataque = 10,
                Defensa= 15,
                Coste = 40,
                Critico = 10
            },
             new  Tattoos()
            {
                Id = "Sword 1",
                Nombre = "Armadura de hierro",
                Source = "Assets\\armadura2.png",
                Ataque = 15,
                Defensa= 40,
                Coste = 90,
                Critico= 15
            },
              new  Tattoos()
            {
                Id = "Sword 1",
                Nombre = "El Diamante",
                Source = "Assets\\armadura5.png",
                Ataque = 70,
                Defensa= 200,
                Coste = 1000,
                Critico = 40
            }
        };
        public static List<Tattoos> TempTattoos = new List<Tattoos>()
        {
            new  Tattoos()
            {
                Id = "Sword 1",
                Nombre = "La media Luna",
                Source = "Assets\\Tattoo3.png",
                Ataque = 20,
                Defensa= 0 ,
                Coste = 100,
                Critico = 5
            },
              new  Tattoos()
            {
                Id = "Sword 1",
                Nombre = "El dragón celeste",
                Source = "Assets\\tattoo4.png",
                Ataque = 10,
                Defensa= 35,
                Coste = 250,
                Critico = 25
            },
                new  Tattoos()
            {
                Id = "Sword 1",
                Nombre = "Amor Y Guerra",
                Source = "Assets\\tattoo7.png",
                Ataque = 40,
                Defensa= 40 ,
                Coste = 500,
                Critico = 40
            },

        };
    }
}
