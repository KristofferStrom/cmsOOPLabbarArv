using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmsLabbarArv.Lab1
{
    abstract class Shape
    {
        protected readonly int width;
        protected readonly int height;

        public int Test { get; set; }

        public Shape(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public abstract float Area();
    }
}
