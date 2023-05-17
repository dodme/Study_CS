using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._14_상속._02_가상함수
{
    // 원을 그립니다.
    // 사각형을 그립니다.
    // 삼각형을 그립니다.

    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("도형을 그립니다.");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("원을 그립니다.");
        }
    }

    sealed class Ellipse : Circle
    {
        // sealed?
        /// > 봉인 시킵니다.
        public override sealed void Draw()
        {
            Console.WriteLine("타원을 그립니다.");
        }
    }

    class _02_오버라이딩
    {
        public static void Main()
        {
            Shape shape = new Ellipse();
            shape.Draw();
        }
    }
}
