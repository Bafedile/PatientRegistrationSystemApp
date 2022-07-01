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
        string name= "root", password = "Amogelang#5%",
            database="patient_info",server="local",connString;
        MySqlConnection conn;

        public DatabaseConnection()
        {
            try
            {
                connString = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + name + ";PASSWORD=" + password + ";";
                conn = new MySqlConnection(connString);
                conn.Open();

            }
            catch(Exception e)
            {

            }
        }
    }
}
