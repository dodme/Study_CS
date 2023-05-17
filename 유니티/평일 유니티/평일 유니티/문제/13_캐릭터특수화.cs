using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.문제
{
    class Character
    {
        protected string name;
        protected string weapon;

        public virtual void PrintInfo()
        {
            Console.WriteLine($"이름은 : {name}");
            Console.WriteLine($"무기는 : {weapon}");
        }
    }

    class Warrior : Character
    {
        private int def;

        public Warrior(string name, string weapon, int def)
        {
            this.name = name;
            this.weapon = weapon;
            this.def = def;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"방어력 : {def}");
        }
    }

    class Mage : Character
    {
        private int mp;

        public Mage(string name, string weapon, int mp)
        {
            this.name = name;
            this.weapon = weapon;
            this.mp = mp;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"마법력 : {mp}");
        }
    }

    class Archer : Character
    {
        private int eva;

        public Archer(string name, string weapon, int eva)
        {
            this.name = name;
            this.weapon = weapon;
            this.eva = eva;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"회피력 : {eva}");
        }
    }

    class _13_캐릭터특수화
    {
        public static void Main()
        {
            Character player = null;

            Console.WriteLine("직업을 선택하세요.");
            Console.WriteLine("1.전사 2.마법사 3.궁수");
            int inputNum = int.Parse(Console.ReadLine());


            switch (inputNum)
            {
                case 1:
                    player = new Warrior("김민자", "롱소드", 10);
                    player.PrintInfo();
                    break;
                case 2:
                    player = new Mage("김민자", "쓸데없이 큰 지팡이", 10);
                    player.PrintInfo();
                    break;
                case 3:
                    player = new Archer("김민자", "곡궁", 10);
                    player.PrintInfo();
                    break;
                default:
                    player = null;
                    break;
            }


        }
    }
}
