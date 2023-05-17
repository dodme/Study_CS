using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._11_클래스._01_클래스
{
    enum Power
    { 
        On,
        Off,
    }

    class AirConditional
    {
        public int temp = 18;
        public Power power = Power.Off;

        public void PowerOnOff(Power power)
        {
            this.power = power;
            Console.WriteLine((power == Power.On) ? "전원을 켭니다." : "전원을 끕니다.");
        }

        public void PrintfTemp()
        {
            Console.WriteLine($"현재 온도는 {temp}'C 입니다.");
        }

        public void TempUp()
        {
            temp++;
            PrintfTemp();
        }

        public void TempDown()
        {
            temp--;
            PrintfTemp();
        }
    }

    class _03_에어컨
    {
        public static void Main()
        {
            AirConditional LG = new AirConditional();

            LG.PowerOnOff(Power.On);
            LG.PrintfTemp();
            LG.TempUp();
            LG.TempDown();
            LG.PowerOnOff(Power.Off);
        }
    }
}
