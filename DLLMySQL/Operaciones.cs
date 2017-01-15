using System;

namespace MySQL
{
    public class Operaciones
    {
        public static int CalcularEdad(DateTime bday)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - bday.Year;
            if (bday > today.AddYears(-age)) age--;
            return age;
        }
    }
}
