/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace checkOddEven
{
    class ChkOddEvn {

        public bool isEven(int x) {

            if ((x % 2) == 0)
            {
                Console.WriteLine(x);
                return true;
            }
            else {
                return false;
            }
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            ChkOddEvn evn = new ChkOddEvn();
            if(evn.isEven(10)){
               
                Console.WriteLine(evn.isEven(10));
                Console.WriteLine("10은 짝수다");
            }
            if(!evn.isEven(9)){
                Console.WriteLine("9은 홀수다");
            }

        }
    }
}

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace checkOddEven
{
    class MyClass
    {

        public int x;
        public MyClass() { //생성자. class 이름과 같아야하고 리턴값이없다.
            //어떤 값을 초기화하기 위해 만들어놓는다.

            x = 10;
            Console.WriteLine("First Start");
        }
        public MyClass(int x)
        {
            this.x = x;  //x는 MyClass(int x)의 x, this.x는 public int x
            //변수를 같은것을 쓸때 헷갈리지 않기위해 사용
            
           
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass t1 = new MyClass();  //변수가 없으니 (void) MyClass()로 간다.
            MyClass t2 = new MyClass(100);
            Console.WriteLine("t2 x는 " + t2.x);
            Console.WriteLine("t1 x는 " + t1.x);
        }
    }
}

