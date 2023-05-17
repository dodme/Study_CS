using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.문제
{
    class Character
    {
        string _nickName;
        uint _level = 1;

        public Character(string nickname, uint level = 1)
        {
            _nickName = nickname;
            _level = level;
        }

        public void PrintCharacterInfo()
        {
            Console.WriteLine($"이름 : {_nickName}");
            Console.WriteLine($"레벨 : {_level}");
        }
    }

    class _11_zl존법사
    {
        public static void Main()
        {
            Character player = new Character("zl존법사", 1);
            player.PrintCharacterInfo();
        }
    }
}
