using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Polygon
    {
        protected int width, height;
        private int depth;
        private int numSides;

        public void setValues(int width, int height, int numSides)
        {
            this.width = width;
            this.height = height;
            this.numSides = numSides;
        }

        public virtual int showNumSides()
        {
            return numSides;
        }
    }
}
