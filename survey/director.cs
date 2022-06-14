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

    public partial class director : Form
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "new_schema";
        string _id = "root";
        string _pw = "";
        string _connectionAddress = "";
        public director()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};charset=utf8", _server, _port, _database, _id, _pw);
            listView1_load();
            listview1.SelectedIndexChanged += Listview1_SelectedIndexChanged;
        }
        private void Listview1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView listview = sender as ListView;

            int index = listview.FocusedItem.Index;
            
            textBox1.Text = listview.Items[index].SubItems[1].Text;
            textBox2.Text = listview.Items[index].SubItems[2].Text;
            textBox3.Text = listview.Items[index].SubItems[3].Text;
            textBox4.Text = listview.Items[index].SubItems[4].Text;
            textBox5.Text = listview.Items[index].SubItems[5].Text;
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

                    listview1.Items.Clear();

                    while (table.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = table["id"].ToString();
                        item.SubItems.Add(table["name"].ToString());
                        item.SubItems.Add(table["sex"].ToString());
                        item.SubItems.Add(table["rockchic"].ToString());
                        item.SubItems.Add(table["minimal"].ToString());
                        item.SubItems.Add(table["cityboy"].ToString());



                        listview1.Items.Add(item);
                    }

                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

       

        

       

        private void reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void change_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    int pos = listview1.SelectedItems[0].Index;
                    int index = Convert.ToInt32(listview1.Items[pos].Text);
                    string updateQuery = string.Format("UPDATE survey SET name = '{1}', sex = '{2}', rockchic = '{3}', minimal = '{4}', cityboy = '{5}'  WHERE id={0};", index, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);

                    MySqlCommand command = new MySqlCommand(updateQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to delete data.");

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";

                }
            }
            catch { }
            listview1.Items.Clear();
            listView1_load();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    int pos = listview1.SelectedItems[0].Index;
                    int index = Convert.ToInt32(listview1.Items[pos].Text);
                    string deleteQuery = string.Format("DELETE FROM survey WHERE id={0};", index);

                    MySqlCommand command = new MySqlCommand(deleteQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to delete data.");

                    listview1.Items.Clear();
                    listView1_load();

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";

                }
            }
            catch { }
        }

        private void director_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string selectQuery = string.Format("SELECT * FROM survey");

                    MySqlCommand command = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table = command.ExecuteReader();

                    listview1.Items.Clear();

                    while (table.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = table["id"].ToString();
                        item.SubItems.Add(table["name"].ToString());
                        item.SubItems.Add(table["sex"].ToString());
                        item.SubItems.Add(table["rockchic"].ToString());
                        item.SubItems.Add(table["minimal"].ToString());
                        item.SubItems.Add(table["cityboy"].ToString());



                        listview1.Items.Add(item);
                    }

                    table.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
