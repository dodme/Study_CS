using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._11_클래스._05_접근제한자
{
    class Student
    {
        string _name;
        uint _age;
        bool _gender = false;


        //Getter
        public string GetName() { return _name; }
        public uint GetAge() { return _age; }
        public bool GetGender() { return _gender; }

        /*//Setter
        public void SetName(string name) { _name = name; }
        public void SetAge() { }*/
        public void SetAge(uint age) { _age = age; }

        public Student(string name, uint age, bool gender)
        {
            _name = name;
            _age = age;
            _gender = gender;
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine(_name);
            Console.WriteLine(_age);
            Console.WriteLine((_gender) ? "남자" : "여자" );
        }

    }

    class _02_접근제한자
    {
        public static void Main()
        { 
            
        }
    }
}
