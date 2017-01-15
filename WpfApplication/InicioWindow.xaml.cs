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
using ClassLibrary;
using System.IO;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for InicioWindow.xaml
    /// </summary>
    public partial class InicioWindow : Window
    {
        public InicioWindow()
        {
            InitializeComponent();
        }
        MySQL.DB_connect db = new MySQL.DB_connect();
         List<MySQL.patient> lstPaciente = new List<MySQL.patient>();
         List<MySQL.patient> lstPacienteA = new List<MySQL.patient>();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (db.ConnectDB())
            {
                lstPaciente = db.Select_Patients();
                lstPacienteA = new List<MySQL.patient>();
                FillView();
            }
            else
                MessageBox.Show("Error al conectarse con la BD");

            txtBuscar.Focus();
        }
        
        private void FillView()
        {
            try
            {
                foreach (var item in lstPaciente)
                {
                    string[] nombre = item.name.Split('~');
                    lstPacientes.Items.Add(new ListViewData(nombre[0] + " " + nombre[1],item.register_day.Year.ToString(), item.mail, item.phone));
                    lstPacientes.SelectedIndex = lstPacientes.Items.Count - 1;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se han registrado pacientes");
            }
            

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                MySQL.Operaciones op = new MySQL.Operaciones();
                lstPacienteA.Clear();
                lstPacientes.Items.Clear();
                foreach (var item in db.Select_Patients())
                {
                    string[] nombre = item.name.Split('~');
                    string name = nombre[0] + " " + nombre[1];
                    if (name.ToUpper().Contains(txtBuscar.Text.ToUpper()))
                    {
                        lstPacientes.Items.Add(new ListViewData(name, item.register_day.Year.ToString(), item.mail, item.phone));
                        lstPacienteA.Add(item);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewpac_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var window = new HNWindow(null, 'I');
                window.Show();
                this.Hide();
            }
            catch (Exception  ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstPacientes_MouseUp(object sender, MouseButtonEventArgs e)
        {
            try
            {


                if (lstPacientes.SelectedItems.Count==lstPacienteA.Count)
                {
                    ConsultaWindow w = new ConsultaWindow(lstPacienteA[lstPacientes.SelectedIndex]);
                    w.Show();
                    Hide();
                }
                else
                {
                    ConsultaWindow  w = new ConsultaWindow(lstPaciente[lstPacientes.SelectedIndex]);
                    w.Show();
                    Hide();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Selección Inválida");
            }
        }

    }
}
