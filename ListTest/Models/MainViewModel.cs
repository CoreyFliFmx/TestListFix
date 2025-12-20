
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ListTest.Models
{
    public sealed class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set { _isLoading = value; OnPropertyChanged(); }
        }

        private List<OrderRow> _orders = new();
        public List<OrderRow> Orders
        {
            get => _orders;
            set { _orders = value ?? new List<OrderRow>(); OnPropertyChanged(); }
        }

        private void OnPropertyChanged([CallerMemberName] string? name = null)=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
