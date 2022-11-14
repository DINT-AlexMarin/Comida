using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    class ComidaVM : INotifyCollectionChanged,INotifyPropertyChanged
    {
        public ComidaVM()
        {
            Platos = new ObservableCollection<Plato>();
            Platos = Plato.GetSamples("C:/Users/alumno/Downloads/ut5_actv1_exe/Imagenes/" );
            TiposPlato = new ObservableCollection<string>();
            TiposPlato.Add("Americana");
            TiposPlato.Add("China");
            TiposPlato.Add("Mexicana");
        }
        private ObservableCollection<string> tiposPlato;

        public ObservableCollection<string> TiposPlato
        {
            get { return tiposPlato; }
            set { tiposPlato = value;
                NotifyPropertyChanged("TiposPlato");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private ObservableCollection<Plato> platos;

        public ObservableCollection<Plato> Platos
        {
            get { return platos; }
            set { platos = value;
                NotifyPropertyChanged("Platos");
            }
        }

        private Plato platoSeleccionado;

        public Plato PlatoSeleccionado
        {
            get { return platoSeleccionado; }
            set { platoSeleccionado = value;
                NotifyPropertyChanged("PlatoSeleccionado");
            }
        }


    }
}
