using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerDemo
{
    internal class EmpClass
    {
        int eno;
        string ename, job, dname, location;
        double salary;

        public EmpClass(int eno, string ename, string job, string dname, string location, double salary)
        {
            this.eno = eno;
            this.ename = ename;
            this.job = job;
            this.dname = dname;
            this.location = location;
            this.salary = salary;
        }

        public object this[string name]
        {
            get
            {
                if (name.ToUpper() == "ENO")
                    return eno;
                else if (name.ToUpper() == "ENAME")
                    return ename;
                else if (name.ToUpper() == "JOB")
                    return job;
                else if (name.ToUpper() == "DNAME")
                    return dname;
                else if (name.ToUpper() == "LOCATION")
                    return location;
                else if (name.ToUpper() == "SALARY")
                    return salary;
                return null;
            }

            set
            {
                if (name.ToUpper() == "ENO")
                    eno = (int)value;
                else if (name.ToUpper() == "ENAME")
                    ename = (string)value;
                else if(name.ToUpper() == "JOB")
                    job = (string)value;
                else if (name.ToUpper() == "DNAME")
                    dname = (string)value;
                else if (name.ToUpper() == "LOCATION")
                    location = (string)value;
                else if (name.ToUpper() == "SALARY")
                    salary = (double)value;
            }
        }





    }
}
