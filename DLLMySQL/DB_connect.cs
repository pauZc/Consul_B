using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;

namespace MySQL
{
    public class DB_connect
    {
        public DB_connect()
        {

        }
       static MySqlConnection   conn = new MySqlConnection();
        
        public bool ConnectDB()
        {
            try
            {
                conn.ConnectionString = "server=localhost;userid=root;password=;database=pacientes";
                conn.Open();
                conn.Close();
                return true;
                
            }
            catch (MySqlException)
            {
                conn.Dispose();
                return false;
            }

        }
        public bool Insert_Patient(patient paciente)
        {
            try
            {
               
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                //comm.CommandText = "INSERT INTO room(person,address) VALUES(@person, @address)";
                comm.CommandText = "INSERT INTO patient " +
                    "(name,register_day,gender,civil_status,ocupation,phone,mail,past_family,past_personal,surgery," +
                    "medicine,current_suffering,daily_activity,sport,apetite,snack,prefer_food,wrong_food,diet,drink," +
                    "tracing_weight,frequency_weight,start_pweight,max_weight,min_weight,alcohol,alcohol_details,smoke,drugs,allergy," +
                    "diagnostic,patientcol)" +
                    "value (@name,@register_day,@gender,@civil_status,@ocupation,@phone,@mail,@past_family,@past_personal,@surgery," +
                    "@medicine,@current_suffering,@daily_activity,@sport,@apetite,@snack,@prefer_food,@wrong_food,@diet,@drink," +
                    "@tracing_weight,@frequency_weight,@start_pweight,@max_weight,@min_weight,@alcohol,@alcohol_details,@smoke,@drugs,@allergy," +
                    "@diagnostic,@patientcol)";
                comm.Parameters.AddWithValue("@name", paciente.name);
                comm.Parameters.AddWithValue("@register_day", paciente.register_day);
                comm.Parameters.AddWithValue("@gender", paciente.gender);
                comm.Parameters.AddWithValue("@civil_status", paciente.civil_status);
                comm.Parameters.AddWithValue("@ocupation", paciente.ocupation);
                comm.Parameters.AddWithValue("@phone", paciente.phone);
                comm.Parameters.AddWithValue("@mail", paciente.mail);
                comm.Parameters.AddWithValue("@past_family", paciente.past_family);
                comm.Parameters.AddWithValue("@past_personal", paciente.past_personal);
                comm.Parameters.AddWithValue("@surgery", paciente.surgery);
                comm.Parameters.AddWithValue("@medicine", paciente.medicine);
                comm.Parameters.AddWithValue("@current_suffering", paciente.current_suffering);
                comm.Parameters.AddWithValue("@daily_activity", paciente.daily_activity);
                comm.Parameters.AddWithValue("@sport", paciente.sport);
                comm.Parameters.AddWithValue("@apetite", paciente.apetite);
                comm.Parameters.AddWithValue("@snack", paciente.snack);
                comm.Parameters.AddWithValue("@prefer_food", paciente.prefer_food);
                comm.Parameters.AddWithValue("@wrong_food", paciente.wrong_food);
                comm.Parameters.AddWithValue("@diet", paciente.diet);
                comm.Parameters.AddWithValue("@drink", paciente.drink);
                comm.Parameters.AddWithValue("@tracing_weight", paciente.tracing_weight);
                comm.Parameters.AddWithValue("@frequency_weight", paciente.frequency_weight);
                comm.Parameters.AddWithValue("@start_pweight", paciente.start_pweight);
                comm.Parameters.AddWithValue("@max_weight", paciente.max_weight);
                comm.Parameters.AddWithValue("@min_weight", paciente.min_weight);
                comm.Parameters.AddWithValue("@alcohol", paciente.alcohol);
                comm.Parameters.AddWithValue("@alcohol_details", paciente.alcohol_details);
                comm.Parameters.AddWithValue("@smoke", paciente.smoke);
                comm.Parameters.AddWithValue("@drugs", paciente.drugs);
                comm.Parameters.AddWithValue("@allergy", paciente.allergy);
                comm.Parameters.AddWithValue("@diagnostic", paciente.diagnostic);
                comm.Parameters.AddWithValue("@patientcol", paciente.patientcol);
                comm.ExecuteNonQuery();
                conn.Close();
                return true;
                //sintaxis
            }
            catch (MySqlException ex)
            {
                conn.Dispose();
                return false;
            }
        }

