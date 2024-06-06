using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace query_syntax_operation_next
{
    class Employee
    {
        public Int64 empid { get; set; }
        public string empname { get; set; }
        public string deptname { get; set; }
        public string mobileno { get; set; }
        public decimal salary { get; set; }
        public void display()
        {
            Console.WriteLine("Employee Id:" + this.empid);
            Console.WriteLine("Employee Name:" + this.empname);
            Console.WriteLine("Employee Dept Name:" + this.deptname);
            Console.WriteLine("Employee Mobile No:" + this.mobileno);
            Console.WriteLine("Employee Salary:" + this.salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lst = new List<Employee>();
            lst.Add(new Employee { empid = 1, empname = "priyanka", deptname = "computer",mobileno="123456789", salary = 10789 });
            lst.Add(new Employee { empid = 2, empname = "prachi", deptname = "sales", mobileno = "896456789", salary = 44789 });
            lst.Add(new Employee { empid = 3, empname = "pranjal", deptname = "purchase", mobileno = "999456789", salary = 48789 });
            lst.Add(new Employee { empid = 4, empname = "prajkta", deptname = "mechanical", mobileno = "951456789", salary = 32789 });
            lst.Add(new Employee { empid = 5, empname = "sweety", deptname = "computer", mobileno = "987456789", salary = 25789 });
            lst.Add(new Employee { empid = 6, empname = "sonali", deptname = "sales", mobileno = "320456789", salary = 89789 });
            lst.Add(new Employee { empid = 7, empname = "guddi", deptname = "purchase", mobileno = "201456789", salary = 18789 });
            lst.Add(new Employee { empid = 8, empname = "vishakha", deptname = "mehanical", mobileno = "953456789", salary = 29789 });
            lst.Add(new Employee { empid = 9, empname = "shital", deptname = "electrical", mobileno = "846456789", salary = 60789 });
            lst.Add(new Employee { empid = 10, empname = "snheha", deptname = "computer", mobileno = "963456789", salary = 43789 });
            //var v = from t in lst
            //        where t.salary > 23000
            //        select t;

            //var v = from t in lst
            //        where t.empname.StartsWith("s")
            //        select t;
            //foreach (var temp in v)
            //{
            //    temp.display();
            //}
            //*************** Projection ********************
            //var v = from t in lst
            //        select new
            //        {
            //            t.empname,t.salary
            //        }; 
            //****************** orderby **********************
            //var v = from t in lst
            //        orderby t.empname descending
            //        select t;
            //var v = from t in lst
            //        orderby t.empname ascending
            //        select t;
            //foreach (var temp in v)
            //{
            //    Console.WriteLine("Employee Name:"+temp.empname);
            //    Console.WriteLine("Employee Salary:" + temp.salary);
            //}
            //************ grouping ***********************
            var v = from t in lst
                    group t by t.deptname
                    into g
                    select new
                    {
                        deptname = g.Key,
                        noofemployees = g.Count(),
                        totalsalary = g.Sum(p => p.salary),
                        maxsalary = g.Max(p => p.salary),
                        minsalary = g.Min(p => p.salary),
                        avgsalary = g.Average(p => p.salary)
                    };
            foreach (var temp in v)
            {
                Console.WriteLine("Employee Dept Name:" + temp.deptname);
                Console.WriteLine("Count of Employee:" + temp.noofemployees);
                Console.WriteLine("Employee Total Salary:" + temp.totalsalary);
                Console.WriteLine("Employee Max Salary:" + temp.maxsalary);
                Console.WriteLine("Employee Min Salary:" + temp.minsalary);
                Console.WriteLine("Employee Average Salary:" + temp.avgsalary);

            }

        }
    }
}
