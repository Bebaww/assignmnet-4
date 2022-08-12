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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            product p = new product();
            product a = product.findone(txt_search.Text);
            if(a== null)
            {
                MessageBox.Show("product not found");

            }
            else
            {
                MessageBox.Show("batch no = " + a.batch_no +"\n" + "product name= "+ a.product_name +"\n "+ "production date= "+ a.prod_date+"\n" +"expiry date= "+a.exp_date);
            }
        }
    }
}
