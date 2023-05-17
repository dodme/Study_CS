using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.숙제
{
    enum Job
    { 
        무야호,
        전사,
        마법사,
        궁수
    }

    class Character
    {
        protected Job Job;
        protected string NickName;
        protected string Weapon;

        public void Default(string nickname)
        {
            Job = Job.무야호;
            NickName = nickname;
            Weapon = "그만큼 신나시다는거지~";
        }

        public virtual void PrintCharacterInfo()
        {
            Console.WriteLine($"캐릭터 직업 : {Job}");
            Console.WriteLine($"캐릭터 닉네임 : {NickName}");
            Console.WriteLine($"캐릭터 무기 : {Weapon}");
        }
    }

    class Warrior : Character
    {
        protected int def = 10;

        public Warrior(string nickname)
        {
            Job = Job.전사;
            NickName = nickname;
            Weapon = "막대기";
        }

        public override void PrintCharacterInfo()
        {
            base.PrintCharacterInfo();
            Console.WriteLine($"방어력 : {def}");
        }

    }

    class Mage : Character
    {
        // 아무튼 마력
        protected int Mile = 100;

        public Mage(string nickname)
        {
            Job = Job.마법사;
            NickName = nickname;
            Weapon = "지팡이(물리)";
        }

        public override void PrintCharacterInfo()
        {
            base.PrintCharacterInfo();
            Console.WriteLine($"마력 : {Mile}");
        }

    }

    class Archer : Character
    {
        protected int dodge = 20;

        public Archer(string nickname)
        {
            Job = Job.궁수;
            NickName = nickname;
            Weapon = "총";
        }

        public override void PrintCharacterInfo()
        {
            base.PrintCharacterInfo();
            Console.WriteLine($"회피력 : {dodge}");
        }
    }

    class _06_진짜으악숙제
    {
        public static void Main()
        {
            Console.WriteLine("직업을 선택해주세요.");
            Console.WriteLine("1.전사  2.마법사  3.궁수");
            int job = int.Parse(Console.ReadLine());

            Console.WriteLine("닉네임을 입력해주세요.");
            string name = Console.ReadLine();

            Character player = new Character();

            switch (job)
            {
                case 1:
                    player = new Warrior(name);
                    break;

                case 2:
                    player = new Mage(name);
                    break;

                case 3:
                    player = new Archer(name);
                    break;

                default:
                    player.Default(name);
                    Console.WriteLine("무직입니다.");
                    break;
            }

            player.PrintCharacterInfo();
        }
    }
}
