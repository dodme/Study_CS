using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._14_상속._04_인터페이스
{
    // 인터페이스 / Interface
    /// Interface
    /// > 추상메서드, 이벤트, 인덱서, 프로퍼티로 이루어진 클래스 비스무리한거(자료구조)
    /// > 다중상속이 가능하다
    /// > 인스턴스화가 불가능하다.
    /// > 접근제한자가 불가능하다.(기본은 public)

    public interface ISample
    {
        void Sample();
    }

    interface ISample2
    {
        void Sample2();
    }

    class SampleBase : ISample, ISample2
    {
        public void Sample()
        {
            Console.WriteLine("Sample1");
        }

        public void Sample2()
        {
            Console.WriteLine("Sample2");
        }
    }


    class _01_Interface
    {
        public static void Main()
        {
            SampleBase s1 = new SampleBase();
            s1.Sample();
        }
    }
}
