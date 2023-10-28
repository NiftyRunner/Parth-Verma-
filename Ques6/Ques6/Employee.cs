using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques6
{
    internal class Employee
    {
        string employeeName;
        string city;
        int basicSalary;
        int da;
        int hra;

        public Employee(string eName, string cityName, int basic, int dAllowance, int hRent)
        {
            employeeName = eName;
            city = cityName;
            basicSalary = basic;
            da = dAllowance;
            hra = hRent;
        }

        public string GetName()
        {
            return employeeName;
        }
        public string GetCity() 
        { 
            return city;
        }

        public int GetBasicSalary() 
        {
            return basicSalary;
        }

        public int GetDa()
        {
            return da;
        }

        public int GetHRent()
        {
            return hra;
        }
    }
}
