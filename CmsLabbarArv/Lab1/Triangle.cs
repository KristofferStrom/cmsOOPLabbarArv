using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab1
{
    class Triangle : Shape
    {
        public Triangle(int width, int height)
            :base(width,height)
        {

        }

        public override float Area()
        {
            return width * height / 2;
        }
    }
}
