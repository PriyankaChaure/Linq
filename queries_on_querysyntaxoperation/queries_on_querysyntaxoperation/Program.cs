using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace queries_on_querysyntaxoperation
{
    public class project
    {
        public Int64 ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string city { get; set; }
        public decimal totalbudget { get; set; }
        public decimal allocatedbudget { get; set;}
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
            lst.Add(new project { ProjectId = 1, ProjectName = "computer", city = "pune", totalbudget = 45000, allocatedbudget = 48000});
            lst.Add(new project { ProjectId = 2, ProjectName = "sales", city = "pune", totalbudget = 43000, allocatedbudget = 45000 });
            lst.Add(new project { ProjectId = 3, ProjectName = "acountant", city = "mumbai", totalbudget = 41000, allocatedbudget = 45000 });
            lst.Add(new project { ProjectId = 4, ProjectName = "purchase", city = "delhi", totalbudget = 35000, allocatedbudget = 40000 });
            lst.Add(new project { ProjectId = 5, ProjectName = "computer", city = "hydrabad", totalbudget = 38000, allocatedbudget = 40000 });
            lst.Add(new project { ProjectId = 6, ProjectName = "sales", city = "noida", totalbudget = 15000, allocatedbudget = 20000 });
            lst.Add(new project { ProjectId = 7, ProjectName = "acountant", city = "pune", totalbudget = 25000, allocatedbudget = 27000 });
            lst.Add(new project { ProjectId = 8, ProjectName = "purchase", city = "mumbai", totalbudget = 25000, allocatedbudget = 65000 });
            lst.Add(new project { ProjectId = 9, ProjectName = "computer", city = "delhi", totalbudget = 57000, allocatedbudget = 60000 });
            lst.Add(new project { ProjectId = 10, ProjectName = "sales", city = "noida", totalbudget = 43000, allocatedbudget = 45000 });
            lst.Add(new project { ProjectId = 11, ProjectName = "acountant", city = "chennai", totalbudget = 49000, allocatedbudget = 50000 });
            lst.Add(new project { ProjectId = 12, ProjectName = "purchase", city = "pune", totalbudget = 40000, allocatedbudget = 43000 });
            lst.Add(new project { ProjectId = 13, ProjectName = "computer", city = "mumbai", totalbudget = 35000, allocatedbudget = 76000 });
            lst.Add(new project { ProjectId = 14, ProjectName = "sales", city = "pune", totalbudget = 13000, allocatedbudget = 15000 });
            //*********************************************************************

            //var v= from t in lst
            //       where t.city=="mumbai"
            //       select t;
            //foreach(var temp in v)
            //{
            //    Console.WriteLine("project id:" + temp.ProjectId);
            //    Console.WriteLine("Project Name:" + temp.ProjectName);
            //    Console.WriteLine("city:" + temp.city);
            //    Console.WriteLine("total budget:" + temp.totalbudget);
            //    Console.WriteLine("allocated budget:" + temp.allocatedbudget);
            //}

            //******************************************************************

            //var v = from t in lst
            //        where t.city == "pune"
            //        select new
            //        {
            //            t.ProjectName,
            //            t.city
            //        };

            //foreach (var temp in v)
            //{
            //    Console.WriteLine("Project Name:" + temp.ProjectName);
            //    Console.WriteLine("city:" + temp.city);
            //}

            //****************************************************************

            //var v = from t in lst
            //        where t.city == "pune" && t.allocatedbudget>30000
            //        select new
            //        {
            //            t.ProjectName,
            //            t.allocatedbudget,
            //            t.city
            //        };
            //foreach (var temp in v)
            //{
            //    Console.WriteLine("Project Name:" + temp.ProjectName);
            //    Console.WriteLine("city:" + temp.city);
            //    Console.WriteLine("allocated budget:" + temp.allocatedbudget);
            //}

            //***********************************************************************

            //var v = from t in lst
            //        where t.city == "mumbai" && t.totalbudget > 10000 && t.totalbudget < 40000
            //        select new
            //        {
            //            t.ProjectName,
            //            t.totalbudget,
            //            t.city
            //        };
            //foreach (var temp in v)
            //{
            //    Console.WriteLine("Project Name:" + temp.ProjectName);
            //    Console.WriteLine("city:" + temp.city);
            //    Console.WriteLine("total budget:" + temp.totalbudget);
            //}

            //*************************************************************************************

            var v = from t in lst
                    group t by t.city
                    into g
                    select new
                    {
                        city=g.Key,
                        allocatedbudget=g.Sum(p=>p.allocatedbudget),
                        totalbudget=g.Sum(p=>p.totalbudget),
                        minbudget=g.Min(p=>p.totalbudget),
                        maxbudget=g.Max(p=>p.totalbudget),
                        avgbudget=g.Average(p=>p.totalbudget)
                       
                    };
            foreach (var temp in v)
            {
                Console.WriteLine("city:" + temp.city);
                Console.WriteLine("total budget:" + temp.totalbudget);
                Console.WriteLine("allocated budget:" + temp.allocatedbudget);
                Console.WriteLine("max budget:" + temp.maxbudget);
                Console.WriteLine("min budget:" + temp.minbudget);
                Console.WriteLine("average budget:" + temp.avgbudget);
                Console.WriteLine("****************************************" );

            }
        }
    }
}
