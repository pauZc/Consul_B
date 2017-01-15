using System;

namespace WcfService
{
    public class woman
    {
        public int id { get; set; }
        public int id_patient { get; set; }
        public int first_day { get; set; }
        public DateTime last_day { get; set; }
        public int duration { get; set; }
        public string contraceptive { get; set; }
        public char pregnancy { get; set; }// numero de embarazos::numero de meses
        public char abortion { get; set; }// Y/N::cuantos
        public char suckle { get; set; } //lactando Y/N
        public char menopause { get; set; } // Y/N

    }
}