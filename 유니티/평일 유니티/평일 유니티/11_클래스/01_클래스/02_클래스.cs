using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._11_클래스._01_클래스
{
    // 학생의 이름 나이 성별 을 담은 클래스를 정의합니다.

    enum Gender
    { 
        Man,
        Woman,
    }

    class Student
    {
        public string name;
        public uint Age;
        public Gender gender;

        // . : 멤버접근연산자

        public Student(string name, uint age, Gender gender)
        {
            this.name = name;
            this.Age = age;
            this.gender = gender;
        }


  /*      public void SetStudentInfo(string name, uint age, Gender gender)
        {
            this.name = name;
            this.Age = age;
            this.gender = gender;
        }*/

        public void PrintStudentInfo()
        {
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"나이 : {Age}");
            Console.WriteLine($"성별 : {gender}");
        }

    }


    class _02_클래스
    {
        public static void Main()
        {
            Student s1 = new Student("철수", 10, Gender.Man);
            s1.PrintStudentInfo();

            Student s2 = new Student("영희", 11, Gender.Woman);
            s2.PrintStudentInfo();
        }
    }
}
