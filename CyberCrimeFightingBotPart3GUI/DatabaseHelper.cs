using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CyberCrimeFightingBotPart2GUI
{
    public class DatabaseHelper
    {
        // a connection string that connects to the database
        private string connectionString =
            "server=localhost;database=cyberbotdb;uid=root;pwd=Tumenkie97%;";

        public void AddTask(TaskItem task)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                //conn.Open() is used to establish a connection to the MySQL database using the provided connection string. This is necessary before executing any SQL commands against the database.
                conn.Open();

                string query =
                    @"INSERT INTO Tasks
                    (Title, Description, ReminderDate, Status)
                    VALUES
                    (@title,@desc,@date,@status)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                //These parameters are used to prevent SQL injection attacks and ensure that the data is properly formatted for the database.
                //Parameter attacks are a common security vulnerability in database applications, where an attacker can manipulate the SQL query by injecting malicious input.
                cmd.Parameters.AddWithValue("@title", task.Title);
                cmd.Parameters.AddWithValue("@desc", task.Description);
                cmd.Parameters.AddWithValue("@date", task.ReminderDate);
                cmd.Parameters.AddWithValue("@status", task.Status);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetTasks ()
        {
            DataTable table = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Tasks";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(table);
            }

            return table;
        }

        public void CompleteTask(int taskId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Tasks SET Status = 'Completed' WHERE TaskID = @taskId";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@taskId", taskId);

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteTask(int taskID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                string query = "DELETE FROM Tasks WHERE TaskID = @taskId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@taskId", taskID);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
