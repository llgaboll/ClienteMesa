using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteMesa.Models
{
    internal interface IMenuRepository
    {
        public List<MenuModel> ObtenerByCategoriaMenu(int idCategoria);
    }
}
