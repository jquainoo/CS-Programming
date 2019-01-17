using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming.DayOne
{
    //Exercise 2
    public class HelpDesk
    {

        static HelpDesk()
        {
            DepQueue = new RequestQueue<Department>(100);
            EmpQueue = new RequestQueue<Employee>(10); 

        }

        public static RequestQueue<Department> DepQueue { get; set; }
        public static RequestQueue<Employee> EmpQueue { get; set; }


        public bool ProcessDepRequest()
        {
            return DepQueue.ProcessItem();
        }

        public bool ProcessEmpRequest()
        {
            return EmpQueue.ProcessItem();
        }

    }
}
