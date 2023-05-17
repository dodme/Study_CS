using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._15_프로퍼티._01_프로퍼티
{
    class Sample
    {
        string name;

        public string Name
        { 
            get { return name; }
            set { name = value; }
        }

        public int Age { get; set; }
    }

    class _02_자동구현프로퍼티
    {
        public static void Main()
        { 
            
        }
    }
}
