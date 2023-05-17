using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._15_프로퍼티._01_프로퍼티
{
    // 프로퍼티
    /// Getter / Setter의 작성의 불편함을 덜어주는 기능

    class Student
    {
        private string name;
        private int age;

        /*public string GetName() { return name; }
        public int GetAge() { return age; }

        public void SetName(string value) { name = value; }
        public void SetAge(int value) { age = value; }*/
        
        
        /*int level; 

        public int Level
        { 
            get { return level; }
            set 
            {
                if (maxExp < exp)
                { 
                    exp = maxExp
                }
                level = value;
            }
        }*/

        public string Name
        {
            get 
            {
                Console.WriteLine("프로퍼티 무야호~");
                return name; 
            }
            set 
            {
                name = value; 
            }
            // value : 암묵적 매개변수
        }

        public int Age
        { 
            //get { return age; } // 읽기 전용 프로퍼티
            //private set { age = value; } // 내부에서만 설정 가능
            //protected set { age = value; } // 접근제한자 설정 가능
            set { age = value; } // 쓰기 전용 프로퍼티 / 쓰기 전용일때는 접근제한자 설정 불가능
        }
    }

    class _01_프로퍼티
    {
        public static void Main()
        {
            Student s1 = new Student();
            s1.Name = "이경현";

            Console.WriteLine(s1.Name);

        }
    }
}
