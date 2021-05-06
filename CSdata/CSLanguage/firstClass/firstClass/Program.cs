/*

 * 
 * 
 * 
 * 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firstClass
{

    class Bus { //struct같은 느낌
        public int seat; //public은 접근 표시
        public int consumption;
        public void energy() {

            Console.WriteLine("에너지" + (seat * consumption));
        
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bus van = new Bus(); // van이 포인터같은거(레퍼런스)
            Bus van1 = new Bus(); //new를 하면 메모리에 올라간다.
            van.seat = 50;  //van은 seat랑 consumtion이 들어있다.
            van.consumption = 200;
            van1.seat = 150;
            van1.consumption = 300;
            Console.WriteLine("좌석수 : " + van.seat);
            Console.WriteLine("연료 소모량 : " + van.consumption);
            Console.WriteLine("좌석수 : " + van1.seat);
            Console.WriteLine("연료 소모량 : " + van1.consumption);
            van.energy();
            van1.energy();
        }
    }
}

 
 * 
 * 
 * 
 * 
 */

/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firstClass
{

    class Serial_
    { //struct같은 느낌
        public int speed;
        public void println()
        {

            Console.WriteLine("Hello World    " + speed);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           Serial_ Serial = new Serial_();
           Serial.speed = 9600;
           Serial.println();

            
           
        }
    }
}

*/




/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firstClass
{
    class Calculation {

        public int a, b;
        public int add() {
           
           return a + b;
        }
        public int mul()
        {
            return a * b;
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            Calculation cal = new Calculation();

            cal.a = 100;
            cal.b = 200;

            Console.WriteLine("a,b의 합 : " + cal.add());
            Console.WriteLine("a,b의 곱 : " + cal.mul());



        }
    }
}


*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace firstClass
{
    class Calculation2
    {

        public int x, y;
        public int add()
        {

            return x + y;
        }
        public int mul()
        {
            return x * y;
        }
    }

    class Calculation
    {

        public int a, b;
        public void add()
        {
            Console.WriteLine("a,b의 합 : " + (a+b));
           
        }
        public void mul()
        {
            Console.WriteLine("a,b의 곱 : " + (a*b));
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Calculation2 calculation = new Calculation2();

            calculation.x = 100;
            calculation.y = 200;

            Console.WriteLine("a,b의 합 : " + calculation.add());
            Console.WriteLine("a,b의 곱 : " + calculation.mul());

            Calculation cal ;
            Calculation cal1;
            cal= new Calculation();
            cal1 = cal;
            cal.a = 15;
            cal.b = 16;
            cal.add();
            cal.mul();
            cal1.add();
            cal1.mul();



        }
    }
}
