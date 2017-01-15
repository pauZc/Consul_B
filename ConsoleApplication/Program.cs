using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            MySQL.DB_connect db = new MySQL.DB_connect();
            if (db.ConnectDB())
            {
                foreach (var item in db.Select_Patients())
                {
                    //id, name,birthdate,gender,phone,mail
                    Console.WriteLine(item.id + "   " + item.name + "   " + item.register_day + "   "
                        + item.gender + "   " + item.phone + "   " + item.mail);
                }
            }
            else
            {
                Console.WriteLine("No se conecta");
            }
            Console.ReadLine();
        }
    }
}
