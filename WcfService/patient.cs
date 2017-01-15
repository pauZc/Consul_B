using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService
{
    public class patient
    {
        public int id { get; set; }
        public int name { get; set; }//nombre::apellido
        public DateTime birthdate { get; set; }
        public char gender { get; set; } //W => mujer   M=> hombre
        public char civil_status { get; set; }// S=> soltero    M=>casado   W=>viudo    D=>divoriciado
        public string ocupation { get; set; }
        public string phone { get; set; }
        public string mail { get; set; }
        public string past_family { get; set; }//Y/N::Y/N...
        public string past_personal { get; set; }
        public string surgery { get; set; }
        public string medicine { get; set; }
        public char current_suffering { get; set; }//Y/N::Y/N...
        public char daily_activity { get; set; }
        //X => muy ligera L=>ligera
        //M => moderada
        //P=>pesada
        //E => exhaustiva
        public string sport { get; set; }//deporte::frecuencia
        public string apetite { get; set; }//[G/M/P]::[Y/N]::[nD]::[Y/N/S]::[Y/N]::[Y/N]::[HR]
                                           //nD=>días
                                           /*
                                               G => bueno
                                               M => moderado
                                               P => pobre
                                            */
        public string snack { get; set; }
        public string prefer_food { get; set; }
        public string wrong_food { get; set; }
        public string diet { get; set; }
        public char drink { get; set; }//[litros]:[S/A/C]
                                       /*
                                        * S=>agrega azúcar
                                        * A=>sustitutos de azúcar
                                        * C=>crema o leche en bebidas
                                        */
        public string tracing_weight { get; set; }//[Y/N]::[Y/N]::[L/O/F/V]
                                                  /*
                                                   * L=>bajo peso
                                                   * O=>sobre peso
                                                   * F=>obesidad
                                                   * V=>Inestabilidad 
                                                   */
        public string frequency_weight { get; set; }
        public string start_pweight { get; set; }
        public string max_weight { get; set; }//[peso max]::[cuando]
        public string min_weight { get; set; }//[peso min]::[cuando]
        public string alcohol { get; set; }//[Y/N]:: [nrb]::[cantidad]::[Y/N]::[Y/N]
        public string alcohol_details { get; set; }//[cuando]::[bebidas de preferencia]
        public string smoke { get; set; }//[Y/N]::[n]
        public string drugs { get; set; }//[Y/N]::[n
        public string allergy { get; set; }//[Y/N]::[cual]
        public string diagnostic { get; set; }
    }
}