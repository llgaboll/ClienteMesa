using ClienteMesa.Models;
using ClienteMesa.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ClienteMesa.ViewModel
{
    class MenuEnsaladaViewModel : ViewModelBase
    {
        //Fields
        private MenuModel menu;
        private ObservableCollection<MenuModel> menuList;
        private IMenuRepository menuRepository;

        //Properties
        public MenuModel Menu { get { return menu; } set { menu = value; onPropertyChanged(nameof(Menu)); } }
        public ObservableCollection<MenuModel> MenuList { get { return menuList; } set { menuList = value; onPropertyChanged(nameof(MenuList)); } }

        //Commands
        public ICommand OrdenarMenuCommand { get; }

        // Constructor
        public MenuEnsaladaViewModel()
        {
            MenuList = new ObservableCollection<MenuModel>();
            LoadMenuCards();
        }

        // Methods

        public void LoadMenuCards()
        {
            menuRepository = new MenuRepository();
            List<MenuModel> list = menuRepository.ObtenerByCategoriaMenu(1); // Cambiar ID Categoría
            foreach (var item in list)
            {
                menuList.Add(item);
            }
        }
    }
}
