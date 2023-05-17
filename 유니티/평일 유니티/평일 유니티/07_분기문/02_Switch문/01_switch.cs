using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._07_분기문._02_Switch문
{
    // switch
    /// switch(검사할 값)
    /// {
    ///     case 값:
    ///         {실행할 코드}
    ///         break;
    ///     case 값:
    ///         {실행할 코드}
    ///         break;
    ///     case 값:
    ///         {실행할 코드}
    ///         break;
    ///     default:
    ///         {실행할 코드}
    ///         break;
    /// }

    class _01_switch
    {
        public static void Main()
        {
            int num = 1;

            switch (num)
            {
                case 1:
                    Console.WriteLine("1입니다.");
                    break;
                case 2:
                    Console.WriteLine("2입니다.");
                    break;
                case 3:
                    Console.WriteLine("3입니다.");
                    break;
                default:
                    Console.WriteLine("모두 아닙니다.");
                    break;

            }
        }
    }
}
