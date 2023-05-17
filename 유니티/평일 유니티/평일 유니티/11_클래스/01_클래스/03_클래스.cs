using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._11_클래스._01_클래스
{
    // 문제
    /// AirConditional 클래스를 정의합니다.

    // - output -
    /// 전원을 켭니다.
    /// 현재온도는 18'C입니다.
    /// 온도를 올립니다.
    /// 현재온도는 19'C입니다.
    /// 온도를 내립니다.
    /// 현재온도는 18'C입니다.
    /// 전원을 끕니다.
    enum Power
    {
        On,
        Off,
    }

    class Airconditional
    {

        public int temperature;
        public Power power;

        public void SetPower(Power power)
        {
            this.power = power;
            Console.WriteLine((power == Power.On) ? "전원을 켭니다." : "전원을 끕니다.");
        }

        public void UpTemperature()
        {
            Console.WriteLine("온도를 올립니다.");
            temperature++;
            Console.WriteLine($"현재 온도는 {temperature}'C입니다.");
        }

        public void DownTemperature()
        {
            Console.WriteLine("온도를 내립니다.");
            temperature--;
            Console.WriteLine($"현재 온도는 {temperature}'C입니다.");
        }

        public void SetTemperature(int temperature)
        {
            this.temperature = temperature;
        }

    }

    class _03_클래스
    {
        public static void Main()
        {
            Airconditional machine = new Airconditional();

            machine.SetTemperature(18);

            machine.SetPower(Airconditional.Power.On);

        }
    }
}
