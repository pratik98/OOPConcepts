using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class GEInheritanceQ
    {
        class A
        {
            public int number;
            public string name;

            public A()
            {
                number = 10;
                // name = "india"; // since name for A has not be assigned any value,
                //Compiler will give warning about it being null always
            }
        }

        class B : A
        {
            public new  int number; //compiler warning : hides field from class A,
            public new string name; //Use new keyword to remove warning

            public B()
            {
                number = 20;
                name = "mumbai";
            } 
        }

        class C : B
        {
            public new int number;//compiler warning : hides field from class B
            public new string name;

            public C()
            {
                number = 30;
                name = "vadodara";
            }

            public void disp(A obj)
            {
                Console.WriteLine("Inside C's Disp Method:");
                Console.WriteLine(obj.number);
                Console.WriteLine(obj.name);
            }
        }
       
            public static void Main(string[] args)
            {
                A obj1 = new A();
                Console.WriteLine(obj1.number + "" + obj1.name); // Prints 10

                A obj2 = new B();
                Console.WriteLine(obj2.number + " " + obj2.name); // Prints 10

                A obj3 = new C();
                Console.WriteLine(obj3.number + "" + obj3.name); // Prints 10

                B obj4 = new B();
                Console.WriteLine(obj4.number + "" + obj4.name); // Prints 20 Mumbai

                C obj5 = new C();
                Console.WriteLine(obj5.number + "" + obj5.name); // Prints 30 vadodara

                // runtime using method
                obj5.disp(new B()); // Prints 10

                // runtime using method
                obj5.disp(new A());
                Console.ReadKey(); // Prints 10
            }
        
    }
}
