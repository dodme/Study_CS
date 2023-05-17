using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._14_상속._03_추상매서드
{
    // C언어 숙제에 모든 힘을 쏟아부은 그는 놀랍게도..
    enum Power
    { 
        On,
        Off,
    }

    abstract class Machine
    {
        public virtual void PowerOnOff(Power power)
         {
            this.power = power;
            Console.WriteLine((power == Power.On) ? "전원을 켭니다." : "전원을 끕니다.");
        }

    public void Repair()
        {
            Console.WriteLine("Repair");
        }

    }

    class Aircon : Machine
    {
        public int temp = 18;
        public Power power = Power.Off;


        public override void PowerOnOff(Power power)
        {
            Console.WriteLine("에어컨의 전원입니다.");
            base.PowerOnOff();
        }
       

        public void PrintTemp()
        {
            Console.WriteLine($"현재 온도는 {temp}'C입니다.");
        }

        public void UpTemp()
        {
            temp++;
            PrintTemp();
        }

        public void DownTemp()
        {
            temp--;
            PrintTemp();
        }

    }

    class _01_에어컨멈춰
    {
        public static void Main()
        {
            Aircon aircon = new Aircon();

            aircon.PowerOnOff(Power.On);
            aircon.PrintTemp();
            aircon.UpTemp();
            aircon.DownTemp();
            aircon.Repair();
            aircon.PowerOnOff(Power.Off);
        }
    }
}
