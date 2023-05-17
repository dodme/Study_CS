using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllLibrary
{
    public class HelloLibrary
    {
        public int pub_Num;
        internal int int_Num;

        public void Pub_Method()
        {
            Console.WriteLine("Hello World!");
        }

        internal void Int_Method()
        {
            Console.WriteLine("Hello");
        }
    }
}
