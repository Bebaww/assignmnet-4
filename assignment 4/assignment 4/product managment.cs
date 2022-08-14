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
    public partial class product_managment : Form
    {
      string types;
        public product_managment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            
            product p = new product{ price = Convert.ToInt32 ( txt_price.Text),type=types,prod_date = production_date.Text, exp_date =expiry_date.Text, avalable = chk_box.Checked, product_name = txt_name.Text  ,batch_no=txt_batch.Text};
            p.save();
            dataGridView.DataSource = null;
            dataGridView.DataSource = product.getallproducts();
        }

        private void packed_CheckedChanged(object sender, EventArgs e)
        {
            types = packed.Text; 
        }

        private void unpacked_CheckedChanged(object sender, EventArgs e)
        {
            types = unpacked.Text;

        }
    }
}
