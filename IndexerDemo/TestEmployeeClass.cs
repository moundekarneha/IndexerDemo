using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo
{
    internal class TestEmployeeClass
    {
        static void Main()
        {
            Employee emp = new Employee(1001, "Neha", "Software", "Senior Engineer", "Island", 70000);
            Console.WriteLine("getting value of employee class using index");
            Console.WriteLine("Employee number = " + emp[0]);
            Console.WriteLine("Employee name = " + emp[1]);
            Console.WriteLine("Employee job = " + emp[2]);
            Console.WriteLine("Employee department = " + emp[3]);
            Console.WriteLine("Employee location = " + emp[4]);
            Console.WriteLine("Employee salary = " + emp[5]);


            Console.WriteLine("\n\nAssign value of employee class using index");
            emp[0] = 1002;
            emp[1] = "Pranita";
            emp[2] = "Software Engg";
            emp[3] = "Software";
            emp[4] = "Nagpur";
            emp[5] = 60000.0;

            Console.WriteLine("\n\ngetting value of employee class using index");
            Console.WriteLine("Employee number = " + emp[0]);
            Console.WriteLine("Employee name = " + emp[1]);
            Console.WriteLine("Employee job = " + emp[2]);
            Console.WriteLine("Employee department = " + emp[3]);
            Console.WriteLine("Employee location = " + emp[4]);
            Console.WriteLine("Employee salary = " + emp[5]);

           

            EmpClass empcls = new EmpClass(1001, "Neha", "Software", "Senior Engineer", "Island", 70000);
            Console.WriteLine("\n\ngetting value of employee class using index");
            Console.WriteLine("Employee number = " + empcls["eno"]);
            Console.WriteLine("Employee name = " + empcls["ename"]);
            Console.WriteLine("Employee job = " + empcls["job"]);
            Console.WriteLine("Employee department = " + empcls["dname"]);
            Console.WriteLine("Employee location = " + empcls["location"]);
            Console.WriteLine("Employee salary = " + empcls["salary"]);


            Console.WriteLine("\n\nAssign value of employee class using index");
            empcls["eno"] = 1002;
            empcls["ename"] = "Pranita";
            empcls["job"] = "Software Engg";
            empcls["dname"] = "Software";
            empcls["location"] = "Nagpur";
            empcls["salary"] = 60000.0;

            Console.WriteLine("\n\ngetting value of employee class using index");
            Console.WriteLine("Employee number = " + empcls["eno"]);
            Console.WriteLine("Employee name = " + empcls["ename"]);
            Console.WriteLine("Employee job = " + empcls["job"]);
            Console.WriteLine("Employee department = " + empcls["dname"]);
            Console.WriteLine("Employee location = " + empcls["location"]);
            Console.WriteLine("Employee salary = " + empcls["salary"]);




            Console.ReadLine();
        }

    }
}
