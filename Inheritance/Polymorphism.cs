using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        //Creating an Abstract Class
           class absClass
        {
            //A Non abstract method
            public int AddTwoNumbers(int Num1, int Num2)
            {
                return Num1 + Num2;
            }

            //An abstract method, to be
            //overridden in derived class
            protected virtual int MultiplyTwoNumbers(int Num1, int Num2)
            {
                return Num1 * Num2;
            }

            public void show()
            {
                 Console.WriteLine("in absclass");
            }
            
        }

        //A Child Class of absClass
        class absDerived : absClass
        {
            //using override keyword,
            //implementing the abstract method
            //MultiplyTwoNumbers
            // if we dont use new keyword below it will give warning, and it will hide the base class method

            protected override int MultiplyTwoNumbers(int Num1, int Num2)
            {
               return Num1 * Num2;
                //Console.Write("dumbo^2");
            }

            public new void show()
            {
                Console.WriteLine("In absDerived class");
            }

            [STAThread]
            static void Main(string[] args)
            {
                //You can create an
                //instance of the derived class

//                absDerived calculate = new absDerived();
//                int added = calculate.AddTwoNumbers(10, 20);
//                int multiplied = calculate.MultiplyTwoNumbers(10, 20);


//                Console.WriteLine(@"Added : {0}, 
//                       Multiplied : {1}", added, multiplied);

                absDerived child = new absDerived();
                child.show();  // calls derived class method
              //  ((absClass)child).show(); // calls base class method

                absClass bas = new absClass();
                bas.show(); // calls base class method


                 bas = new absDerived();
                 bas.show(); // calls base class method


                 //child = new absClass(); // error
                // child = (absDerived)new absClass();  // compiles but runtime exception
                // child.show();


                Console.ReadKey();


            }
        }

        
    }
}

