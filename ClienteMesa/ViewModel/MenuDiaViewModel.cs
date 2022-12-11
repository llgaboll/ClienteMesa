using ClienteMesa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClienteMesa.ViewModel
{
    public class MenuDiaViewModel : ViewModelBase
    {
        //Fields
        private MenuModel menu;
        private string nombreMenu;
        private string valor;

        //Properties
        public MenuModel Menu { get { return menu; } set { menu = value; onPropertyChanged(nameof(Menu)); } }
        public string NombreMenu { get { return nombreMenu; } set { nombreMenu = value; onPropertyChanged(nameof(NombreMenu)); } }
        public string Valor { get { return valor; } set { valor = value; onPropertyChanged(nameof(Valor)); } }


        //Commands
        public ICommand OrdenarMenuCommand { get; }

        // Constructor
        public MenuDiaViewModel()
        {
            
        }

        // Methods
    }
}
