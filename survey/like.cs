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
 
    public partial class like : Form
    {
        state st;
        string _server = "localhost";
        int _port = 3306;
        string _database = "new_schema";
        string _id = "root";
        string _pw = "";
        string _connectionAddress = "";
        public like(state st)
        {
            this.st = st;
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4};charset=utf8", _server, _port, _database, _id, _pw);

            if (this.st.name != null)
                label2.Text = this.st.name;
            if (this.st.man == true)
                label3.Text = "남";
            if (this.st.woman == true)
                label3.Text = "여";

            //rockchic
            if (this.st.mohair == true)
                label7.Text = "모헤어 가디건";
            else if (this.st.lather == true)
                label7.Text = "가죽자켓";
            else if (this.st.vasity == true)
                label7.Text = "바시티자켓";
            else label7.Text = "null";

            //minimal
            if (this.st.shirts == true)
                label8.Text = "셔츠";
            else if (this.st.cardigun == true)
                label8.Text = "미니멀가디건";
            else if (this.st.minimaljacket == true)
                label8.Text = "미니멀자켓";
            else label8.Text = "null";
            //cityboy
            if (this.st.shellparka == true)
                label9.Text = "쉘파카";
            else if (this.st.halfshirts == true)
                label9.Text = "반팔셔츠";
            else if (this.st.knit == true)
                label9.Text = "니트";
            else label9.Text = "null";

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string insertQuery = string.Format("INSERT INTO survey (name,sex,rockchic,minimal,cityboy) VALUES ('{0}', '{1}','{2}','{3}','{4}');", label2.Text, label3.Text, label7.Text, label8.Text, label9.Text);

                    MySqlCommand command = new MySqlCommand(insertQuery, mysql);
                    if (command.ExecuteNonQuery() != 1)
                        MessageBox.Show("Failed to insert data.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

          
            this.Hide();
            result re = new result();
            re.Show();
        }

        private void like_Load(object sender, EventArgs e)
        {

        }
    }
}
