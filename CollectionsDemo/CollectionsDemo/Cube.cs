using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    interface Shapes
    {
       double area();
        double volume();
        
    }
    class Cube : Shapes
    {
        int x = 10;

        public double area()
        {
              return (6*x*x);
        }

        public double volume()
        {
            return (x*x*x);
        }
    }

    class circle : Shapes
    {
        int radius = 10;

        public double area()
        {
            return (3.142 * radius * radius);
        }

        public double volume()
        {
            return (0);
        }


    }

}
