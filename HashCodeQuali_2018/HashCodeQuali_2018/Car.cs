using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCodeQuali_2018
{
    class Car
    {
        public List<Order> orders = new List<Order>();

        public int step = 0;
        public Point endPos = new Point(0, 0);
    }
}
