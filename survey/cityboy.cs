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

    public partial class cityboy : Form
    {
        state st;
        public cityboy(state st)
        {
            this.st = st;
            InitializeComponent();
            this.checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            this.checkBox2.CheckedChanged += CheckBox1_CheckedChanged;
            this.checkBox3.CheckedChanged += CheckBox1_CheckedChanged;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            var check = (CheckBox)sender;
            if (check.Text == "쉘파카")
                st.shellparka = checkBox1.Checked;
            if (check.Text == "반팔셔츠")
                st.halfshirts = checkBox2.Checked;
            if (check.Text == "니트")
                st.knit = checkBox3.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            like result= new like(st);
            result.Show();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                city_like.Text = checkBox1.Text;
            }

            else if (checkBox2.Checked == true)
            {
                city_like.Text = checkBox2.Text;
            }

            else if (checkBox3.Checked == true)
            {
                city_like.Text = checkBox3.Text;
            }
            else { city_like.Text = "null"; }
        }

        private void city_like_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
