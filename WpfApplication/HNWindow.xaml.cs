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
    /// Interaction logic for HNWindow.xaml
    /// </summary>
    public partial class HNWindow : Window
    {
        // bool nuevo;
        // string name="";
        MySQL.patientData patient;
        char window;
        public HNWindow(MySQL.patientData paciente, char ventana)
        {
            InitializeComponent();
            patient = paciente;
            window = ventana;
        }
        MySQL.DB_connect db = new MySQL.DB_connect();
        #region ComboValues
        string[] arrEdoCivil;
        string[] arrGenero;
        string[] arrApetito;
        string[] arrDcomer;
        string[] arrACHora;
        string[] arrAScomidas;
        string[] arrACEComidas;
        string[] arrHSMApetito;
        string[] arrPPCual;
        #endregion
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InitializeComponent();
            LlenarInterfazVacia();
            if (patient != null)
            {
                LlenarDatos();
                btnSave.IsEnabled = false;
            }
            else
                btnActualizar.IsEnabled = false;
            
        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (window == 'I')
            {
                var w = new InicioWindow();
                w.Show();
                this.Hide();
            }else
            {
                var w = new ConsultaWindow(patient.paciente);
                w.Show();
                this.Hide();
            }
        }
        private void LlenarInterfazVacia()
        {
            #region ComboValues
            arrEdoCivil = new string[]{ "Soltero(a)", "Casado(a)", "Viudo(a)", "Divorviado(a)", "X" };
            arrGenero = new string[] { "Hombre", "Mujer", "X" };
            arrApetito = new string[] { "Bueno", "Moderado", "Pobre", "X" };
            arrDcomer = new string[] { "Si", "No", "En ocasiones", "Nunca", "X" };
            arrACHora = new string[] { "Si", "No", "Lunes a Viernes", "X" };
            arrAScomidas = new string[] { "Si", "No", "Algunas veces", "X" };
            arrACEComidas = new string[] { "Si", "No", "X" };
            arrHSMApetito = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "X" };
            arrPPCual = new string[] { "Bajo peso", "Sobrepeso", "Obesidad", "Inestabilidad", "X" };
            #endregion
            foreach (var item in arrHSMApetito) cmbHSMApetito.Items.Add(item);
            foreach (var item in arrPPCual) cmbPPCual.Items.Add(item);
            foreach (var item in arrGenero) cmbGenero.Items.Add(item);
            foreach (var item in arrEdoCivil) cmbEdoCivil.Items.Add(item);
            foreach (var item in arrApetito) cmbApetito.Items.Add(item);
            foreach (var item in arrDcomer) cmbDComer.Items.Add(item);
            foreach (var item in arrACHora) cmbACHora.Items.Add(item);
            foreach (var item in arrAScomidas) cmbASComidas.Items.Add(item);
            foreach (var item in arrACEComidas) cmbACEComidas.Items.Add(item);
            cmbHSMApetito.SelectedValue = "X";
            cmbPPCual.SelectedValue = "X";
            cmbGenero.SelectedValue = "X";
            cmbEdoCivil.SelectedValue = "X";
            cmbApetito.SelectedValue = "X";
            cmbDComer.SelectedValue = "X";
            cmbACHora.SelectedValue = "X";
            cmbASComidas.SelectedValue = "X";
            cmbACEComidas.SelectedValue = "X";
            p4d3.IsEnabled = false;
            p4d4.IsEnabled = false;
            dm1.IsEnabled = false;
            dm2.IsEnabled = false;
            dm3.IsEnabled = false;
            dm4.IsEnabled = false;
            dm5.IsEnabled = false;
            dm6.IsEnabled = false;
            dm7.IsEnabled = false;
            dm8.IsEnabled = false;
            p5d2.IsEnabled = false;
            p6d5.IsEnabled = false;
            cmbPPCual.IsEnabled = false;
            p6d6.IsEnabled = false;
            p7d2.IsEnabled = false;
            p7d3a.IsEnabled = false;
            p7d3b.IsEnabled = false;
            p7d3c.IsEnabled = false;
            p7d3d.IsEnabled = false;
            p7d3e.IsEnabled = false;
            p7d3f.IsEnabled = false;
            p7d3g.IsEnabled = false;
            p7d3h.IsEnabled = false;
            p7d3i.IsEnabled = false;
            p7d4.IsEnabled = false;
            p7d5.IsEnabled = false;
            p7d6.IsEnabled = false;
            p7d7.IsEnabled = false;
            p7d9.IsEnabled = false;
            p7d11.IsEnabled = false;
            p4d3.IsEnabled = false;
            p4d4.IsEnabled = false;
        }
        private int calcularEdad_ingreso()
        {
            try
            {
                return (patient.paciente.age+(DateTime.Now.Year - patient.paciente.register_day.Year));
            }
            catch (Exception)
            {
                return 0;
            }
          
        }
        private void LlenarDatos()
        {
            string[] split = patient.paciente.name.Split('~');
            //////////////Nombre
            p1d1.Text = split[0];
            p1d2.Text = split[1];
            /////////////edad
            if (patient.paciente.register_day.Year == DateTime.Now.Year)
                txtedad.Text = patient.paciente.age.ToString();
            else
                txtedad.Text = "aprox: " + (calcularEdad_ingreso() - 1).ToString() + "-" + calcularEdad_ingreso().ToString();//patient.paciente.birthdate.Day + "/" + patient.paciente.birthdate.Month + "/" + patient.paciente.birthdate.Year;
            if (patient.paciente.gender == 'M')
            {
                cmbGenero.Text = "Mujer";
                dm1.Text = patient.mujer.first_day.ToString();
                dm2.Text = patient.mujer.last_day.ToString();
                dm3.Text = patient.mujer.duration.ToString();
                if (patient.mujer.contraceptive.ToString() == null)
                    dm4.Text = " ";
                else
                    dm4.Text = patient.mujer.contraceptive.ToString();
                split = patient.mujer.pregnancy.Split('~');
                dm5.Text = split[0];
                dm6.Text = split[1];
                if (patient.mujer.suckle == '1') dm7.IsChecked = true; else dm7.IsChecked = false;
                if (patient.mujer.menopause == '1') dm8.IsChecked = true; else dm8.IsChecked = false;
            }
            else
                cmbGenero.Text = "Hombre";
            p1d1.IsEnabled = false;
            p1d2.IsEnabled = false;
            txtedad.IsEnabled = false;
            cmbGenero.IsEnabled = false;
            ///////////////////////////////////////Campos que pueden cambiar////////////////////////////////////////////////
            //////////Esatdo civil
            cmbEdoCivil.SelectedValue = (from s in arrEdoCivil where s[0] == patient.paciente.civil_status select s).Single().ToString();
            p1d4.Text = patient.paciente.ocupation;
            p1d5.Text = patient.paciente.phone;
            p1d6.Text = patient.paciente.mail;
            split = patient.paciente.past_family.Split('~');
            #region past family
            if (split[0] == "1")
                p2d1a.IsChecked = true;
            else
                p2d1a.IsChecked = false;
            if (split[1] == "1")
                p2d1b.IsChecked = true;
            else
                p2d1b.IsChecked = false;
            if (split[2] == "1")
                p2d1c.IsChecked = true;
            else
                p2d1c.IsChecked = false;
            if (split[3] == "1")
                p2d1d.IsChecked = true;
            else
                p2d1d.IsChecked = false;
            if (split[4] == "1")
                p2d1e.IsChecked = true;
            else
                p2d1e.IsChecked = false;
            if (split[5] == "1")
                p2d1f.IsChecked = true;
            else
                p2d1f.IsChecked = false;
            if (split[6] == "1")
                p2d1g.IsChecked = true;
            else
                p2d1g.IsChecked = false;
            if (split[7] == "1")
                p2d1h.IsChecked = true;
            else
                p2d1h.IsChecked = false;
            if (split[8] == "1")
                p2d1i.IsChecked = true;
            else
                p2d1i.IsChecked = false;
            if (split[9] == "1")
                p2d1j.IsChecked = true;
            else
                p2d1j.IsChecked = false;
            if (split[10] == "1")
                p2d1k.IsChecked = true;
            else
                p2d1k.IsChecked = false;
            if (split[11] == "1")
                p2d1l.IsChecked = true;
            else
                p2d1l.IsChecked = false;
            if (split[12] == "1")
                p2d1m.IsChecked = true;
            else
                p2d1m.IsChecked = false;
            if (split[13] == "1")
                p2d1n.IsChecked = true;
            else
                p2d1n.IsChecked = false;
            if (split[14] == "1")
                p2d1o.IsChecked = true;
            else
                p2d1o.IsChecked = false;
            #endregion
            p2d2.Text = patient.paciente.past_personal;
            p2d3.Text = patient.paciente.surgery;
            p2d4.Text = patient.paciente.allergy;
            p3d1.Text = patient.paciente.medicine;
            split = patient.paciente.current_suffering.Split('~');
            #region current suffering
            if (split[0] == "1")
                p3d2a.IsChecked = true;
            else
                p3d2a.IsChecked = false;
            if (split[1] == "1")
                p3d2b.IsChecked = true;
            else
                p3d2b.IsChecked = false;
            if (split[2] == "1")
                p3d2c.IsChecked = true;
            else
                p3d2c.IsChecked = false;

            if (split[3] == "1")
                p3d2d.IsChecked = true;
            else
                p3d2d.IsChecked = false;

            if (split[4] == "1")
                p3d2e.IsChecked = true;
            else
                p3d2e.IsChecked = false;

            if (split[5] == "1")
                p3d2f.IsChecked = true;
            else
                p3d2f.IsChecked = false;
            if (split[6] == "1")
                p3d2g.IsChecked = true;
            else
                p3d2g.IsChecked = false;
            if (split[7] == "1")
                p3d2h.IsChecked = true;
            else
                p3d2h.IsChecked = false;
            if (split[8] == "1")
                p3d2i.IsChecked = true;
            else
                p3d2i.IsChecked = false;
            if (split[9] == "1")
                p3d2j.IsChecked = true;
            else
                p3d2j.IsChecked = false;
            if (split[10] == "1")
                p3d2k.IsChecked = true;
            else
                p3d2k.IsChecked = false;
            if (split[11] == "1")
                p3d2l.IsChecked = true;
            else
                p3d2l.IsChecked = false;
            if (split[12] == "1")
                p3d2m.IsChecked = true;
            else
                p3d2m.IsChecked = false;
            if (split[13] == "1")
                p3d2n.IsChecked = true;
            else
                p3d2n.IsChecked = false;
            if (split[14] == "1")
                p3d2o.IsChecked = true;
            else
                p3d2o.IsChecked = false;
            if (split[15] == "1")
                p3d2p.IsChecked = true;
            else
                p3d2p.IsChecked = false;
            if (split[16] == "1")
                p3d2q.IsChecked = true;
            else
                p3d2q.IsChecked = false;
            if (split[17] == "1")
                p3d2r.IsChecked = true;
            else
                p3d2r.IsChecked = false;
            if (split[18] == "1")
                p3d2s.IsChecked = true;
            else
                p3d2s.IsChecked = false;
            if (split[19] == "1")
                p3d2t.IsChecked = true;
            else
                p3d2t.IsChecked = false;
            if (split[20] == "1")
                p3d2u.IsChecked = true;
            else
                p3d2u.IsChecked = false;
            if (split[21] == "1")
                p3d3a.IsChecked = true;
            else
                p3d3a.IsChecked = false;
            if (split[22] == "1")
                p3d3b.IsChecked = true;
            else
                p3d3b.IsChecked = false;
            if (split[23] == "1")
                p3d3c.IsChecked = true;
            else
                p3d3c.IsChecked = false;

            if (split[24] == "1")
                p3d3d.IsChecked = true;
            else
                p3d3d.IsChecked = false;

            if (split[25] == "1")
                p3d3e.IsChecked = true;
            else
                p3d3e.IsChecked = false;

            if (split[26] == "1")
                p3d3f.IsChecked = true;
            else
                p3d3f.IsChecked = false;

            if (split[27] == "1")
                p3d3g.IsChecked = true;
            else
                p3d3g.IsChecked = false;
            if (split[28] == "1")
                p3d3h.IsChecked = true;
            else
                p3d3h.IsChecked = false;
            if (split[29] == "1")
                p3d3i.IsChecked = true;
            else
                p3d3i.IsChecked = false;
            #endregion
            switch (patient.paciente.daily_activity)
            {
                case 'X': p4d1a.IsChecked = true; break;
                case 'L': p4d1b.IsChecked = true; break;
                case 'P': p4d1c.IsChecked = true; break;
                case 'E': p4d1d.IsChecked = true; break;
                default:
                    break;
            }
            split = patient.paciente.sport.Split('~');
            if (split[0] == "1")
            {
                p4d2.IsChecked = true;
                p4d3.Text = split[1];
                p4d4.Text = split[2];
            }
            split = patient.paciente.apetite.Split('~');
            cmbApetito.Text = (from s in arrApetito where s[0] == char.Parse(split[0]) select s).Single().ToString();
            cmbDComer.Text = (from s in arrDcomer where s[0] == char.Parse(split[1]) select s).Single().ToString();
            p5d1.Text = split[2];
            cmbACHora.Text = (from s in arrACHora where s[0] == char.Parse(split[3]) select s).Single().ToString();
            cmbASComidas.Text = (from s in arrAScomidas where s[0] == char.Parse(split[4]) select s).Single().ToString();
            cmbACEComidas.Text = (from s in arrACEComidas where s[0] == char.Parse(split[5]) select s).Single().ToString();
            cmbHSMApetito.Text = split[6];
            p5d2.Text = patient.paciente.snack;
            p5d4.Text = patient.paciente.prefer_food;
            p5d3.Text = patient.paciente.wrong_food;

            split = patient.paciente.diet.Split('~');
            p6d1.Text = split[0];
            p6d2.Text = split[1];
            p6d3.Text = split[2];

            split = patient.paciente.drink.Split('~');
            p6d4.Text = split[0];
            if(split[1]=="1") p6dc1.IsChecked = true;

            split = patient.paciente.tracing_weight.Split('~');
            if (split[0] == "1") p6dc2.IsChecked = true;
            if (split[1] == "1") p6dc3.IsChecked = true;
            cmbPPCual.Text= (from s in arrPPCual where s[0] == char.Parse(split[2]) select s).Single().ToString();

            split = patient.paciente.frequency_weight.Split('~');
            p6d5.Text = split[0];
            p6d11.Text = split[1];
            p6d12.Text = split[2];

            p6d6.Text = patient.paciente.start_pweight.ToString();

            split = patient.paciente.max_weight.Split('~');
            p6d7.Text = split[0];
            p6d9.Text = split[1];

            split = patient.paciente.min_weight.Split('~');
            p6d8.Text = split[0];
            p6d10.Text = split[1];

            split = patient.paciente.alcohol.Split('~');
            if (split[0] == "1") p7d1.IsChecked = true;
            switch (split[1])
            {
                case "a": p7d3a.IsChecked = true; break;
                case "b": p7d3b.IsChecked = true; break;
                case "c": p7d3c.IsChecked = true; break;
                case "d": p7d3d.IsChecked = true; break;
                case "e": p7d3e.IsChecked = true; break;
                case "f": p7d3f.IsChecked = true; break;
                case "g": p7d3g.IsChecked = true; break;
                case "h": p7d3h.IsChecked = true; break;
                case "i": p7d3i.IsChecked = true; break;
                default: break;
            }
            p7d5.Text = split[2];
            if (split[3] == "1") p7d6.IsChecked = true;
            if (split[4] == "1") p7d7.IsChecked = true;

            split = patient.paciente.alcohol_details.Split('~');
            p7d2.Text = split[0].ToString();
            p7d4.Text = split[1].ToString();

            split = patient.paciente.smoke.Split('~');
            if (split[0] == "1") p7d8.IsChecked = true;
            p7d9.Text = split[1];

            split = patient.paciente.drugs.Split('~');
            if (split[0] == "1") p7d10.IsChecked = true;
            p7d11.Text = split[1];

            p2d4.Text = patient.paciente.allergy;

            split = patient.paciente.diagnostic.Split('~');
            p8d1.Text = split[0];
            p8d2.Text = split[1];
            p8d3.Text = split[2];
            p8d4.Text = split[3];
            p8d5.Text = split[4];
            p8d6.Text = split[5];
            p8d7.Text = split[6];
            p8d8.Text = split[7];
            p8d9.Text = split[8];
            p8d10.Text = split[9];
            p8d11.Text = split[10];

            txtComents.Text = patient.paciente.patientcol;
        }
        #region Guardar
        private bool Verificar_Vacios()
        {
            try
            {
                if (p1d1.Text == "" || p1d2.Text == "")
                {//nombre y apellido
                    MessageBox.Show("Se debe especificar el campo");
                    TB1.IsSelected = true;
                    p1d1.BorderBrush = Brushes.Red;
                    p1d2.BorderBrush = Brushes.Red;
                    p1d1.Focus();
                    return false;
                }
                /*
                if (p1d3.Text == "")
                {//cumpleaños

                    MessageBox.Show("Se debe especificar la edad del paciente");
                    TB1.IsSelected = true;
                    p1d3.BorderBrush = Brushes.Red;
                    p1d3.Focus();
                    return false;
                }
                else
                {
                    
                    if (p1d3.SelectedDate.Value.Year == DateTime.Now.Year)
                    {
                        MessageBox.Show("La persona no puede tener 0 años");
                        TB1.IsSelected = true;
                        p2d3.BorderBrush = Brushes.Red;
                        p1d3.Focus();
                        return false;
                    }
                }*/

                if (cmbGenero.SelectedValue == null)
                {
                    MessageBox.Show("Se debe especificar el campo");
                    TB1.IsSelected = true;
                    cmbGenero.Focus();
                    return false;
                }
                if (cmbEdoCivil.SelectedValue == null)
                {
                    MessageBox.Show("Se debe especificar el campo");
                    TB1.IsSelected = true;
                    cmbEdoCivil.Focus();
                    return false;
                }
                if (p1d4.Text == "")
                {//ocupacion
                    MessageBox.Show("Se debe especificar el campo");
                    TB1.IsSelected = true;
                    p1d4.Focus();
                    return false;
                }
                if (p1d5.Text == "")
                {//telefono
                    MessageBox.Show("Se debe especificar el campo");
                    TB1.IsSelected = true;
                    p1d5.Focus();
                    return false;
                }
                if (p1d6.Text == "")
                {//correo
                    MessageBox.Show("Se debe especificar el campo");
                    TB1.IsSelected = true;
                    p1d6.Focus();
                    return false;
                }
                if (p4d1a.IsChecked==false && p4d1b.IsChecked == false && p4d1c.IsChecked == false && p4d1d.IsChecked==false && p4d1e.IsChecked==false)
                {//correo
                    MessageBox.Show("Se debe especificar el campo");
                    TabActv.IsSelected = true;
                    p4d1a.Focus();
                    return false;
                }
                /*
                if (cmbGenero.Text == "Mujer")
                {
                    if (dm1.Text == "")
                    {//edad de primer ciclo
                        MessageBox.Show("Se debe especificar el campo");
                        TB1.IsSelected = true;
                        dm1.Focus();
                        return false;
                    }
                    if (dm2.Text == null)
                    {//ultimo ciclo
                        MessageBox.Show("Se debe especificar el campo");
                        TB1.IsSelected = true;
                        dm2.Focus();
                        return false;
                    }
                    if (dm3.Text == "")
                    {//dias de periodo
                        MessageBox.Show("Se debe especificar el campo");
                        TB1.IsSelected = true;
                        dm3.Focus();
                        return false;
                    }
                }*/
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private MySQL.patient crearPaciente()
        {
            try
            {
                MySQL.patient paciente = new MySQL.patient();
                string cadena = "";
                //nombre::apellido
                paciente.name = p1d1.Text + "~" + p1d2.Text;
                if (window == 'I')
                    paciente.age = int.Parse(txtedad.Text);
                else
                    paciente.age = patient.paciente.age;
                paciente.gender = cmbGenero.Text[0];
                paciente.civil_status = cmbEdoCivil.Text[0];
                paciente.ocupation = p1d4.Text;
                paciente.phone = p1d5.Text;
                paciente.mail = p1d6.Text;
                paciente.register_day = DateTime.Now.Date;
                if (p2d1a.IsChecked == true) { cadena = "1~"; } else { cadena = "0~"; }
                if (p2d1b.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p2d1c.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p2d1d.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p2d1e.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p2d1f.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p2d1g.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p2d1h.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p2d1i.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p2d1j.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p2d1k.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p2d1l.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p2d1m.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p2d1n.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p2d1o.IsChecked == true) { cadena += "1"; } else { cadena += "0"; }
                paciente.past_family = cadena;


                paciente.past_personal = p2d2.Text;
                paciente.surgery = p2d3.Text;
                paciente.medicine = p3d1.Text;

                if (p3d2a.IsChecked == true) { cadena = "1~"; } else { cadena = "0~"; }
                if (p3d2b.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d2c.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d2d.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d2e.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d2f.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d2g.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d2h.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d2i.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d2j.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d2k.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d2l.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d2m.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d2n.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d2o.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d2p.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d2q.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d2r.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d2s.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d2t.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d2u.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d3a.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d3b.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d3c.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d3d.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d3e.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d3f.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d3g.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d3h.IsChecked == true) { cadena += "1~"; } else { cadena += "0~"; }
                if (p3d3i.IsChecked == true) { cadena += "1"; } else { cadena += "0"; }
                paciente.current_suffering = cadena;

                char seleccion = ' ';
                if (p4d1a.IsChecked == true)
                    seleccion = 'X';
                if (p4d1b.IsChecked == true)
                    seleccion = 'L';
                if (p4d1c.IsChecked == true)
                    seleccion = 'P';
                if (p4d1d.IsChecked == true)
                    seleccion = 'E';
                paciente.daily_activity = seleccion;

                cadena = (p4d2.IsChecked == true) ? "1" : "0";
                cadena += "~" + p4d3.Text + "~" + p4d4.Text;
                paciente.sport = cadena;

                paciente.apetite = cmbApetito.Text[0].ToString() + "~" + cmbDComer.Text[0].ToString() + "~" + p5d1.Text + "~" + cmbACHora.Text[0].ToString() + "~" + cmbASComidas.Text[0].ToString() + "~" + cmbACEComidas.Text[0].ToString() + "~" + cmbHSMApetito.Text;
                paciente.snack = p5d2.Text;
                paciente.prefer_food = p5d4.Text;
                paciente.wrong_food = p5d3.Text;
                paciente.diet = p6d1.Text + "~" + p6d2.Text + "~" + p6d3.Text;

                cadena = p6d4.Text + "~";
                cadena += (p6dc1.IsChecked == true) ? "1" : "0";
                paciente.drink = cadena;

                cadena = (p6dc2.IsChecked == true) ? "1" : "0";
                cadena += "~";
                cadena += (p6dc3.IsChecked == true) ? "1" : "0";
                cadena += "~" + cmbPPCual.Text[0].ToString();
                paciente.tracing_weight = cadena;

                paciente.frequency_weight = p6d5.Text + "~" + p6d11.Text + "~" + p6d12.Text;
                paciente.start_pweight = p6d6.Text;
                paciente.max_weight = p6d7.Text + "~" + p6d9.Text;
                paciente.min_weight = p6d8.Text + "~" + p6d10.Text;

                cadena = (p7d1.IsChecked == true) ? "1" : "0";
                cadena += "~";
                if (p7d3a.IsChecked == true) cadena += "a";
                else
                if (p7d3b.IsChecked == true) cadena += "b";
                else
                if (p7d3c.IsChecked == true) cadena += "c";
                else
                if (p7d3d.IsChecked == true) cadena += "d";
                else
                if (p7d3e.IsChecked == true) cadena += "e";
                else
                if (p7d3f.IsChecked == true) cadena += "f";
                else
                if (p7d3g.IsChecked == true) cadena += "g";
                else
                if (p7d3h.IsChecked == true) cadena += "h";
                else
                if (p7d3i.IsChecked == true) cadena += "i";
                else
                    cadena += "n";
                cadena += "~" + p7d5.Text + "~";
                cadena += (p7d6.IsChecked == true) ? "1" : "0";
                cadena += "~";
                cadena += (p7d7.IsChecked == true) ? "1" : "0";
                paciente.alcohol = cadena;

                paciente.alcohol_details = p7d2.Text + "~" + p7d4.Text;

                cadena = (p7d8.IsChecked == true) ? "1" : "0";
                cadena += "~" + p7d9.Text;
                paciente.smoke = cadena;

                cadena = (p7d10.IsChecked == true) ? "1" : "0";
                cadena += "~" + p7d11.Text;
                paciente.drugs = cadena;

                paciente.allergy = p2d4.Text;
                paciente.diagnostic = p8d1.Text + "~" + p8d2.Text + "~" + p8d3.Text + "~" + p8d4.Text + "~" + p8d5.Text + "~" + p8d6.Text + "~" + p8d7.Text + "~" + p8d8.Text + "~" + p8d9.Text + "~" + p8d10.Text + "~" + p8d11.Text;
                paciente.patientcol = txtComents.Text;
                return paciente;
            }
            catch (Exception)
            {
                if (window == 'I')
                    return patient.paciente;
                else
                    return new MySQL.patient();
            }
        }
        private MySQL.woman crearMujer()
        {
            MySQL.woman w = new MySQL.woman();
            try
            {
               
                w.id_patient = db.Select_LastPatientId();
                w.first_day = int.Parse(dm1.Text);
                w.last_day = dm2.Text;
                w.duration = int.Parse(dm3.Text);
                w.contraceptive = dm4.Text;
                w.pregnancy = dm5.Text + "~" + dm6.Text;
                w.suckle = (dm7.IsChecked == true) ? '1' : '0';
                w.menopause = (dm8.IsChecked == true) ? '1' : '0';
                return w;
            }
            catch (Exception)
            {
                return w;
            }
        }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            
            if (Verificar_Vacios())
            {
                if (db.Insert_Patient(crearPaciente()))
                {
                    if (cmbGenero.Text == "Mujer")
                    {
                        if (db.Insert_Woman(crearMujer()))
                        {
                            MessageBox.Show("Paciente agregado");
                        }
                        else
                        {
                            MessageBox.Show("ERROR - M");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Paciente agregado");
                    }
                   
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
        }
        #endregion
        #region Validaciones Interfaz
        private void cmbGenero_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbGenero.SelectedItem == "Mujer")
            {
                dm1.IsEnabled = true;
                dm2.IsEnabled = true;
                dm3.IsEnabled = true;
                dm4.IsEnabled = true;
                dm5.IsEnabled = true;
                dm6.IsEnabled = true;
                dm7.IsEnabled = true;
                dm8.IsEnabled = true;
            }
            else
            {
                dm1.IsEnabled = false;
                dm2.IsEnabled = false;
                dm3.IsEnabled = false;
                dm4.IsEnabled = false;
                dm5.IsEnabled = false;
                dm6.IsEnabled = false;
                dm7.IsEnabled = false;
                dm8.IsEnabled = false;
            }
        }

        private void cmbACEComidas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbACEComidas.SelectedItem == "Si")
            {
                p5d2.IsEnabled = true;
            }
            else
                p5d2.IsEnabled = false;
        }

        private void p4d2_Checked(object sender, RoutedEventArgs e)
        {
            p4d3.IsEnabled = true;
            p4d4.IsEnabled = true;
        }

        private void p6dc2_Checked(object sender, RoutedEventArgs e)
        {
            p6d5.IsEnabled = true;
        }

        private void p6dc3_Checked(object sender, RoutedEventArgs e)
        {
            cmbPPCual.IsEnabled = true;
            p6d6.IsEnabled = true;
        }

        private void p7d1_Checked(object sender, RoutedEventArgs e)
        {
            p7d2.IsEnabled = true;
            p7d3a.IsEnabled = true;
            p7d3b.IsEnabled = true;
            p7d3c.IsEnabled = true;
            p7d3d.IsEnabled = true;
            p7d3e.IsEnabled = true;
            p7d3f.IsEnabled = true;
            p7d3g.IsEnabled = true;
            p7d3h.IsEnabled = true;
            p7d3i.IsEnabled = true;
            p7d4.IsEnabled = true;
            p7d5.IsEnabled = true;
            p7d6.IsEnabled = true;
            p7d7.IsEnabled = true;
        }

        private void p7d8_Checked(object sender, RoutedEventArgs e)
        {
            p7d9.IsEnabled = true;
        }

        private void p7d10_Checked(object sender, RoutedEventArgs e)
        {
            p7d11.IsEnabled = true;
        }

        private void p7d10_Unchecked(object sender, RoutedEventArgs e)
        {
            p7d11.IsEnabled = false;
        }

        private void p7d8_Unchecked(object sender, RoutedEventArgs e)
        {
            p7d9.IsEnabled = false;
        }

        private void p7d1_Unchecked(object sender, RoutedEventArgs e)
        {
            p7d2.IsEnabled = false;
            p7d3a.IsEnabled = false;
            p7d3b.IsEnabled = false;
            p7d3c.IsEnabled = false;
            p7d3d.IsEnabled = false;
            p7d3e.IsEnabled = false;
            p7d3f.IsEnabled = false;
            p7d3g.IsEnabled = false;
            p7d3h.IsEnabled = false;
            p7d3i.IsEnabled = false;
            p7d4.IsEnabled = false;
            p7d5.IsEnabled = false;
            p7d6.IsEnabled = false;
            p7d7.IsEnabled = false;
        }

        private void p6dc2_Unchecked(object sender, RoutedEventArgs e)
        {
            p6d5.IsEnabled = false;
        }

        private void p6dc3_Unchecked(object sender, RoutedEventArgs e)
        {
            cmbPPCual.IsEnabled = false;
            p6d6.IsEnabled = false ;
        }
        private void p4d2_Unchecked(object sender, RoutedEventArgs e)
        {
            p4d3.IsEnabled = false;
            p4d4.IsEnabled = false;
        }



        #endregion

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MySQL.patient p = crearPaciente();
                p.id = patient.paciente.id;
                if (db.Update_Patient(p))
                {
                    if (patient.paciente.gender == 'M')
                    {
                        MySQL.woman w = crearMujer();
                        w.id = patient.mujer.id;
                        if (db.Update_Woman(w))
                            MessageBox.Show("Paciente actualizado");
                        else
                            MessageBox.Show("Error al actualizar paciente");
                    }
                    else
                    {
                        MessageBox.Show("Paciente actualizado");
                    }
                    
                }else
                {
                    MessageBox.Show("Error al actualizar paciente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
