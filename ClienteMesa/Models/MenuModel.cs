using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteMesa.Models
{
    public class MenuModel
    {
        public string nombre_menu { get; set; }
        public string descripcion { get; set; }
        public int tiempo { get; set; }
        public int porciones { get; set; }
        public string preparacion { get; set; }
        public int valor { get; set; }
        public int porcentaje_ganancia { get; set; }
        public string estado_menu { get; set; }
        public string categoria_menu { get; set; }

    }
}
