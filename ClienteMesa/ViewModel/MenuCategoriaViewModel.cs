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
        public ICommand MostrarMenuCartaCommand { get; }
        public ICommand MostrarMenuBebestibleCommand { get; }
        public ICommand MostrarMenuEnsaladaCommand { get; }
        public ICommand MostrarCarritoCommand { get; }

        // Constructor
        public MenuCategoriaViewModel()
        {
            MostrarMenuDelDiaCommand = new ViewModelCommand(ExecuteMostrarMenuDelDiaCommand);
            MostrarMenuCartaCommand = new ViewModelCommand(ExecuteMostrarMenuCartaCommand);
            MostrarMenuBebestibleCommand = new ViewModelCommand(ExecuteMostrarMenuBebestibleCommand);
            MostrarMenuEnsaladaCommand = new ViewModelCommand(ExecuteMostrarMenuEnsaladaCommand);
            MostrarCarritoCommand = new ViewModelCommand(ExecuteMostrarCarritoCommand);
        }

        // Methods
        private void ExecuteMostrarMenuDelDiaCommand(object obj)
        {
            CurrentViewModel = new MenuDiaViewModel();
        }
        private void ExecuteMostrarMenuCartaCommand(object obj)
        {
            CurrentViewModel = new MenuCartaViewModel();
        }
        private void ExecuteMostrarMenuBebestibleCommand(object obj)
        {
            CurrentViewModel = new MenuBebestibleViewModel();
        }
        private void ExecuteMostrarMenuEnsaladaCommand(object obj)
        {
            CurrentViewModel = new MenuEnsaladaViewModel();
        }
        private void ExecuteMostrarCarritoCommand(object obj)
        {
            CurrentViewModel = new CarritoViewModel();
        }
    }
}
