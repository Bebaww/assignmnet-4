using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_4
{
    internal class product
    {
        static List<product> products = new List<product>();
        public string product_name { get; set; }
        public string batch_no { get; set; }

        public string prod_date { get; set; }

        public string exp_date { get; set; }
        public bool avalable { get; set; }
        /*public bool packed { get; set; }
        public bool unpacked { get; set; }   */
        public string type { get; set; }



        public void save()
        {
            products.Add(this);


        }
       
        public static List<product> getallproducts()
        {
            return products;
        }
    }




    }

