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
        public ObservableCollection<Plato> ListaComida
        {
            get { return listaComida; }
            set
            {
                listaComida = value;
                NotifyPropertyChanged("ListaComida");
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
        }

    }
}
