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

    public partial class style : Form
    {
        state st = new state();
        public style()
        {

            InitializeComponent();
            this.radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            this.radioButton2.CheckedChanged += radioButton1_CheckedChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            rockchic rock = new rockchic(st);
            rock.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var radio = (RadioButton)sender;
            if (radio.Text == "남")
                st.man = radioButton1.Checked;
            if (radio.Text == "여")
                st.woman = radioButton2.Checked;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            st.name = textBox1.Text;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            start s = new start();
            s.Show();
        }
    }
}
