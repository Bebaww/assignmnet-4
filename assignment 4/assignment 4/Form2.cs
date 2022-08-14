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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            // to close other active form
            Form active = this.ActiveMdiChild;
            if(active != null)
            {
                active.Close();
            }

            product_managment p = new product_managment();
            p.MdiParent = this;
            p.Show();

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search s = new search();
            s.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void displayAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            display_all d = new display_all();
            d.Show();
        }
    }
}
