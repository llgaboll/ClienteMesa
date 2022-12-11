using ClienteMesa.ViewModel;
using ClienteMesa.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ClienteMesa.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        //Fields
        ViewModelBase currentViewModel;
        //Properties
        public ViewModelBase CurrentViewModel { get { return currentViewModel; } set { currentViewModel = value; onPropertyChanged(nameof(currentViewModel)); } }

        //Commands
        public ICommand MostrarCategoriaMenuCommand { get;}
        // Constructor
        public MainViewModel()
        {
            //CurrentViewModel = new MenuCategoriaViewModel();
            CurrentViewModel = new MesaNumeroViewModel();
        }
        // Methods

    }
}
