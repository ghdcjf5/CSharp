/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace study1
{
    class Program
    {
        static void Main(string[] args) //class로 안만들어도 main이 실행된다.
            //메모리에 올라가지 않고 
        {
            int ivar;
            double dvar;
            ivar = 100;

           Console.WriteLine("ivar= "+ivar);
            //console은 객체다.
           dvar = 100.0 / 3.0;
           Console.WriteLine("dvar= " + dvar);
        }
    }
}
*/



/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace study1
{
    class Program
    {
        static void Main(string[] args) //class로 안만들어도 main이 실행된다.
        //메모리에 올라가지 않고 
        {
            int a,b,c;
            a = 2;
            b = 3;
            c = a - b;

            if (a < b) {
                Console.WriteLine("b가 크다.");
            
            }
            if (c<0)
            {
                Console.WriteLine("c는 음수입니다");

            }
        }
    }
}


*/


/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace study1
{
    class Program
    {
        static void Main(string[] args) //class로 안만들어도 main이 실행된다.
        //메모리에 올라가지 않고 
        {
            int cnt;
            int sum = 0;
            for (cnt = 0; cnt < 11; cnt++) {
                sum += cnt;
                Console.WriteLine("sum ="+ sum);
            
            }



             
        }
    }
}
*/



/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace study1
{
    class Program
    {
        static void Main(string[] args) //class로 안만들어도 main이 실행된다.
        //메모리에 올라가지 않고 
        {
            double x, y, z;
            x = 3;
            y = 3;
            z = Math.Sqrt(x * x + y * y);//math는 static 클래스 객체가 메모리에 올라가자 마자 생성
            Console.WriteLine("z = " + z);



        }
    }
}


*/


/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace study1
{
    class Program
    {
        static void Main(string[] args) //class로 안만들어도 main이 실행된다.
        //메모리에 올라가지 않고 
        {
            int cnt;
            cnt = 0xff;
            Console.WriteLine("b = " + cnt);

        }
    }
}


*/


/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace study1
{
    class Program
    {
        static void Main(string[] args) //class로 안만들어도 main이 실행된다.
        //메모리에 올라가지 않고 
        {
            double x, y;
            int i;
            x = 10.0;
            y = 3.0;
            i = (int)(x/y);
            Console.WriteLine("i = " + i);

        }
    }
}

*/



/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace study1
{
    class Program
    {
        static void Main(string[] args) //class로 안만들어도 main이 실행된다.
        //메모리에 올라가지 않고 
        {
           
                char ch;
                Console.WriteLine("Press Any Key :  ");
                ch = (char)Console.Read();
                Console.WriteLine("Key : " + ch);
                
          
        }
    }
}


*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace study1
{
    class Program
    {
        static void Main(string[] args) //class로 안만들어도 main이 실행된다.
        //메모리에 올라가지 않고 
        {

            String s;
            Console.Write("Press Any Key :  ");
            s = Console.ReadLine();
            Console.WriteLine("s : " + s);


        }
    }
}
