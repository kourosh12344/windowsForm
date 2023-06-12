using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace treaning2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "admin")
            {
                if (txtpass.Text == "admin")
                {
                    if (txtuser.Text == "admin" && txtpass.Text == "admin")
                    {

                        MessageBox.Show("vorod movafagh");
                        Main main = new Main();
                        main.Show();
                    }
                    else
                    {

                        MessageBox.Show("vorod namovafagh");
                        
                    }
                }
                else
                {
                    txtpass.BackColor = Color.Red;
                }
            }
            else
            {
                txtuser.BackColor = Color.Red;
            }
        }
    }
}
