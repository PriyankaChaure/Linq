using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link_Extension_method
{
    public class project
    {
        public Int64 ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string city { get; set; }
        public decimal totalbudget { get; set; }
        public decimal allocatedbudget { get; set; }
        public void display()
        {
            Console.WriteLine("Project id:" + this.ProjectId);
            Console.WriteLine("Project name:" + this.ProjectName);
            Console.WriteLine("City Name:" + this.city);
            Console.WriteLine("Total Budget:" + this.totalbudget);
            Console.WriteLine("Allocated Budget:" + this.allocatedbudget);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<project> lst = new List<project>();
            lst.Add(new project { ProjectId = 1, ProjectName = "computer", city = "pune", totalbudget = 45000, allocatedbudget = 48000 });
            lst.Add(new project { ProjectId = 2, ProjectName = "sales", city = "pune", totalbudget = 43000, allocatedbudget = 45000 });
            lst.Add(new project { ProjectId = 3, ProjectName = "acountant", city = "mumbai", totalbudget = 41000, allocatedbudget = 45000 });
            lst.Add(new project { ProjectId = 4, ProjectName = "purchase", city = "delhi", totalbudget = 35000, allocatedbudget = 40000 });
            lst.Add(new project { ProjectId = 5, ProjectName = "computer", city = "hydrabad", totalbudget = 38000, allocatedbudget = 40000 });
            lst.Add(new project { ProjectId = 6, ProjectName = "sales", city = "noida", totalbudget = 15000, allocatedbudget = 20000 });
            lst.Add(new project { ProjectId = 7, ProjectName = "acountant", city = "pune", totalbudget = 25000, allocatedbudget = 27000 });
            lst.Add(new project { ProjectId = 8, ProjectName = "purchase", city = "mumbai", totalbudget = 25000, allocatedbudget = 65000 });
            lst.Add(new project { ProjectId = 9, ProjectName = "computer", city = "delhi", totalbudget = 57000, allocatedbudget = 60000 });
            lst.Add(new project { ProjectId = 10, ProjectName = "sales", city = "noida", totalbudget = 42000, allocatedbudget = 45000 });
            lst.Add(new project { ProjectId = 11, ProjectName = "acountant", city = "chennai", totalbudget = 49000, allocatedbudget = 50000 });
            lst.Add(new project { ProjectId = 12, ProjectName = "purchase", city = "pune", totalbudget = 40000, allocatedbudget = 43000 });
            lst.Add(new project { ProjectId = 13, ProjectName = "computer", city = "mumbai", totalbudget = 35000, allocatedbudget = 76000 });
            lst.Add(new project { ProjectId = 14, ProjectName = "sales", city = "pune", totalbudget = 13000, allocatedbudget = 15000 });

            // var v=lst.First();
            // var v = lst.FirstOrDefault(p => p.ProjectName == "sales");

            //var v = lst.Single(p => p.ProjectName == "computer");//Multiple project name of computer occurs thats why its getting exception
            // var v = lst.Single(p => p.ProjectId==10);
            // var v = lst.SingleOrDefault(p => p.ProjectId == 10);
            //var v = lst.SingleOrDefault(p => p.ProjectName == "computer");
            //if (v!=null)
            //{
            //    v.display();
            //}
            //else
            //{
            //    Console.WriteLine("matching data not present in the list!!!!");
            //}

            //var v = lst.Where(p => p.ProjectName == "acountant");
            //var v = lst.Where(p => p.ProjectName == "Hr");//it will get you null if match not found
            //foreach (project temp in v)
            //{
            //    temp.display();
            //}
            //var v = lst.Where(p => p.ProjectId == 5);
            //var r = v.FirstOrDefault();
            //r.display();

            // var v = lst.OrderBy(p => p.totalbudget);
            // var v = lst.OrderBy(p => p.totalbudget).OrderBy(p=>p.ProjectName);
            // var v = lst.OrderByDescending(p => p.totalbudget);

            //var v = lst.Take(3);
            //var v = lst.Skip(3);

            //var v = lst.Skip(3).Take(4);

            //var v = lst.OrderByDescending(p => p.totalbudget).Take(2);
            //var v = lst.OrderByDescending(p => p.totalbudget).Skip(2).Take(2);
            //foreach (project temp in v)
            //{
            //    temp.display();
            //}

            //Console.WriteLine("Count is:" + lst.Count());
            //Console.WriteLine("Count is:" + lst.Count(p=>p.ProjectName=="computer"));
            //Console.WriteLine("Total allocated budget:" + lst.Sum(p=>p.allocatedbudget));
            //Console.WriteLine("Min budget:" + lst.Min(p => p.totalbudget));
            //Console.WriteLine("Max budget:" + lst.Max(p => p.totalbudget));
            //Console.WriteLine("average budget:" + lst.Average(p => p.totalbudget));

            //if(lst.Any(p=>p.ProjectName=="computer"))
            //if (lst.Any(p => p.ProjectName == "Hr"))
            //{
            //    Console.WriteLine("record found!!!");
            //}
            //else
            //{
            //    Console.WriteLine("record not found!!!");
            //}

            //string[] names = { "priya", "sweety", "guddi", "priya", "vishakha", "sweety" };
            //var v = names.Distinct();

            //string[] arr1 = { "pravin", "deepak", "shrikant", "mahendra" };
            //string[] arr2 = { "pravin","shrikant","ashok","ankit","sandip"};
            //// var v = arr1.Intersect(arr2);
            //var v = arr1.Union(arr2);
            //foreach(string temp in v)
            //{
            //    Console.WriteLine(temp);
            //}

            //Combination of query syntax and extension method

            //var v = (from t in lst
            //         where t.ProjectName == "computer"
            //         select t).Skip(1).Take(2);
            //foreach (project temp in v)
            //{
            //    temp.display();
            //}

            var v = (from t in lst.Where(p => p.ProjectName == "sales") select t).OrderBy(p => p.totalbudget).Skip(1).Take(2);
            foreach (project temp in v)
            {
                temp.display();
            }
        }
    }
}
