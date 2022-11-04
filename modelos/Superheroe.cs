using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroe.modelos
{
    class Superhero : INotifyPropertyChanged
    {
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public bool Vengador { get; set; }
        public bool Xmen { get; set; }
        public bool Heroe { get; set; }

        public Superhero()
        {
        }

        public Superhero(string nombre, string imagen, bool vengador, bool xmen, bool heroe)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public static List<Superhero> GetSamples()
        {
            List<Superhero> ejemplos = new List<Superhero>();

            Superhero ironman = new Superhero("Iron man", @"https://dossierinteractivo.com/wp-content/uploads/2021/01/Iron-Man.png", true, false, true);
            Superhero kingpin = new Superhero("Kingpin", @"https://www.comicbasics.com/wp-content/uploads/2017/09/Kingpin.jpg", false, false, false);
            Superhero spiderman = new Superhero("Spider man", @"https://wipy.tv/wp-content/uploads/2019/08/destino-de-%E2%80%98Spider-Man%E2%80%99-en-los-Comics.jpg", true, true, true);

            ejemplos.Add(ironman);
            ejemplos.Add(kingpin);
            ejemplos.Add(spiderman);

            return ejemplos;
        }
    }
}
