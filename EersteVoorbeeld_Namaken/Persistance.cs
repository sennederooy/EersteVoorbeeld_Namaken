using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EersteVoorbeeld_Namaken
{
    class Persistance
    {
        //veld
        string _connectionString = "server = localhost; user id = root; password = 1234; database = rapport";

        //constructor
        public Persistance()
        {
            _connectionString = "server = localhost; user id = root; password = 1234; database = rapport";
        }
        public Persistance(string connectionString)
        {
            _connectionString = connectionString;
        }

        //methode
        public List<Evaluatie> getEvaluatiesFromDB()
        {
            List<Evaluatie> EvaluatieLijst = new List<Evaluatie>();
            MySqlConnection conn = new MySqlConnection(_connectionString);
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM rapport.evaluatie", conn);

            conn.Open();
            MySqlDataReader dataReader = cmd.ExecuteReader();

            Console.WriteLine("De resultaten: ");
            List<Evaluatie> lijst = new List<Evaluatie>();
            while (dataReader.Read())
            {
                //verwerking records
                Evaluatie eval = new Evaluatie(Convert.ToInt16(dataReader[0]), Convert.ToString(dataReader[1]), Convert.ToDateTime(dataReader[2]), Convert.ToDouble(dataReader[3]), Convert.ToDouble(dataReader[4]));
                EvaluatieLijst.Add(eval);

            }

            conn.Close();
            return EvaluatieLijst;
        }
    }
    }

