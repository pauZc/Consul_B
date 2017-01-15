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

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for ConsultaWindow.xaml
    /// </summary>
    public partial class ConsultaWindow : Window
    {
        MySQL.DB_connect db = new MySQL.DB_connect();
        MySQL.patient paciente;
        public ConsultaWindow(MySQL.patient patient)
        {
            paciente = patient;
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            try
            {
                lblDate.Content = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
                string[] name = paciente.name.Split('~');
                lblName.Content = name[0]+" "+name[1];
                //lblEdad.Content =  //MySQL.Operaciones.CalcularEdad(paciente.birthdate).ToString();
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CargarDatos()
        {
            lstCitas.Items.Clear();
            foreach (var item in db.Select_PatientDates(paciente.id))
            {
                lstCitas.Items.Add(item.datep.Day + "/" + item.datep.Month + "/" + item.datep.Year);
            }
        }
        private void lstCitas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var lista = db.Select_PatientDates(paciente.id);
                btnSave.IsEnabled=false;
                int posicion = int.Parse(lstCitas.SelectedIndex.ToString());
                txtGrasa.Text = lista[posicion].fat.ToString();
                txtMagra.Text = lista[posicion].skinny.ToString();
                txtWeight.Text = lista[posicion].weight.ToString();
                txtComent.Text = lista[posicion].coment.ToString();
                lblDate.Content = lista[posicion].datep.ToString();
          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            txtComent.Text = "";
            txtWeight.Text = "";
            txtMagra.Text = "";
            txtGrasa.Text = "";
            lblDate.Content = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            btnSave.IsEnabled = true;
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtGrasa.Text != "" || txtMagra.Text != "" || txtWeight.Text != "")
                {


                    if (db.Insert_Date(new MySQL.date
                    {
                        datep = DateTime.Now,
                        fat = double.Parse(txtGrasa.Text),
                        skinny = double.Parse(txtMagra.Text),
                        weight = double.Parse(txtWeight.Text),
                        id_patient = paciente.id,
                        coment = txtComent.Text
                    }))
                    {
                        MessageBox.Show("Cita agregada");
                        Clear_Click(Clean, null);
                        CargarDatos();
                    }
                    else
                    {
                        MessageBox.Show("No se agrego la cita");
                    }
                }
                else
                {
                    MessageBox.Show("Campos vacios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex.Message);
            }
        }

      

        private void btnHN_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                var window = new HNWindow(db.Select_Patient(paciente.id), 'C');
                window.Show();
                this.Hide();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }

        private void UIElement_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            var w = new InicioWindow();
            w.Show();
            Hide();
        }

        
    }
}
