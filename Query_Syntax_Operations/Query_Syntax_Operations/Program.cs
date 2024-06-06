using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Query_Syntax_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 20, 30, 80, 90, 56, 46, 37 };
            //******** Selection **************
            //var v= from t in num select t;
            //********** Filteration ****************

            //var v = from t in num
            //            //where t%2==0
            //        where t % 2 == 0 && t > 50
            //        select t;
            //foreach (int temp in v)
            //{
            //    Console.WriteLine(temp);
            //}
            string[] names = { "suhani", "tejaswini", "priyanka", "shubhangi", "Anannya", "Anu","yash" };
            //************display all names from list**************
            //var v = from t in names
            //        select t;
            //************ start with 'su' ************************
            //var v = from t in names
            //        where t.StartsWith("su")
            //        select t;
            //*************** whos contains 't' *********************
            //var v = from t in names
            //        where t.Contains('t')
            //        select t;
            //************* end with 'sh' *******************
            //var v = from t in names
            //        where t.EndsWith("sh")
            //        select t;
            //************* start with 'A' and greater then 5 character************
            var v = from t in names
                    where t.StartsWith("A") && t.Length>5
                    select t;
            foreach (string temp in v)
            {
                Console.WriteLine(temp);
            }
        }
    }
}
