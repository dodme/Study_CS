using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._19_그외나머지
{
    // 연산자 오버로딩
    /// > 연산자의 기능을 중복정의 하는것
    /// > operator
    /// > 반드시 정적 필드에 선언 되어야 한다.
    /// > 접근제한자는 public 이어야 한다.

    class _02_연산자오버로딩
    {
        public struct Point
        {
            public int x, y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public static Point operator +(Point p1, Point p2)
            {
                return new Point(p1.x + p2.x, p1.y + p2.y);
            }

            public void PrintPoint()
            {
                Console.WriteLine($"({x}, {y})");
            }

        }

        public static void Main()
        {
            Point p1 = new Point(10, 10);
            Point p2 = new Point(20, 20);

            Point p3 = p1 + p2;

            p3.PrintPoint();

        }
    }
}
