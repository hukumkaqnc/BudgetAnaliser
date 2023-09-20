using MySql.Data.MySqlClient;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetApp
{
    internal class DB
    {
        MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection("server=localhost;port=3306;username=root;password=root;database=spendings");
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open(); 
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public MySqlConnector.MySqlConnection getConnection()
        {
            return connection;  
        }
        //тест коммит
        //vetochka
        //new change
    }
}
