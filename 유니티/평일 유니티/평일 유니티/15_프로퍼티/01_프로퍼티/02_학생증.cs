using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._15_프로퍼티._01_프로퍼티
{
    class NameCard
    {
        private string name;
        private uint age;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public uint Age
        { 
            get { return age; }
            set { age = value; }
        }
    }

    class _02_학생증
    {
        public static void Main()
        {
            NameCard student1 = new NameCard();
            NameCard student2 = new NameCard();

            student1.Name = "김민자";
            student1.Age = 10;

            student2.Name = "김필두";
            student2.Age = 11;


            Console.WriteLine(student1.Name);
            Console.WriteLine(student1.Age);

            Console.WriteLine(student2.Name);
            Console.WriteLine(student2.Age);
        }
    }
}
