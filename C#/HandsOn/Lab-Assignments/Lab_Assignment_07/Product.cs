using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_07
{
    
    
        class Product
        {
            public int ProductNo { get; set; }
            public string Name { get; set; }
            public double Rate { get; set; }
            public int Stock { get; set; }


            public override string ToString()
            {
                return string.Format("{0,-10}{1,-10}{2,-10}{3,-10}", ProductNo, Name, Rate, Stock);
            }
        }

}
