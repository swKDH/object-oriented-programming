using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace survey
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Id_txt.Text == "531kdh" && pw_txt.Text == "000531")
            {
                this.Hide();
                director director = new director();
                director.Show();

                
            }
            else
            {
                MessageBox.Show("아이디와 비밀번호를 확인해주세요.");
            }

        }
    }
}
