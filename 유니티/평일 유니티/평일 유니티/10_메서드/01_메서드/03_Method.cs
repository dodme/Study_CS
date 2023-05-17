using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._10_메서드._01_메서드
{
    class _03_Method
    {
        public static int Potion(int characterHp)
        {
            if (characterHp > 100)
            {
                return characterHp;
            }
            else if (characterHp < 100)
            {
                return Math.Min(100, characterHp + 10);
            }
            return 0;
        }

        public static void Main()
        {
            int characterHp = 100;
            
            Console.WriteLine(Potion(characterHp));   
            
        }
    }
}
