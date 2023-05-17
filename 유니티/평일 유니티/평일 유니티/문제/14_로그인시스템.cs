using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.문제
{
    class _14_로그인시스템
    {
        public static void Main()
        {
            // Hashtable을 이용해 로그인 시스템을 구현하세요!
            Hashtable Login = new Hashtable();

            Login.Add("김민자", "1234");
            Login.Add("김필두", "1111");
            Login.Add("김두곽", "1212");

            Console.WriteLine("ID를 입력하세요");
            string id = Console.ReadLine();

            if (Login.ContainsKey(id))
            {
                Console.WriteLine("비밀번호를 입력하세요");
                string password = Console.ReadLine();

                if ()
                {
                    Console.WriteLine("Login");
                }
                else
                {
                    Console.WriteLine("비밀번호가 잘못됬습니다.");
                }
            }
            else
            {
                Console.WriteLine("ID가 잘못됬습니다.");
            }

        }
    }
}
