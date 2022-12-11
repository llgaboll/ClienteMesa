using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClienteMesa.ViewModel
{
    public class MenuCategoriaViewModel : ViewModelBase
    {
        // Fields
        ViewModelBase currentViewModel;

        // Propierties
        public ViewModelBase CurrentViewModel { get { return currentViewModel; } set { currentViewModel = value; onPropertyChanged(nameof(currentViewModel)); } }

        // Commands
        public ICommand MostrarMenuDelDiaCommand { get; }
        public ICommand MostrarCarritoCommand { get; }

        // Constructor
        public MenuCategoriaViewModel()
        {
            MostrarMenuDelDiaCommand = new ViewModelCommand(ExecuteMostrarMenuDelDiaCommand);
            MostrarCarritoCommand = new ViewModelCommand(ExecuteMostrarCarritoCommand);
        }

        // Methods
        private void ExecuteMostrarMenuDelDiaCommand(object obj)
        {
            CurrentViewModel = new MenuDiaViewModel();
        }
        private void ExecuteMostrarCarritoCommand(object obj)
        {
            CurrentViewModel = new CarritoViewModel();
        }
    }
}
