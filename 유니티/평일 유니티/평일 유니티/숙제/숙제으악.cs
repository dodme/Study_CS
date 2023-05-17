using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.숙제
{
    class Character
    {
        private string _nickName;
        private uint _level;

        public void SetCharacterInfo(string nickname, uint level)
        {
            _nickName = nickname;
            _level = level;
        }

        public void PrintCharacterInfo()
        {
            Console.WriteLine($"캐릭터 닉네임 : {_nickName}");
            Console.WriteLine($"{_nickName}의 레벨 {_level}");
        }

    }

    class 숙제으악
    {
        public static void Main()
        {
            Character player = new Character();

            Console.Write("캐릭터 이름은 ? ");
            string name = Console.ReadLine();
            Console.Write("캐릭터 레벨은? ");
            uint level = uint.Parse(Console.ReadLine());

            Console.WriteLine();

            player.SetCharacterInfo(name, level);

            player.PrintCharacterInfo();
        }
    }
}
