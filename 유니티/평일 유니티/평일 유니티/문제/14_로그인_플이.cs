using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.문제
{
    class _14_로그인_플이
    {
        public static void Main()
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Add("id", "password");
            hashtable.Add("아이디", "패스워드");

            while (true)
            {
                Console.WriteLine("키미노 id와?");
                string id = Console.ReadLine();

                if (hashtable.ContainsKey(id))
                {
                    while (true)
                    {
                        Console.WriteLine("키미노 password와?");
                        string password = Console.ReadLine();
                        if (hashtable[id].Equals(password))
                        //if(hashtable[id].ToString() == password)
                        {
                            Console.WriteLine("로그인 성공!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("패스워드가 일치하지 않습니다.");
                            Console.WriteLine("다시 입력해 주세요!");
                            continue;
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("아이디가 없습니다.");
                    Console.WriteLine("다시 입력해주세요.");
                }
            }

        }
    }
}
