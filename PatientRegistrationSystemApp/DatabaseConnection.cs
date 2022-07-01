using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PatientRegistrationSystemApp
{
     class DatabaseConnection
    {
        public string errorMessage;
        string name= "bafedile", password = "Amogelang#5%",
            database="patient",server="localhost",connString;
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        public System.Windows.Forms.Label ErrorLabel;
        public DatabaseConnection()
        {
            try
            {
                connString = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + name + ";PASSWORD=" + password + ";";
                conn = new MySqlConnection(connString);
                
                conn.Open();
              //  ErrorLabel.Text = "Database is Connected";

            }
            catch(MySqlException e)
            {
                // ErrorLabel.Text = e.Message;
                Console.WriteLine("The Database Error"+ e.Message);

            }
        }

        public void addPatientToDatabase(string query) 
        {
            try
            {
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch(MySqlException e)
            {
                errorMessage = e.Message;
                //ErrorLabel.Text = "An error occured when adding a patient";
            }
            
        }
    }
}
