using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void logbuttom_Click(object sender, EventArgs e)
        {
            string Logiiiiin = loginfield.Text;
            string password = passfield.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();


            MySqlCommand command = new MySqlCommand("SELECT * FROM `costs` WHERE 'login' = @ul AND 'password' = @up", db.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarChar).Value = loogin;
            command.Parameters.Add("@up", MySqlDbType.VarChar).Value=password;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Yes");
            }
            else
            {
                MessageBox.Show("No");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
