using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppBindingCommand.ViewModels
{
    public class UsuarioViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        void OnPropertyChanged(string propertyName) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string name = string.Empty;

        public string Name 
        { 
            get => name;
            set 
            {
                if (name == null)
                    return;

                name = value; 
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(DisplayName));
            } 
        }

        public string DisplayName => $"Nome digitado: {Name}";
        
        private string displayMessage = string.Empty;

        public string DisplayMessage
        {
            get => displayMessage;
            set
            {
                if (displayMessage == null)
                    return;

                displayMessage = value;
                OnPropertyChanged($"{nameof(DisplayMessage)}");
            }
        }

        public UsuarioViewModel() 
        {
            ShowMessageCommand = new Command(ShowMessage);
        }

        public ICommand ShowMessageCommand { get; }

        public void ShowMessage() 
        {
            DateTime data = Preferences.Get("dtAtual", DateTime.MinValue);
            DisplayMessage = $"Boa noite {Name}, Hoje é {data}";
        }

    }
}
