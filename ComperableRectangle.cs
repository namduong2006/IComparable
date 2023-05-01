using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace interface_IComparable
{
    internal class ComperableRectangle:Rectangle, IComparable<ComperableRectangle>
    {
        public ComperableRectangle() { }
        public ComperableRectangle(double width, double length) : base(width,length) { }
        public ComperableRectangle(double width, double length, string color, bool filled) : base(width,length, color,filled) { }

        public int CompareTo(ComperableRectangle r)
        {
            if (getArea() > r.getArea()) return 1;
            else if (getArea() < r.getArea()) return -1;
            else return 1;
        }
    }
}
