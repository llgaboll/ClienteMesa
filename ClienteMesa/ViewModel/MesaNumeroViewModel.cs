using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClienteMesa.ViewModel
{
    public class MesaNumeroViewModel : ViewModelBase
    {
        //Fields
        ViewModelBase currentViewModel; 
        private string isVisibleMesaNumero = "Visible";
        //Properties
        public ViewModelBase CurrentViewModel { get { return currentViewModel; } set { currentViewModel = value; onPropertyChanged(nameof(currentViewModel)); } }
        public string IsVisibleMesaNumero { get { return isVisibleMesaNumero; } set { isVisibleMesaNumero = value; onPropertyChanged(nameof(IsVisibleMesaNumero)); } }

        //Commands
        public ICommand MostrarCategoriaMenuCommand { get; }
        // Constructor
        public MesaNumeroViewModel()
        {
            MostrarCategoriaMenuCommand = new ViewModelCommand(ExecuteMostrarCategoriaMenuCommand);
        }
        // Methods
        private void ExecuteMostrarCategoriaMenuCommand(object obj)
        {
            IsVisibleMesaNumero = "Hidden";
            CurrentViewModel = new MenuCategoriaViewModel();

        }
    }
}
