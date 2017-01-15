using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for conexion.xaml
    /// </summary>
    public partial class conexion : Window
    {
        public conexion()
        {
            InitializeComponent();
        }
        MySQL.DB_connect db = new MySQL.DB_connect();
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (db.ConnectDB())
                MessageBox.Show("EXITO");
            else
                MessageBox.Show("ERROR AL CONECTARSE");
           
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
