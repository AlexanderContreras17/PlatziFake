using PlatziFake.Services;
using System.ComponentModel;
using System.Windows.Input;

namespace PlatziFake.ViewModels
{
    public class PlatziViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public ICommand MostrarCommand { get; set; } = null!;
        public List<Dtos.Producto> Productos { get; set; }
        private PlatziFakeAPI api;
        public void OnPropertyChanged(string? propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public PlatziViewModel()
        {
            llenarLista();
        }

        private async void llenarLista()
        {
            api = new();
            Productos = await api.GetProductos();
            OnPropertyChanged(nameof(Productos));
        }
    }
}