        public bool Insert_Woman(woman woman)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "INSERT INTO woman " +
                    "(id_patient,first_day,last_day,duration,contraceptive, pregnancy,suckle,menopause)" +
                    "value (@id_patient,@first_day,@last_day,@duration,@contraceptive,@pregnancy,@suckle,@menopause)";
                comm.Parameters.AddWithValue("@id_patient", woman.id_patient);
                comm.Parameters.AddWithValue("@first_day", woman.first_day);
                comm.Parameters.AddWithValue("@last_day", woman.last_day);
                comm.Parameters.AddWithValue("@duration", woman.duration);
                comm.Parameters.AddWithValue("@contraceptive", woman.contraceptive);
                comm.Parameters.AddWithValue("@pregnancy", woman.pregnancy);
                comm.Parameters.AddWithValue("@suckle", woman.suckle);
                comm.Parameters.AddWithValue("@menopause", woman.menopause);
                comm.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                conn.Dispose();
                return false;
            }
        }

        public bool Insert_Date(date date)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "INSERT INTO date " +
                    "(id_patient,datep,fat,skinny,weight,coment,medication)" +
                    "value (@id_patient,@datep,@fat,@skinny,@weight,@coment,@medication)";
                comm.Parameters.AddWithValue("@id_patient", date.id_patient);
                comm.Parameters.AddWithValue("@datep", date.datep);
                comm.Parameters.AddWithValue("@fat", date.fat);
                comm.Parameters.AddWithValue("@skinny", date.skinny);
                comm.Parameters.AddWithValue("@weight", date.weight);
                comm.Parameters.AddWithValue("@coment", date.coment);
                comm.Parameters.AddWithValue("@medication", date.medication);
                comm.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (MySqlException)
            {
                conn.Dispose();
                return false;
            }
        }
        public bool Update_Woman(woman woman)
        {
            try
            {
                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "UPDATE woman SET first_day=@first_day, last_day=@last_day, duration=@duration, contraceptive=@contraceptive,"+
                    "pregnancy=@pregnancy, suckle=@suckle, menopause=@menopause WHERE id="+woman.id;
                comm.Parameters.AddWithValue("@first_day", woman.first_day);
                comm.Parameters.AddWithValue("@last_day", woman.last_day);
                comm.Parameters.AddWithValue("@duration", woman.duration);
                comm.Parameters.AddWithValue("@contraceptive", woman.contraceptive);
                comm.Parameters.AddWithValue("@pregnancy", woman.pregnancy);
                comm.Parameters.AddWithValue("@suckle", woman.suckle);
                comm.Parameters.AddWithValue("@menopause", woman.menopause);
                int numRowsUpdated = comm.ExecuteNonQuery();

                conn.Close();
                if (numRowsUpdated != 0)
                    return true;
                else
                    return false;
            }
            catch (MySqlException ex)
            {
                conn.Dispose();
                return false;
            }
        }
        public bool Update_Patient(patient paciente)
        {
            try
            {

                conn.Open();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "UPDATE patient SET civil_status=@civil_status,ocupation=@ocupation,phone=@phone,mail=@mail,past_family=@past_family,"+
                    "past_personal=@past_personal,surgery=@surgery,medicine=@medicine,current_suffering=@current_suffering,daily_activity=@daily_activity,"+
                    "sport=@sport,apetite=@apetite,snack=@snack,prefer_food=@prefer_food,wrong_food=@wrong_food,diet=@diet,drink=@drink," +
                    "tracing_weight=@tracing_weight,frequency_weight=@frequency_weight,start_pweight=@start_pweight,max_weight=@max_weight,"+
                    "min_weight=@min_weight,alcohol=@alcohol,alcohol_details=@alcohol_details,smoke=@smoke,drugs=@drugs,allergy=@allergy," +
                    "diagnostic=@diagnostic,patientcol=@patientcol WHERE id="+paciente.id;
                comm.Parameters.AddWithValue("@civil_status", paciente.civil_status);
                comm.Parameters.AddWithValue("@ocupation", paciente.ocupation);
                comm.Parameters.AddWithValue("@phone", paciente.phone);
                comm.Parameters.AddWithValue("@mail", paciente.mail);
                comm.Parameters.AddWithValue("@past_family", paciente.past_family);
                comm.Parameters.AddWithValue("@past_personal", paciente.past_personal);
                comm.Parameters.AddWithValue("@surgery", paciente.surgery);
                comm.Parameters.AddWithValue("@medicine", paciente.medicine);
                comm.Parameters.AddWithValue("@current_suffering", paciente.current_suffering);
                comm.Parameters.AddWithValue("@daily_activity", paciente.daily_activity);
                comm.Parameters.AddWithValue("@sport", paciente.sport);
                comm.Parameters.AddWithValue("@apetite", paciente.apetite);
                comm.Parameters.AddWithValue("@snack", paciente.snack);
                comm.Parameters.AddWithValue("@prefer_food", paciente.prefer_food);
                comm.Parameters.AddWithValue("@wrong_food", paciente.wrong_food);
                comm.Parameters.AddWithValue("@diet", paciente.diet);
                comm.Parameters.AddWithValue("@drink", paciente.drink);
                comm.Parameters.AddWithValue("@tracing_weight", paciente.tracing_weight);
                comm.Parameters.AddWithValue("@frequency_weight", paciente.frequency_weight);
                comm.Parameters.AddWithValue("@start_pweight", paciente.start_pweight);
                comm.Parameters.AddWithValue("@max_weight", paciente.max_weight);
                comm.Parameters.AddWithValue("@min_weight", paciente.min_weight);
                comm.Parameters.AddWithValue("@alcohol", paciente.alcohol);
                comm.Parameters.AddWithValue("@alcohol_details", paciente.alcohol_details);
                comm.Parameters.AddWithValue("@smoke", paciente.smoke);
                comm.Parameters.AddWithValue("@drugs", paciente.drugs);
                comm.Parameters.AddWithValue("@allergy", paciente.allergy);
                comm.Parameters.AddWithValue("@diagnostic", paciente.diagnostic);
                comm.Parameters.AddWithValue("@patientcol", paciente.patientcol);
                int numRowsUpdated =comm.ExecuteNonQuery();

                conn.Close();
                if (numRowsUpdated != 0)
                    return true;
                else
                    return false;
                //sintaxis
            }
            catch (MySqlException ex)
            {
                conn.Dispose();
                return false;
            }
        }
        public List<date> Select_PatientDates(int id_patient)
        {
            List<date> lista = new List<date>();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM date WHERE id_patient=" + id_patient;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                     lista.Add(
                         new date
                         {
                             id = int.Parse(reader.GetValue(0).ToString()),
                             id_patient = int.Parse(reader.GetValue(1).ToString()),
                             datep=DateTime.Parse(reader.GetValue(2).ToString()),
                             fat=double.Parse(reader.GetValue(3).ToString()),
                             skinny= double.Parse(reader.GetValue(4).ToString()),
                             weight = double.Parse(reader.GetValue(5).ToString()),
                             coment = reader.GetString(6).ToString()

                         });
                }
                reader.Close();
                conn.Close();
                return lista;
            }
            catch (MySqlException)
            {
                conn.Dispose();
                return lista;
            }

        }
        public patient Select_PatientData(int id_patient)
        {
            patient lista = new patient();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM patient WHERE id="+id_patient;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                       lista= new patient
                        {
                            id = int.Parse(reader.GetValue(0).ToString()),
                            name = reader.GetValue(1).ToString(),
                            register_day = DateTime.Parse(reader.GetValue(2).ToString()),
                            gender = char.Parse(reader.GetValue(3).ToString()),
                            civil_status= char.Parse( reader.GetValue(4).ToString()),
                            ocupation= reader.GetValue(5).ToString(),
                            phone = reader.GetValue(6).ToString(),
                            mail = reader.GetValue(7).ToString(),
                            past_family = reader.GetValue(8).ToString(),
                            past_personal = reader.GetValue(9).ToString(),
                            surgery= reader.GetValue(10).ToString(),
                            medicine = reader.GetValue(11).ToString(),
                            current_suffering= reader.GetValue(12).ToString(),
                            daily_activity= char.Parse( reader.GetValue(13).ToString()),
                            sport= reader.GetValue(14).ToString(),
                            apetite= reader.GetValue(15).ToString(),
                            snack= reader.GetValue(16).ToString(),
                            prefer_food= reader.GetValue(17).ToString(),
                            wrong_food= reader.GetValue(18).ToString(),
                            diet= reader.GetValue(19).ToString(),
                            drink= reader.GetValue(20).ToString(),
                            tracing_weight= reader.GetValue(21).ToString(),
                            frequency_weight= reader.GetValue(22).ToString(),
                            start_pweight= reader.GetValue(23).ToString(),
                            max_weight= reader.GetValue(24).ToString(),
                            min_weight= reader.GetValue(25).ToString(),
                            alcohol= reader.GetValue(26).ToString(),
                            alcohol_details= reader.GetValue(27).ToString(),
                            smoke= reader.GetValue(28).ToString(),
                            drugs= reader.GetValue(29).ToString(),
                            allergy= reader.GetValue(30).ToString(),
                            diagnostic= reader.GetValue(31).ToString(),
                            patientcol= reader.GetValue(32).ToString(),
                            age=int.Parse(reader.GetValue(33).ToString())
                        };
                }
                reader.Close();
                conn.Close();
                return lista;
            }
            catch (MySqlException)
            {
                conn.Dispose();
                return lista;
            }

        }
        public List<patient> Select_Patients()
        {
            List<patient> lista = new List<patient>();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT id, name, register_day, gender, phone, mail FROM patient";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(
                        new patient
                        {
                            id = int.Parse(reader.GetValue(0).ToString()),
                            name = reader.GetValue(1).ToString(),
                            register_day = DateTime.Parse(reader.GetValue(2).ToString()),
                            gender = char.Parse(reader.GetValue(3).ToString()),
                            phone = reader.GetValue(4).ToString(),
                            mail = reader.GetValue(5).ToString(),
                        });
                }
                reader.Close();
                conn.Close();
                return lista;
            }
            catch (MySqlException)
            {
                conn.Dispose();
                return lista;
            }

        }
        public woman Select_Woman(int id_patient)
        {
            woman mujer = new woman();
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM woman WHERE id_patient=" + id_patient;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    mujer = new woman
                    {
                        id = int.Parse(reader.GetValue(0).ToString()),
                        id_patient = int.Parse(reader.GetValue(1).ToString()),
                        first_day = int.Parse(reader.GetValue(2).ToString()),
                        last_day = reader.GetValue(3).ToString(),
                        duration = int.Parse(reader.GetValue(4).ToString()),
                        contraceptive = reader.GetValue(5).ToString(),
                        pregnancy = reader.GetValue(6).ToString(),
                        suckle = char.Parse(reader.GetValue(7).ToString()),
                        menopause = char.Parse(reader.GetValue(8).ToString())
                    };
                }
                reader.Close();
                conn.Close();
                return mujer;
            }
            catch (MySqlException)
            {
                conn.Dispose();
                return null;
            }

        }
        public patientData Select_Patient(int id_patient)
        {
            patientData pd = new patientData();
            try
            {

                pd.paciente = Select_PatientData(id_patient);
                if (pd.paciente.gender=='M')
                {
                    pd.mujer= Select_Woman(pd.paciente.id);
                }else
                {
                    pd.mujer = null;
                }
                return pd;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public int Select_LastPatientId()
        {
            try
            {
                int id = 0;
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT id FROM patient ORDER BY id DESC LIMIT 1";
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = int.Parse(reader.GetValue(0).ToString());
                 }
                reader.Close();
                conn.Close();
                return id;
            }
            catch (MySqlException ex)
            {
                conn.Dispose();
                return 0;
            }
        }
    }
}
