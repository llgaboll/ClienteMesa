using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClienteMesa.ViewModel
{
    public class CarritoViewModel : ViewModelBase
    {
        //Fields
        ViewModelBase currentViewModel;
        //Properties
        public ViewModelBase CurrentViewModel { get { return currentViewModel; } set { currentViewModel = value; onPropertyChanged(nameof(currentViewModel)); } }

        //Commands
        public ICommand MostrarCategoriaMenuCommand { get; }
        // Constructor
        public CarritoViewModel()
        {
           
        }
        // Methods
    }
}
