using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._12_구조체._01_구조체
{
    // 구조체  자료구조 Data Structure
    /// > 정보들의 집합
    /// > struct
    /// > 값형식

    struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void PrintPoint()
        {
            Console.WriteLine($"({x}, {y})");
        }
    }


    class _01_구조체
    {
        public static void Main()
        {
            Point p1;
            // Point p1 = new Point;
            p1.x = 10;
            p1.y = 20;


            Point p2 = p1;
            p2.x = 100;
            p2.y = 200;

            p1.PrintPoint();
            p2.PrintPoint();
        }
    }
}
