using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace survey
{
    
    public partial class result : Form
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "new_schema";
        string _id = "root";
        string _pw = "";
        string _connectionAddress = "";
        public result()
        {
            
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};charset=utf8", _server, _port, _database, _id, _pw);

            listView1_load();

        }

        private void listView1_load()
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string selectQuery = string.Format("SELECT * FROM survey");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    listView1.Items.Clear();

                    while (table.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = table["id"].ToString();
                        item.SubItems.Add(table["name"].ToString());
                        item.SubItems.Add(table["sex"].ToString());
                        item.SubItems.Add(table["rockchic"].ToString());
                        item.SubItems.Add(table["minimal"].ToString());
                        item.SubItems.Add(table["cityboy"].ToString());
                        

                        listView1.Items.Add(item);
                    }

                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            start start = new start();
            start.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
