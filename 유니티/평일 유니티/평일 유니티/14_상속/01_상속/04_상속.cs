using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._14_상속._01_상속
{
    // protected : 

    class Flower
    {
        protected string Name;
        protected int Cost;

        public void PrintFlowerInfo()
        {
            Console.WriteLine($"꽃의 이름 : {Name}");
            Console.WriteLine($"꽃의 가격 : {Cost}원");
        }
    }

    class Rose : Flower
    {
        public Rose(int cost)
        {
            Name = "장미";
            Cost = cost;
        }
    }

    class Tulip : Flower
    {
        public Tulip(int cost)
        {
            Name = "튤립";
            Cost = cost;
        }
    }

    class _04_상속
    {
        public static void Main()
        {
            new Rose(100).PrintFlowerInfo();
            new Tulip(200).PrintFlowerInfo();

          /*  Flower[] flower = { new Rose(100), new Tulip(200)};
            foreach (Flower f in flower)
            { 
                f.PrintFlowerInfo();
            }*/


            /*Rose rose = new Rose(100);
            rose.PrintFlowerInfo();
            Tulip tulip = new Tulip(200);
            tulip.PrintFlowerInfo();*/
        }
    }
}
