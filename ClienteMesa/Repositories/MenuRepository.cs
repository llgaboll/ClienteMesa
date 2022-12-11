using ClienteMesa.Models;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using SigloXXI.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteMesa.Repositories
{
    internal class MenuRepository : RepositoryBase, IMenuRepository
    {

        public List<MenuModel> ObtenerMenu()
        {
            MenuModel menu;
            List<MenuModel> listMenus = new List<MenuModel>();
            using (OracleConnection connection = GetConnection())
            using (var command = new OracleCommand("PKG_MENU.GET_ALL_MENU", connection))
            {
                try
                {
                    // Open Connection
                    connection.Open();
                    // Declare Command Type
                    command.CommandType = CommandType.StoredProcedure;
                    // Declare Parameters
                    OracleParameter output = command.Parameters.Add("l_cursor", OracleDbType.RefCursor, ParameterDirection.Output);
                    // Execute
                    command.ExecuteNonQuery();
                    OracleDataReader reader = ((OracleRefCursor)output.Value).GetDataReader();
                    // Return
                    while (reader.Read())
                    {
                        menu = new MenuModel()
                        {
                            nombre_menu = reader[0].ToString(),
                            descripcion = reader[1].ToString(),
                            tiempo = Convert.ToInt16(reader[2]),
                            porciones = Convert.ToInt16(reader[3]),
                            preparacion = reader[4].ToString(),
                            estado_menu = reader[5].ToString(),
                            categoria_menu = reader[6].ToString(),
                            porcentaje_ganancia = Convert.ToInt16(reader[7]),
                            valor = Convert.ToInt32(reader[8])
                        };
                        listMenus.Add(menu);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                // Close Connection
                connection.Close();
            }
            return listMenus;
        }


    }
}
