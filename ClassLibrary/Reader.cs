using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Reader
    {
        public static string[] BuscarLogin()
        {

            StreamReader Lector = default(StreamReader);
            int renglon = 0;
            string informacion = null;
            string[] login = new string[2];

            Lector = new StreamReader(@"D:\programaB\fc7d332178c40afcb292f59403e1113fa2d7f3b0.txt");



            while (renglon < 2)
            {
                informacion = Lector.ReadLine();
                login[renglon] = informacion;
                renglon++;
            }

            Lector.Close();
            return login;
        }
        public static List<Paciente> BuscarPacientes()
        {
            StreamReader Lector = default(StreamReader);
            var pacientes = new List<Paciente>();
            Lector = new StreamReader(@"D:\programaB\pacientes\List.txt");
            while (!Lector.EndOfStream)
            {
                string str = Lector.ReadLine();
                string[] strArr = null;
                char[] splitchar = { ':' };
                strArr = str.Split(splitchar);
                var paciente = new Paciente()
                {
                    nombre = strArr[0],
                    correo = strArr[2],
                    birthday = strArr[1],
                    telefono = strArr[3]
                };
                pacientes.Add(paciente);

            }
            Lector.Close();
            return pacientes;
        }
      
        public static List<cita> ExtraerCitas(string name)
        {
            StreamReader Lector = default(StreamReader);
            var citas = new List<Cita>();
            Lector = new StreamReader("D:\\programaB\\pacientes\\" + name + "\\Citas.txt");
            while (!Lector.EndOfStream)
            {
                string str = Lector.ReadLine();
                string[] strArr = null;
                char[] splitchar = { ':' };
                strArr = str.Split(splitchar);
                var cita = new Cita()
                {
                    fecha = strArr[0],
                    grasa = double.Parse(strArr[1]),
                    magra = double.Parse(strArr[2]),
                    peso = double.Parse(strArr[3]),
                    comentario = strArr[4]
                };
                citas.Add(cita);
            }
            Lector.Close();
            return citas;
        }
        public static List<string> HN(string name)
        {
            StreamReader Lector = default(StreamReader);
            var citas = new List<string>();
            Lector = new StreamReader("D:\\programaB\\pacientes\\" + name + "\\HN.txt");
            int n = 0;
            string str;
            while (n<139)
            {
                str = Lector.ReadLine();
                citas.Add(str);
                n++;
            }
            Lector.Close();
            return citas;
        }
    }
}
