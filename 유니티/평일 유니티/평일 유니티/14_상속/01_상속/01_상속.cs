using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._14_상속._01_상속
{
    // 상속
    /// 부모가 가진 정보를 자식에게 물려주는것
    /// 코드에대한 재활용성을 높이기 위해
    /// 부모클래스, 상위클래스, 기반클래스, BaseClass
    /// 자식클래스, 하위클래스, 파생클래스, ChildClass

    class SampleBase
    {
        public int Base_Num;

        public void Base_Method()
        {
            Console.WriteLine("Base");
        }
    }

    class SampleChild : SampleBase
    {
        public int child_Num;

        public void Child_Method()
        {
            //Base_Num = 10;
            //Base_Method();

            Console.WriteLine("Child");
        }
    }

    class _01_상속
    {
        public static void Main()
        {
            SampleChild child1 = new SampleChild();
            child1.Child_Method();
        }
    }
}
