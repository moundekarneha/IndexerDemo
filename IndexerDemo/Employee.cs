using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo
{
    public class Employee
    {
        int eno;
        string ename, job, dname, location;
        double salary;

        public Employee(int eno, string ename, string job, string dname, string location, double salary)
        {
            this.eno = eno;
            this.ename = ename;
            this.job = job;
            this.dname = dname;
            this.location = location;
            this.salary = salary;
        }

        public object this[int index]
        {
            get
            {
                if(index == 0)
                    return eno;
                else if(index == 1)
                    return ename;
                else if (index == 2)
                    return job;
                else if (index == 3)
                    return dname;
                else if (index == 4)
                    return location;
                else if (index == 5)
                    return salary;
                
                    return null;
           
            }
            set
            {
                if (index == 0)
                    eno =(int)value;
                else if (index == 1)
                    ename = (string)value;
                else if (index == 2)
                    job = (string)value; 
                else if (index == 3)
                    dname = (string)value; 
                else if (index == 4)
                    location = (string)value;
                else if (index == 5)
                    salary = (double)value;
            }
        }
    }
}
