using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Writer
    {
        public static bool WriteDate(string filename, double grasa, double magra, double peso, string comentario)
        {
            #region CON ARCHIVOS
            StreamWriter Escritura;
            string filerute = "D:\\programaB\\pacientes\\" + filename + "\\Citas.txt";
            try
            {
                if (!File.Exists(filerute))
                {
                    crearArchivo(filerute);
                }
                Escritura = new StreamWriter(filerute, true);
                Escritura.WriteLine(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year + ":" + grasa+ ":" + magra + ":" + peso + ":" + comentario);
                Escritura.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
#endregion

        }

        public static bool WriteHN(List<string> datos, string paciente)
        {
            StreamWriter Escritura;
            string filerute = "D:\\programaB\\pacientes\\" + paciente.ToString() + "\\HN.txt";
            try
            {
                if (!File.Exists(filerute))
                {
                    crearArchivo(filerute);
                }
                Escritura = new StreamWriter(filerute, true);
                foreach (var item in datos)
                {
                    Escritura.WriteLine(item);
                }
                
                Escritura.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool AlmacenarLista(Paciente paciente )
        {
            StreamWriter Escritura;
            string filerute = "D:\\programaB\\pacientes\\List.txt";
            try
            {
                if (!File.Exists(filerute))
                {
                    crearArchivo(filerute);
                }
                Escritura = new StreamWriter(filerute, true);
                 Escritura.WriteLine(paciente.nombre+":"+paciente.birthday.Substring(1,10)+":"+paciente.correo+":"+paciente.telefono);
                

                Escritura.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static void crearArchivo(string rute)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(rute, true);
            file.Close();

        }
    }
}
