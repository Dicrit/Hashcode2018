using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCodeQuali_2018
{
    class Order
    {
        public int id;

        public Point start;
        public Point end;
        public int startTime;
        public int endTime;

        public int value;




        //public Order(int a, int b, int x, int y, int st, int et)
        //{
        //    start = new Point(a, b);
        //    end = new Point(x, y);
        //    value = Point.Distance(start, end);
        //    startTime = st;
        //    endTime = et;
        //}
        public Order(int id, string str)
        {
            this.id = id;
            int[] v = FileManager.GetIntArray(str);
            start = new Point(v[0], v[1]);
            end = new Point(v[2], v[3]);
            value = Point.Distance(start, end);
            startTime = v[4];
            endTime = v[5];
        }
    }
    struct Point
    {
        public Point(int a, int b)
        {
            x = a;
            y = b;
        }
        public static int Distance(Point a, Point b)
        {
            return Math.Abs(a.x - b.x) + Math.Abs(a.y - b.y);
        }
        public int x, y;
    }
}
