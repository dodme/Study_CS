using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티.숙제
{
    abstract class CharacterAnimation
    {
        public abstract void Idle();
        public abstract void Walk();
        public abstract void Run();
        public abstract void Jump();
        public abstract void Die();
    }

    class Warrior : CharacterAnimation
    {
        public override void Die() { Console.WriteLine("유다희(듬직?)"); }

        public override void Idle() { Console.WriteLine("기본(듬직)"); }

        public override void Jump() { Console.WriteLine("점프한다!(듬직)"); }

        public override void Run() { Console.WriteLine("달린다!(듬직)"); }

        public override void Walk() { Console.WriteLine("걷는다!(듬직)"); }

        public void Slash() { Console.WriteLine("이걸사네(듬직)"); }
    }

    class Mage : CharacterAnimation
    {
        public override void Die() { Console.WriteLine("유다희(귀엽)"); }

        public override void Idle() { Console.WriteLine("기본(귀엽)"); }

        public override void Jump() { Console.WriteLine("점프한다!(귀엽)"); }

        public override void Run() { Console.WriteLine("달린다!(귀엽)"); }

        public override void Walk() { Console.WriteLine("걷는다!(귀엽)"); }

        public void Explosion() { Console.WriteLine("익스플로져언(귀엽)"); }
    }

    class Arhcer : CharacterAnimation
    {
        public override void Die() { Console.WriteLine("유다희(센치)"); }

        public override void Idle() { Console.WriteLine("기본(센치)"); }

        public override void Jump() { Console.WriteLine("점프한다!(센치)"); }

        public override void Run() { Console.WriteLine("달린다!(센치)"); }

        public override void Walk() { Console.WriteLine("걷는다!(센치)"); }

        public void Sniping() { Console.WriteLine("스나이핑(센치)"); }
    }

    class _07_추상클래스
    {
        public static void Main()
        { 
            
        }
    }
}
