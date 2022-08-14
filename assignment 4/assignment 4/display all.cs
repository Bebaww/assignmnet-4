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
    public partial class display_all : Form
    {
        public display_all()
        {
            InitializeComponent();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {

            var a = product.findall( Convert.ToInt32(txt_display.Text));


            if (a != null)
            {
                datadisplay.DataSource = a;
            }
            
                
            }
            
        }
    }

