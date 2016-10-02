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
        public ConsultaWindow(Paciente p)
        {
            InitializeComponent();
            pac = p;
        }
        List<Cita> citas;
        Paciente pac;
        InicioWindow w = new InicioWindow();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          
         
            lblDate.Content = DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year;
            lblEdad.Content = w.CalcularEdad(DateTime.Parse(pac.birthday));
            lblName.Content = pac.nombre;
            try
            {
                Extraer_citas();
                
            }
            catch (Exception )
            {
   
            }
          
        }
        public void Extraer_citas(){
            
         
                lstCitas.Items.Clear();
                citas = Reader.ExtraerCitas(pac.nombre);
                foreach (var item in citas)
                {
                    lstCitas.Items.Add(item.fecha);
                }

        }
        private void lstCitas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            try
            {
                btnSave.Visibility = Visibility.Hidden;
                int posicion = int.Parse(lstCitas.SelectedIndex.ToString());
                txtGrasa.Text = citas[posicion].grasa.ToString();
                txtMagra.Text = citas[posicion].magra.ToString();
                txtWeight.Text = citas[posicion].peso.ToString();
                txtComent.Text = citas[posicion].comentario.ToString();
                lblDate.Content = citas[posicion].fecha.ToString();
          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                LIMPIAR();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
          
        }
        private void LIMPIAR()
        {
             txtComent.Text = "";
            txtWeight.Text = "";
            txtMagra.Text = "";
            txtGrasa.Text = "";
            lblDate.Content = DateTime.Now.Date;
            btnSave.Visibility = Visibility.Visible;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (!Writer.WriteDate(pac.nombre, double.Parse(txtGrasa.Text), double.Parse(txtMagra.Text), double.Parse(txtWeight.Text), txtComent.Text))
                MessageBox.Show("ERROR: NO SE ENCONTRO ARCHIVO PARA ALMACENAR LA CITA");
            else
            {
                Extraer_citas();
                LIMPIAR();
            }
        }

      

        private void btnHN_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var window = new HNWindow(true, pac.nombre);
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
            w.Show();
           Hide();
        }
    }
}
