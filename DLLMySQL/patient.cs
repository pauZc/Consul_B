using System;

namespace MySQL
{
    public class patient
    {
        //NN 0
        public int id { get; set; }
        //NN 1
        public string name { get; set; }//nombre::apellido
        public int age { get; set; }
        //NN 2
        public DateTime register_day { get; set; }
        //NN 3
        public char gender { get; set; } //M => mujer   H=> hombre
        //NN 4
        public char civil_status { get; set; }
        // s=> soltero    c=>casado   v=>viudo    d=>divoriciado
        //NN 5
        public string ocupation { get; set; }
        //NN 6
        public string phone { get; set; }
        //NN 7
        public string mail { get; set; }
        //8
        public string past_family { get; set; }//binario ||
        //9
        public string past_personal { get; set; }
        //10
        public string surgery { get; set; }
        //11
        public string medicine { get; set; }
        //12
        public string current_suffering { get; set; }//Y/N::Y/N...
        /*NN*///13
        public char daily_activity { get; set; }
        //X => muy ligera L=>ligera
        //M => moderada
        //P=>pesada
        //E => exhaustiva
        /*NN*///14
        public string sport { get; set; }//deporte::frecuencia
        //15
        public string apetite { get; set; }
        //[B/M/P]::[S/N]::[nD]::[S/N/A]::[S/N]::[S/N]::[HR]
        //nD=>días
        /*
            B => bueno
            M => moderado
            P => pobre
         */
        /*
          S => si
          N => no
          A => Algunas veces
       */
        //cmbapetito||cmbdcomer||p5d1||cmbachora||cmbascomidas||cmbacecomidas||cmbgsmapetito
        //16
        public string snack { get; set; }//p5d2
        //17
        public string prefer_food { get; set; }//p5d4
        //18
        public string wrong_food { get; set; }//p5d3
        //19
        public string diet { get; set; }
        //20
        public string drink { get; set; }//[litros]:[S/N]
                                         /*
                                          * a=>agrega azúcar
                                          * s=>sustitutos de azúcar
                                          * c=>crema o leche en bebidas
                                          */
        //21
        public string tracing_weight { get; set; }//[S/N]::[S/N]::[b/s/o/i]
                                                  /*
                                                   * b=>bajo peso
                                                   * s=>sobre peso
                                                   * o=>obesidad
                                                   * i=>Inestabilidad 
                                                   */
                                                  //p6dc2||p6dc3||cmbPPCual
        //22
        public string frequency_weight { get; set; }//p6d5||p6d11||p6d12
        //23
        public string start_pweight { get; set; }//p6d6
        //24
        public string max_weight { get; set; }//[peso max]::[cuando]  p6d7||p6d9
        //25
        public string min_weight { get; set; }//[peso min]::[cuando]  p6d8||p6d10
        //26
        public string alcohol { get; set; }//[S/N]:: [nrb]::[cantidad]::[Y/N]::[Y/N]
        //27                                   //p7d1   ||p7d3a||p7d5||p7d6||p7d7
        public string alcohol_details { get; set; }//[cuando]::[bebidas de preferencia]
        //28                                            //p7d2  ||p7d4
        public string smoke { get; set; }//[Y/N]::[n]  p7d8||p7d9
        //29
        public string drugs { get; set; }//[Y/N]::[n]   p7d10||p7d11
        //30
        public string allergy { get; set; }//p2d4
        //31
        public string diagnostic { get; set; }//p8d1--11
        //32
        public string patientcol { get; set; }
    }
}