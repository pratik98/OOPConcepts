using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //class Employee
    //{
    //    public void EmployeeType()
    //    {
    //        Console.WriteLine("Base Class Employee Type");
    //    }
    //}


    //class Manager : Employee
    //{
    //    //Here this is not overriding. This is a new method of Manager class
    //    //Compiler is giving a warning because this method is same as the method defined in Employee base class
    //    //So this method is hiding the method of base class.

    //    public void EmployeeType()
    //    {
    //        Console.WriteLine("Employee Type is Manager");
    //    }
    //}


    //class Developer : Employee
    //{
    //    //This is also not overriding
    //    //But we are removing the compiler warning by using the new keyword

    //    public new void EmployeeType()
    //    {
    //        Console.WriteLine("Employee Type is Developer");
    //    }
    //}


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //        Employee objEmp = new Employee(); //Will call base class method
    //        Employee objMan = new Manager();  //Will call base class method
    //        Employee objDev = new Developer(); //Will call base class method

    //        objEmp.EmployeeType();
    //        objMan.EmployeeType();
    //        objDev.EmployeeType();


    //        /////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //        Manager objMan1 = new Manager();  //Will call Manager class method
    //        Developer objDev1 = new Developer(); //Will call Developer class method

    //        objMan1.EmployeeType();
    //        objDev1.EmployeeType();

    //        Console.ReadLine();
    //    }
    //}
}
