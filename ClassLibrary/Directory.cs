using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Directory
    {
        public static void NuevoFolder(string name)
        {
            //Crea un folder con el nombre del paciente
            string folderName = @"D:\programaB\pacientes";
            string pathString = System.IO.Path.Combine(folderName, name);
            System.IO.Directory.CreateDirectory(pathString);
        }
    }
}
