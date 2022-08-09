using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_username.Text=="admin" & txt_password.Text=="admin" )
            {
                product_managment p= new product_managment();
                p.Show();

            }
            else
            {
                MessageBox.Show("username or password not found");
            }
        }
    }
}
