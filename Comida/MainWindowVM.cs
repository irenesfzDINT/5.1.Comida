using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<Plato> listaComida;

        private ObservableCollection<String> tipoComidas;

        public ObservableCollection<String> TipoComidas
        {
            get { return tipoComidas; }
            set { tipoComidas = value;
                NotifyPropertyChanged("TipoComidas");
            }
        }

        public ObservableCollection<Plato> ListaComida
        {
            get { return listaComida; }
            set
            {
                listaComida = value;
                NotifyPropertyChanged("ListaComida");
            }
        }
        private Plato platoSeleccionado;

        public Plato PlatoSeleccionado
        {
            get { return platoSeleccionado; }
            set
            {
                platoSeleccionado = value;
                NotifyPropertyChanged("PlatoSeleccionado");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindowVM()
        {
            listaComida = Plato.GetSamples("./assets/fotoPlatos");
            tipoComidas = new ObservableCollection<String>();
            for (int i = 0; i < listaComida.Count; i++)
            {
                if (!tipoComidas.Contains(listaComida[i].Tipo))
                    tipoComidas.Add(listaComida[i].Tipo);
            }
            
        }
        public void QuitarPlato()
        {
            PlatoSeleccionado = null;
        }

    }
}
