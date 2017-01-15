namespace ClassLibrary
{
    public class Directory
    {
        static string url="";

        public void Set_Url(string url_userasigned)
        {

        }
        public void New_Pacient(string name)
        {
            //Crea un folder con el nombre del paciente
            string folderName = @"" + url + "";//D:\programaB\pacientes
            string pathString = System.IO.Path.Combine(folderName, name);
            System.IO.Directory.CreateDirectory(pathString);
        }
    }
}
