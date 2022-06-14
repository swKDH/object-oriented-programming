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
    public partial class start : Form
    {
        
        public start()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login form2 = new login();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            style form3 = new style();
            form3.Show();
        }

        private void start_Load(object sender, EventArgs e)
        {

        }
    }
}
