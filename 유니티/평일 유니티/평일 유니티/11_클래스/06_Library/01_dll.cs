using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 평일_유니티._11_클래스._06_Library
{
    class _01_dll
    {
        // private
        // protected
        // public
        // internal

        // DLL : (Dynamic Linked Library} / 동적 연결 라이브러리
        // dll 만드는법~
        /// 파일 - 새로만들기 - 프로젝트 - 클래스 라이브러리[.Net Framework] - 코드 - 빌드!

        // 적용시키는법~
        /// 솔루션 탐색기 - 참조 - 참조추가 - bin - debug - .dll



        public static void Main()
        {
            DllLibrary.HelloLibrary sample = new DllLibrary.HelloLibrary();
            sample.pub_Num = 10;
            sample.Pub_Method();
        }
    }
}
