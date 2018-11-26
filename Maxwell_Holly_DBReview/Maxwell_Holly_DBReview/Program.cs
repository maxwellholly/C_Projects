using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data;

namespace DBSReview
{
    class Program
    {
        MySqlConnection _conn = null;

        static void Main(string[] args)
        {
            Program instance = new Program();

            Console.Write("Please enter a city to display data for: ");
            string input = Console.ReadLine();

            instance._conn = new MySqlConnection();
            instance.Connect();

            DataTable data = instance.QueryDB($"SELECT temp, pressure, humidity, id FROM weather WHERE id = (SELECT MAX(id) FROM weather WHERE city = '{input}')");
            DataRowCollection rows = data.Rows;

            if (data.Rows.Count != 0)
            {
                foreach (DataRow row in rows)
                {
                    string temp = Convert.ToString(row["temp"]);
                    string pressure = Convert.ToString(row["pressure"]);
                    string humidity = Convert.ToString(row["humidity"]);

                    Console.WriteLine($"----- {input} Weather Data -----");
                    Console.WriteLine($"Tempurature: {temp}");
                    Console.WriteLine($"Pressure: {pressure}");
                    Console.WriteLine($"Humidity: {humidity}");
                }

            }
            else
            {
                Console.WriteLine("No Data Available for the selected city");
            }

            Console.ReadKey();
        }

        void Connect()
        {
            BuildConnString();

            try
            {
                _conn.Open();
            }
            catch (MySqlException e)
            {
                string msg = "";

                switch (e.Number)
                {
                    case 0:
                        {
                            msg = e.ToString();
                            break;
                        }
                    case 1042:
                        {
                            msg = "Can't resolve host address.\n" + _conn.ConnectionString;
                            break;
                        }
                    case 1045:
                        {
                            msg = "Invalid username/password";
                            break;
                        }
                    default:
                        {
                            msg = e.ToString();
                            break;
                        }
                }

                Console.WriteLine(msg);
            }
        }

        void BuildConnString()
        {
            string ip = "";

            using (StreamReader sr = new StreamReader("c:/VFW/connect.txt"))
            {
                ip = sr.ReadLine();
            }

            string conString = $"server={ip};";
            conString += "userid=dbAdmin;";
            conString += "password=password;";
            conString += "database=sampleAPIData;";
            conString += "port=8889";

            _conn.ConnectionString = conString;
        }

        DataTable QueryDB(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, _conn);
            DataTable data = new DataTable();

            adapter.SelectCommand.CommandType = CommandType.Text;
            adapter.Fill(data);

            return data;
        }
    }
}
