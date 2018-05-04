using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number10
{
    class Circle
    {

        public double CalCirc()
        {
            double circumference = ((2 * Math.PI) * Radius);
            return circumference;
        }
        public Circle(double radiusOne)
        {
            Radius = radiusOne;
        }
        

        public string CalFormCirc()
        {
           double circumference = CalCirc();
            string z = FormNum(circumference);
            return z;
        }

        public double CalArea()
        {
            double area = Math.PI * (Radius * Radius);
            return area;
        }

        public string CalFormArea()
        {
            double area = CalArea();
            string a = FormNum(area);
            return a;
        }

        private string FormNum(double x)
        {
            string y = Math.Round(x).ToString();
            return y;
        }
        private double radius;
        public double Radius
        {
            set
            {
                radius = value;
            }
            get
            {
                return radius;
            }

        }
    }
       
}
