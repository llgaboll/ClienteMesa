using ClienteMesa.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClienteMesa
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected void AppicationStart(object sender, StartupEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Nzc3NTI0QDMyMzAyZTMzMmUzMGVxV1RLVlhONVl0L090UHY3c1dGZkdRUlQwVGFRd2l1bXpJWmJWVVkxeWM9");
        }
    }
}
