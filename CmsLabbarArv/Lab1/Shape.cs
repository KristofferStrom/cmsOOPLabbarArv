using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab1
{
    class Shape
    {
        protected readonly int width;
        protected readonly int height;

        public Shape(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public virtual float Area()
        {
            return width * height;
        }
    }
}
