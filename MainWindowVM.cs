using Superheroe.modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroe
{
    class MainWindowVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Superhero heroeActual;

        public Superhero HeroeActual
        {
            get { return heroeActual; }
            set { 
                heroeActual = value;
                NotifyPropertyChanged("HeroeActual");
            }
        }

        private int contadorActual;

        public int ContadorActual
        {
            get { return contadorActual; }
            set { 
                contadorActual = value;
                NotifyPropertyChanged("ContadorActual");
            }
        }

        private int totalHeroes;

        public int TotalHeroes
        {
            get { return totalHeroes; }
            set { 
                totalHeroes = value;
                NotifyPropertyChanged("TotalHeroes");
            }
        }

        List<Superhero> lista;

        public MainWindowVM()
        {
            lista = Superhero.GetSamples();
            contadorActual = 1;
            totalHeroes = lista.Count;
            HeroeActual = lista[contadorActual-1];
        }
    }
}
