using System;

namespace MySQL
{
    public class woman
    {
        /*NN*/
        public int id { get; set; }
        public int id_patient { get; set; }
        /*NN*/
        public int first_day { get; set; }
        /*NN*/
        public string last_day { get; set; }
        /*NN*/
        public int duration { get; set; }
        public string contraceptive { get; set; }
        public string pregnancy { get; set; }// numero de embarazos::numero de meses
        public char suckle { get; set; } //lactando Y/N
        public char menopause { get; set; } // Y/N

    }
}