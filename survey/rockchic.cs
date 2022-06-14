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
    public partial class rockchic : Form
    {
        state st;
        public rockchic(state st)
        {
            this.st = st;
            InitializeComponent();
            this.checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            this.checkBox2.CheckedChanged += CheckBox1_CheckedChanged;
            this.checkBox3.CheckedChanged += CheckBox1_CheckedChanged;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            minimal min= new minimal(st);
            min.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked==  true)
            {
                rock_like.Text = checkBox1.Text;
            }
            
            else if(checkBox2.Checked==  true)
            {
                rock_like.Text= checkBox2.Text;
            }
            
            else if (checkBox3.Checked==  true)
            {
                rock_like.Text=checkBox3.Text;
            }
            else { rock_like.Text = "null"; }
        }

        private void rockchic_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            var check = (CheckBox)sender;
            if (check.Text == "모헤어 가디건")
                st.mohair = checkBox1.Checked;
            if (check.Text == "가죽자켓")
                st.lather = checkBox2.Checked;
            if (check.Text == "바시티자켓")
                st.vasity = checkBox3.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
