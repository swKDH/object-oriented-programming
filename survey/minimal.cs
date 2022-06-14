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
    public partial class minimal : Form
    {
        state st;
        public minimal(state st)
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
            if (check.Text == "셔츠")
                st.shirts = checkBox1.Checked;
            if (check.Text == "미니멀가디건")
                st.cardigun = checkBox2.Checked;
            if (check.Text == "미니멀자켓")
                st.minimaljacket = checkBox3.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            cityboy form3 = new cityboy(st);
            form3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                min_like.Text = checkBox1.Text;
            }

            else if (checkBox2.Checked == true)
            {
                min_like.Text = checkBox2.Text;
            }

            else if (checkBox3.Checked == true)
            {
                min_like.Text = checkBox3.Text;
            }
            else { min_like.Text = "null"; }
        }

        private void minimal_Load(object sender, EventArgs e)
        {

        }
    }
}
