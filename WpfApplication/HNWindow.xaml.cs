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
        bool nuevo;
        string name="";
        public HNWindow(bool edo, string nombre)
        {
            InitializeComponent();
            nuevo = edo;
            name = nombre;
        }
        List<string> HN = new List<string>();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (nuevo == false)
            {
                LlenarCombos();
                InitializeComponent();
            }
            else
            {
                LLenarInf();
                btnSave.Visibility = Visibility.Hidden;
            }

        }
        private void LlenarCombos()
        {
            string[] arrEdoCivil = { "Soltero(a)", "Casado(a)", "Viudo(a)", "Divorviado(a)" };
            string[] arrGenero = { "Hombre", "Mujer" };
            string[] arrApetito = { "Bueno", "Moderado", "Pobre" };
            string[] arrDcomer = { "Si", "No", "En ocasiones", "Nunca" };
            string[] arrACHora = { "Si", "No", "Lunes a Viernes" };
            string[] arrAScomidas = { "Si", "No", "Algunas veces" };
            string[] arrACEComidas = { "Si", "No" };
            string[] arrHSMApetito = { "1 am", "2 am", "3 am", "4 am", "5 am", "6 am", "7 am", "8 am", "9 am", "10 am", "11 am", "12 pm", "1 pm", "2 pm", "3 pm", "4 pm", "5 pm", "6 pm", "7 pm", "8 pm", "9 pm", "10 pm", "11 pm", "12 am" };
           
            string[] arrPPCual = { "Bajo peso", "Sobrepeso", "Obesidad", "Inestabilidad" };
            foreach (var item in arrHSMApetito)
            {
                cmbHSMApetito.Items.Add(item);
            }
   
            foreach (var item in arrPPCual)
            {
                cmbPPCual.Items.Add(item);
            }
            foreach (var item in arrGenero)
            {
                cmbGenero.Items.Add(item);
            }
            foreach (var item in arrEdoCivil)
            {
                cmbEdoCivil.Items.Add(item);
            }
            foreach (var item in arrApetito)
            {
                cmbApetito.Items.Add(item);
            }
            foreach (var item in arrDcomer)
            {
                cmbDComer.Items.Add(item);
            }
            foreach (var item in arrACHora)
            {
                cmbACHora.Items.Add(item);
            }
            foreach (var item in arrAScomidas)
            {
                cmbASComidas.Items.Add(item);
            }
            foreach (var item in arrACEComidas)
            {
                cmbACEComidas.Items.Add(item);
            }
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
        private void LLenarInf()
        {
            HN = Reader.HN(name);
            p1d1.Text=HN[0].ToString();
            p1d2.Text=HN[1].ToString();
            p1d3.Text=HN[2].ToString();
            cmbGenero.Text=HN[3].ToString();
            cmbEdoCivil.Text=HN[4].ToString();
            p1d4.Text=HN[5].ToString();
            p1d5.Text=HN[6].ToString();
            p1d6.Text=HN[7].ToString();
            dm1.Text=HN[8].ToString();
            dm2.Text=HN[9].ToString();
            dm3.Text =HN[10].ToString();
            dm4.Text=HN[11].ToString();
            dm5.Text=HN[12].ToString();
            dm6.Text=HN[13].ToString();
            dm7.IsChecked=Convert(int.Parse(HN[14])); 
            dm8.IsChecked=Convert(int.Parse(HN[15]));

            

            p2d1a.IsChecked = Convert(int.Parse(HN[16]));
            p2d1b.IsChecked = Convert(int.Parse(HN[17]));
            p2d1c.IsChecked = Convert(int.Parse(HN[18]));
            p2d1d.IsChecked = Convert(int.Parse(HN[19]));
            p2d1e.IsChecked = Convert(int.Parse(HN[20]));
            p2d1f.IsChecked = Convert(int.Parse(HN[21]));
            p2d1g.IsChecked = Convert(int.Parse(HN[22]));
            p2d1h.IsChecked = Convert(int.Parse(HN[23]));
            p2d1i.IsChecked = Convert(int.Parse(HN[24]));
            p2d1j.IsChecked = Convert(int.Parse(HN[25]));
            p2d1k.IsChecked = Convert(int.Parse(HN[26]));
            p2d1l.IsChecked = Convert(int.Parse(HN[27]));
            p2d1m.IsChecked = Convert(int.Parse(HN[28]));
            p2d1n.IsChecked = Convert(int.Parse(HN[29]));
            p2d1o.IsChecked = Convert(int.Parse(HN[30]));
            new TextRange(p2d2.Document.ContentStart, p2d2.Document.ContentEnd).Text = HN[31].ToString() + HN[32].ToString();
            new TextRange(p2d3.Document.ContentStart, p2d3.Document.ContentEnd).Text = HN[33].ToString() + HN[34].ToString();


            new TextRange(p3d1.Document.ContentStart, p3d1.Document.ContentEnd).Text = HN[35].ToString() + HN[36].ToString();
            p3d2a.IsChecked= Convert(int.Parse(HN[37])); 
            p3d2b.IsChecked= Convert(int.Parse(HN[38])); 
            p3d2c.IsChecked= Convert(int.Parse(HN[39])); 
            p3d2d.IsChecked= Convert(int.Parse(HN[40])); 
            p3d2e.IsChecked= Convert(int.Parse(HN[41])); 
            p3d2f.IsChecked= Convert(int.Parse(HN[42])); 
            p3d2g.IsChecked= Convert(int.Parse(HN[43])); 
            p3d2h.IsChecked= Convert(int.Parse(HN[44])); 
            p3d2i.IsChecked= Convert(int.Parse(HN[45])); 
            p3d2j.IsChecked= Convert(int.Parse(HN[46])); 
            p3d2k.IsChecked= Convert(int.Parse(HN[47])); 
            p3d2l.IsChecked= Convert(int.Parse(HN[48])); 
            p3d2m.IsChecked= Convert(int.Parse(HN[49])); 
            p3d2n.IsChecked= Convert(int.Parse(HN[50])); 
            p3d2o.IsChecked= Convert(int.Parse(HN[51])); 
            p3d2p.IsChecked= Convert(int.Parse(HN[52])); 
            p3d2q.IsChecked= Convert(int.Parse(HN[53])); 
            p3d2r.IsChecked= Convert(int.Parse(HN[54])); 
            p3d2s.IsChecked= Convert(int.Parse(HN[55])); 
            p3d2t.IsChecked= Convert(int.Parse(HN[56])); 
            p3d2u.IsChecked= Convert(int.Parse(HN[57])); 
            p3d3a.IsChecked= Convert(int.Parse(HN[58])); 
            p3d3b.IsChecked= Convert(int.Parse(HN[59])); 
            p3d3c.IsChecked= Convert(int.Parse(HN[60])); 
            p3d3d.IsChecked= Convert(int.Parse(HN[61])); 
            p3d3e.IsChecked= Convert(int.Parse(HN[62])); 
            p3d3f.IsChecked= Convert(int.Parse(HN[63])); 
            p3d3g.IsChecked= Convert(int.Parse(HN[64])); 
            p3d3h.IsChecked= Convert(int.Parse(HN[65]));
            p3d3i.IsChecked = Convert(int.Parse(HN[66])); 


            p4d1a.IsChecked= Convert(int.Parse(HN[67])); 
            p4d1b.IsChecked= Convert(int.Parse(HN[68])); 
            p4d1c.IsChecked= Convert(int.Parse(HN[69])); 
            p4d1d.IsChecked= Convert(int.Parse(HN[70]));
            p4d1e.IsChecked = Convert(int.Parse(HN[71]));
            p4d2.IsChecked= Convert(int.Parse(HN[72]));
            p4d3.Text = HN[73].ToString();
            p4d4.Text = HN[74].ToString();

            cmbApetito.Text = HN[75].ToString();
            cmbDComer.Text= HN[76].ToString();
            p5d1.Text= HN[77].ToString();
            cmbACHora.Text= HN[78].ToString();
            cmbASComidas.Text= HN[79].ToString();
            cmbACEComidas.Text= HN[80].ToString();
            new TextRange(p5d2.Document.ContentStart, p5d2.Document.ContentEnd).Text = HN[81].ToString() + HN[82].ToString();
            cmbHSMApetito.Text= HN[83].ToString();
            new TextRange(p5d3.Document.ContentStart, p5d3.Document.ContentEnd).Text = HN[84].ToString() + HN[85].ToString();


            new TextRange(p6d1.Document.ContentStart, p6d1.Document.ContentEnd).Text = HN[86].ToString() + HN[87].ToString();
            new TextRange(p6d2.Document.ContentStart, p6d2.Document.ContentEnd).Text = HN[88].ToString() + HN[89].ToString();
            new TextRange(p6d3.Document.ContentStart, p6d3.Document.ContentEnd).Text = HN[90].ToString() + HN[91].ToString();
            p6d4.Text= HN[92].ToString();
            p6dc1.IsChecked= Convert(int.Parse(HN[93]));
            p6dc2.IsChecked= Convert(int.Parse(HN[94]));
            p6d5.Text= HN[95].ToString();
            p6dc3.IsChecked = Convert(int.Parse(HN[96]));
            cmbPPCual.Text= HN[97].ToString();
            p6d6.Text= HN[98].ToString();
            p6d7.Text= HN[99].ToString();
            p6d8.Text= HN[100].ToString();
            new TextRange(p6d9.Document.ContentStart, p6d9.Document.ContentEnd).Text = HN[101].ToString() + HN[102].ToString();
            new TextRange(p6d10.Document.ContentStart, p6d10.Document.ContentEnd).Text = HN[103].ToString() + HN[104].ToString();
            p6d11.Text= HN[105].ToString();
            p6d12.Text= HN[106].ToString();

            p7d1.IsChecked= Convert(int.Parse(HN[107]));
            p7d2.Text= HN[108].ToString();
            p7d3a.IsChecked= Convert(int.Parse(HN[109]));
            p7d3b.IsChecked= Convert(int.Parse(HN[110]));
            p7d3c.IsChecked= Convert(int.Parse(HN[111]));
            p7d3d.IsChecked= Convert(int.Parse(HN[112]));
            p7d3e.IsChecked= Convert(int.Parse(HN[113]));
            p7d3f.IsChecked= Convert(int.Parse(HN[114]));
            p7d3g.IsChecked= Convert(int.Parse(HN[115]));
            p7d3h.IsChecked= Convert(int.Parse(HN[116]));
            p7d3i.IsChecked= Convert(int.Parse(HN[117]));
            new TextRange(p7d4.Document.ContentStart, p7d4.Document.ContentEnd).Text = HN[118].ToString() + HN[119].ToString();
            p7d5.Text= HN[120].ToString();
            p7d6.IsChecked= Convert(int.Parse(HN[121]));
            p7d7.IsChecked= Convert(int.Parse(HN[122]));
            p7d8.IsChecked= Convert(int.Parse(HN[123]));
            p7d9.Text= HN[124].ToString();
            p7d10.IsChecked = Convert(int.Parse(HN[125]));
            new TextRange(p7d11.Document.ContentStart, p7d11.Document.ContentEnd).Text = HN[126].ToString() + HN[127].ToString();

            p8d1.Text= HN[128].ToString();
            p8d2.Text= HN[129].ToString();
            p8d3.Text= HN[130].ToString();
            p8d4.Text= HN[131].ToString();
            p8d5.Text= HN[132].ToString();
            p8d6.Text= HN[133].ToString();
            p8d7.Text= HN[134].ToString();
            p8d8.Text= HN[135].ToString();
            p8d9.Text= HN[136].ToString();
            p8d10.Text= HN[137].ToString();
            p8d11.Text = HN[138].ToString();

        }
        private bool Convert(int s)
        {
            if (s == 0)
                return false;
            else
                return true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var w = new InicioWindow();
            w.Show();
            this.Hide();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string error = "";
            try
            {
                if (p1d3.SelectedDate.Value.Year == DateTime.Now.Year)
                {
                    MessageBox.Show("La persona no puede tener 0 años");
                }
                else
                {
                    if (p1d1.Text != "" && p1d2.Text != "")
                    {
                        string paciente = p1d1.Text + " " + p1d2.Text;
                        Directory.NuevoFolder(paciente);
                        Recolector();
                        error = "Datos personales llenados incorrectamente";
                        var pac = new Paciente()
                        {
                            nombre = paciente,
                            birthday = p1d3.SelectedDate.Value.ToString(),
                            correo = p1d6.Text,
                            telefono = p1d5.Text
                        };
                        Writer.AlmacenarLista(pac);

                        if (!Writer.WriteHN(HN, paciente))
                        {
                            MessageBox.Show("NO SE GUARDO EL REGISTRO");
                        }
                        else
                            MessageBox.Show("REGISTRO GUARDADO");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(error);
            }
        }
        private void Recolector()
        {
         
            if (!VerificaP1())
            {
                MessageBox.Show("NO SE HA LLENADO CORRECTAMENTE LOS DATOS PERSONALES");
                TB1.Focus();
            }
           else
            {
                LlenaP1();
                LlenaP2();
                LlenaP3();
                LlenaP4();
                LlenaP5();
                LlenaP6();
                LlenaP7();
                LlenaP8();
            }
        }
        private void LlenaP1()
        {
            int[] c1 = new int[2];
            if (dm7.IsChecked == true)
                c1[0] = 1;
            else
                c1[0] = 0;
            if (dm8.IsChecked == true)
                c1[1] = 1;
            else
                c1[1] = 0;
            string[] pestana1 = { p1d1.Text, p1d2.Text, p1d3.Text,
                                    cmbGenero.Text, cmbEdoCivil.Text,
                                    p1d4.Text, p1d5.Text, p1d6.Text, dm1.Text,
                                        dm2.Text, dm3.Text, dm4.Text, dm5.Text, 
                                        dm6.Text, c1[0].ToString(), c1[1].ToString() };
            foreach (var item in pestana1)
            {
                HN.Add(item);
            }
        }
        private void LlenaP2()
        {
            int[] c1 = new int[15];
            if (p2d1a.IsChecked == true)
                c1[0] = 1;
            else
                c1[0] = 0;
            if (p2d1b.IsChecked == true)
                c1[1] = 1;
            else
                c1[1] = 0;
            if (p2d1c.IsChecked == true)
                c1[2] = 1;
            else
                c1[2] = 0;
            if (p2d1d.IsChecked == true)
                c1[3] = 1;
            else
                c1[3] = 0;
            if (p2d1e.IsChecked == true)
                c1[4] = 1;
            else
                c1[4] = 0;
            if (p2d1f.IsChecked == true)
                c1[5] = 1;
            else
                c1[5] = 0;
            if (p2d1g.IsChecked == true)
                c1[6] = 1;
            else
                c1[6] = 0;
            if (p2d1h.IsChecked == true)
                c1[7] = 1;
            else
                c1[7] = 0;
            if (p2d1i.IsChecked == true)
                c1[8] = 1;
            else
                c1[8] = 0;
            if (p2d1j.IsChecked == true)
                c1[9] = 1;
            else
                c1[9] = 0;
            if (p2d1k.IsChecked == true)
                c1[10] = 1;
            else
                c1[10] = 0;
            if (p2d1l.IsChecked == true)
                c1[11] = 1;
            else
                c1[11] = 0;
            if (p2d1m.IsChecked == true)
                c1[12] = 1;
            else
                c1[12] = 0;
            if (p2d1n.IsChecked == true)
                c1[13] = 1;
            else
                c1[13] = 0;
            if (p2d1o.IsChecked == true)
                c1[14] = 1;
            else
                c1[14] = 0;

            string[] pestana1 = { c1[0].ToString(), c1[1].ToString(), c1[2].ToString(), c1[3].ToString(), 
                                c1[4].ToString(), c1[5].ToString(), c1[6].ToString(), c1[7].ToString(),
        c1[8].ToString(), c1[9].ToString(), c1[10].ToString(), c1[11].ToString(), c1[12].ToString()
                                , c1[13].ToString(), c1[14].ToString(), new TextRange(p2d2.Document.ContentStart, p2d2.Document.ContentEnd).Text, new TextRange(p2d3.Document.ContentStart, p2d3.Document.ContentEnd).Text};
            foreach (var item in pestana1)
            {
                HN.Add(item);
            }
        }
        private void LlenaP3()
        {
            int[] c1 = new int[30];
            if (p3d2a.IsChecked == true)
                c1[0] = 1;
            else
                c1[0] = 0;
            if (p3d2b.IsChecked == true)
                c1[1] = 1;
            else
                c1[1] = 0;
            if (p3d2c.IsChecked == true)
                c1[2] = 1;
            else
                c1[2] = 0;
            if (p3d2d.IsChecked == true)
                c1[3] = 1;
            else
                c1[3] = 0;
            if (p3d2e.IsChecked == true)
                c1[4] = 1;
            else
                c1[4] = 0;
            if (p3d2f.IsChecked == true)
                c1[5] = 1;
            else
                c1[5] = 0;
            if (p3d2g.IsChecked == true)
                c1[6] = 1;
            else
                c1[6] = 0;
            if (p3d2h.IsChecked == true)
                c1[7] = 1;
            else
                c1[7] = 0;
            if (p3d2i.IsChecked == true)
                c1[8] = 1;
            else
                c1[8] = 0;
            if (p3d2j.IsChecked == true)
                c1[9] = 1;
            else
                c1[9] = 0;
            if (p3d2k.IsChecked == true)
                c1[10] = 1;
            else
                c1[10] = 0;
            if (p3d2l.IsChecked == true)
                c1[11] = 1;
            else
                c1[11] = 0;
            if (p3d2m.IsChecked == true)
                c1[12] = 1;
            else
                c1[12] = 0;
            if (p3d2n.IsChecked == true)
                c1[13] = 1;
            else
                c1[13] = 0;
            if (p3d2o.IsChecked == true)
                c1[14] = 1;
            else
                c1[14] = 0;
            if (p3d2p.IsChecked == true)
                c1[15] = 1;
            else
                c1[15] = 0;
            if (p3d2q.IsChecked == true)
                c1[16] = 1;
            else
                c1[16] = 0;
            if (p3d2r.IsChecked == true)
                c1[17] = 1;
            else
                c1[17] = 0;
            if (p3d2s.IsChecked == true)
                c1[18] = 1;
            else
                c1[18] = 0;
            if (p3d2t.IsChecked == true)
                c1[19] = 1;
            else
                c1[19] = 0;
            if (p3d2u.IsChecked == true)
                c1[20] = 1;
            else
                c1[20] = 0;
            if (p3d3a.IsChecked == true)
                c1[21] = 1;
            else
                c1[21] = 0;
            if (p3d3b.IsChecked == true)
                c1[22] = 1;
            else
                c1[22] = 0;
            if (p3d3c.IsChecked == true)
                c1[23] = 1;
            else
                c1[23] = 0;
            if (p3d3d.IsChecked == true)
                c1[24] = 1;
            else
                c1[24] = 0;
            if (p3d3e.IsChecked == true)
                c1[25] = 1;
            else
                c1[25] = 0;
            if (p3d3f.IsChecked == true)
                c1[26] = 1;
            else
                c1[26] = 0;
            if (p3d3g.IsChecked == true)
                c1[27] = 1;
            else
                c1[27] = 0;
            if (p3d3h.IsChecked == true)
                c1[28] = 1;
            else
                c1[28] = 0;
            if (p3d3i.IsChecked == true)
                c1[29] = 1;
            else
                c1[29] = 0;

            string[] pestana1 = {new TextRange(p3d1.Document.ContentStart, p3d1.Document.ContentEnd).Text, c1[0].ToString(), c1[1].ToString(), c1[2].ToString(), c1[3].ToString(), 
                                c1[4].ToString(), c1[5].ToString(), c1[6].ToString(), c1[7].ToString(),
        c1[8].ToString(), c1[9].ToString(), c1[10].ToString(), c1[11].ToString(), c1[12].ToString()
                                , c1[13].ToString(), c1[14].ToString()
                                , c1[15].ToString(), c1[16].ToString(), c1[17].ToString(), c1[18].ToString(), 
                                c1[19].ToString(), c1[20].ToString(), c1[21].ToString(), c1[22].ToString(),
        c1[23].ToString(), c1[24].ToString(), c1[25].ToString(), c1[26].ToString(), c1[27].ToString()
                                , c1[28].ToString(), c1[29].ToString()};
            foreach (var item in pestana1)
            {
                HN.Add(item);
            }
        }
        private void LlenaP4()
        {
            int[] c1 = new int[6];
            if (p4d1a.IsChecked == true)
                c1[0] = 1;
            else
                c1[0] = 0;
            if (p4d1b.IsChecked == true)
                c1[1] = 1;
            else
                c1[1] = 0;
            if (p4d1c.IsChecked == true)
                c1[2] = 1;
            else
                c1[2] = 0;
            if (p4d1d.IsChecked == true)
                c1[3] = 1;
            else
                c1[3] = 0;
            if (p4d1e.IsChecked == true)
                c1[4] = 1;
            else
                c1[4] = 0;
            if (p4d2.IsChecked == true)
                c1[5] = 1;
            else
                c1[5] = 0;
            string[] pestana1 = { c1[0].ToString(), c1[1].ToString(),  c1[2].ToString(), c1[3].ToString(),
                                c1[4].ToString(), c1[5].ToString(), p4d3.Text, p4d4.Text };
            foreach (var item in pestana1)
            {
                HN.Add(item);
            }
        }
        private void LlenaP5()
        {

            string[] pestana1 = { cmbApetito.Text, cmbDComer.Text, p5d1.Text, cmbACHora.Text,
                                cmbASComidas.Text, cmbACEComidas.Text, new TextRange(p5d2.Document.ContentStart, p5d2.Document.ContentEnd).Text, cmbHSMApetito.Text, new TextRange(p5d3.Document.ContentStart, p5d3.Document.ContentEnd).Text};
            foreach (var item in pestana1)
            {
                HN.Add(item);
            }
        }
        private void LlenaP6()
        {
            int[] c1 = new int[3];
            if (p6dc1.IsChecked == true)
                c1[0] = 1;
            else
                c1[0] = 0;
            if (p6dc2.IsChecked == true)
                c1[1] = 1;
            else
                c1[1] = 0;
            if (p6dc3.IsChecked == true)
                c1[2] = 1;
            else
                c1[2] = 0;
            string[] pestana1 = { new TextRange(p6d1.Document.ContentStart, p6d1.Document.ContentEnd).Text, new TextRange(p6d2.Document.ContentStart, p6d2.Document.ContentEnd).Text, new TextRange(p6d3.Document.ContentStart, p6d3.Document.ContentEnd).Text, p6d4.Text, c1[0].ToString(),
                                c1[1].ToString(), p6d5.Text, c1[2].ToString(), cmbPPCual.Text, p6d6.Text, p6d7.Text
                                , p6d8.Text, new TextRange(p6d9.Document.ContentStart, p6d9.Document.ContentEnd).Text, new TextRange(p6d10.Document.ContentStart, p6d10.Document.ContentEnd).Text, p6d11.Text, p6d12.Text};
            foreach (var item in pestana1)
            {
                HN.Add(item);
            }
        }
        private void LlenaP7()
        {
            int[] c1 = new int[14];
            if (p7d1.IsChecked == true)
                c1[0] = 1;
            else
                c1[0] = 0;
            if (p7d3a.IsChecked == true)
                c1[1] = 1;
            else
                c1[1] = 0;
            if (p7d3b.IsChecked == true)
                c1[2] = 1;
            else
                c1[2] = 0;
            if (p7d3c.IsChecked == true)
                c1[3] = 1;
            else
                c1[3] = 0;
            if (p7d3d.IsChecked == true)
                c1[4] = 1;
            else
                c1[4] = 0;
            if (p7d3e.IsChecked == true)
                c1[5] = 1;
            else
                c1[5] = 0;
            if (p7d3f.IsChecked == true)
                c1[6] = 1;
            else
                c1[6] = 0;
            if (p7d3g.IsChecked == true)
                c1[7] = 1;
            else
                c1[7] = 0;
            if (p7d3h.IsChecked == true)
                c1[8] = 1;
            else
                c1[8] = 0;
            if (p7d3i.IsChecked == true)
                c1[9] = 1;
            else
                c1[9] = 0;
            if (p7d6.IsChecked == true)
                c1[10] = 1;
            else
                c1[10] = 0;
            if (p7d7.IsChecked == true)
                c1[11] = 1;
            else
                c1[11] = 0;
            if (p7d8.IsChecked == true)
                c1[12] = 1;
            else
                c1[12] = 0;
            if (p7d10.IsChecked == true)
                c1[13] = 1;
            else
                c1[13] = 0;
            string[] pestana1 = { c1[0].ToString(), p7d2.Text, c1[1].ToString(), c1[2].ToString(), c1[3].ToString(), 
                                c1[4].ToString(),  c1[5].ToString(),  c1[6].ToString(),  c1[7].ToString(),  c1[8].ToString()
            ,  c1[9].ToString(), new TextRange(p7d4.Document.ContentStart, p7d4.Document.ContentEnd).Text, p7d5.Text,  c1[10].ToString(),  c1[11].ToString(),
             c1[12].ToString(), p7d9.Text,  c1[13].ToString(), new TextRange(p7d11.Document.ContentStart, p7d11.Document.ContentEnd).Text
                                };
            foreach (var item in pestana1)
            {
                HN.Add(item);
            }
        }
        private void LlenaP8()
        {

            string[] pestana1 = {p8d1.Text, p8d2.Text, p8d3.Text, p8d4.Text, p8d5.Text, p8d6.Text,
                                    p8d7.Text, p8d8.Text, p8d9.Text, p8d10.Text, p8d11.Text};
            foreach (var item in pestana1)
            {
                HN.Add(item);
            }
        }
        private bool VerificaP1()
        {
            if (p1d1.Text != "" && p1d2.Text != "" && p1d3.Text != "" && p1d4.Text != "" && p1d5.Text != "" && p1d6.Text != "" && cmbGenero.Text != "" && cmbEdoCivil.Text != "")
                return true;
            else
                return false;
        }
  
        #region Validaciones
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
        #endregion

        private void p4d2_Unchecked(object sender, RoutedEventArgs e)
        {
            p4d3.IsEnabled = false;
            p4d4.IsEnabled = false;
        }

       

    

    }
}
