using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructors
{
    class Rectangle
    {
        private int length;
        private int width;
        public Rectangle(int length, int width )
        {
            this.length = length;
            this.width = width;
        }
        public Rectangle(Rectangle rectangle) //COPY DATAILS FROM ONE OBJECT TO ANOTHER OBJECT
        {
            this.length = rectangle.length;
            this.width = rectangle.width;

        }
        public void Area()
        {
            Console.WriteLine("Area of Rectangle: "+(length*width));
        }
        class Test_Rectangle
        {

            static void Main(string[] args)
            {
                Rectangle r1=new Rectangle(23,34);
                r1.Area();
                Rectangle r2 = new Rectangle(15, 54);
                r2.Area();
                Rectangle r3 = new Rectangle(15, 10);
                r3.Area();

            }
        }
    }
}
