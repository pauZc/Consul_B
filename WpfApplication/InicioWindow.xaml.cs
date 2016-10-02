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
        private static List<Paciente> lstPaciente;
        private static List<Paciente> lstPacienteA;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                lstPaciente = Reader.BuscarPacientes();
                lstPacienteA = new List<Paciente>();
                FillView();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
        private void FillView()
        {
           

            foreach (var item in lstPaciente)
            {
                int edad = CalcularEdad(DateTime.Parse(item.birthday));
                lstPacientes.Items.Add(new ListViewData(item.nombre,edad.ToString(), item.correo, item.telefono));
                lstPacientes.SelectedIndex = lstPacientes.Items.Count - 1;

            }

        }
        public int CalcularEdad(DateTime bday)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - bday.Year;
            if (bday > today.AddYears(-age)) age--;
            return age;
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                lstPacienteA.Clear();
                lstPacientes.Items.Clear();
                foreach (var item in lstPaciente)
                {
                    if (item.nombre.ToUpper().Contains(txtBuscar.Text.ToUpper()))
                    {
                        lstPacientes.Items.Add(new ListViewData(item.nombre, CalcularEdad(DateTime.Parse(item.birthday)).ToString(), item.correo, item.telefono));
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
                var window = new HNWindow(false, "");
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

               if(lstPacienteA.Count!=0)
               {
                   
                   var w = new ConsultaWindow(lstPacienteA[lstPacientes.SelectedIndex]);
                   w.Show();
               }
            else
               {
                   var w = new ConsultaWindow(lstPaciente[lstPacientes.SelectedIndex]);
                   w.Show();
               }
            
          

        }

       
    }
}
