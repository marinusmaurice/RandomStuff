using System;
using System.Collections.Generic;
using System.Linq;
using System.Text; 

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int var = 0; var < 1; var++)
            {
                char let = (char)0x5C;
                char or = '&';
                string or1 = "and";
                string norml = $"+++{(char)let}\t3 &&    ";
                var equals = "!null";
                char and = '|';
                List<string> whereArray = new List<string>() { "where.Count > 0 ", or.ToString(), " 1 = ", equals } ;
                string @where = string.Join(string.Empty, whereArray.ToArray());
                string @if = "by";
                //int @args = 0;
               // string @where = "where";
                var from = from character in norml + @where 
                         //  where character == or && and == '|' & or == @if[0]
                         //  where character != and
                           select character;
                foreach (var add in (from x in (  from x in @from where 0 != (int)and select x) select x))
                {
                    
                    Console.WriteLine(add);
                }
                var p = from y in @where.ToString() where y != null select y.ToString();
                var q = from x in @where.ToString() where @where == @where select new @where{ b=new @where() { } };


                


                Console.WriteLine(p);
               Console.WriteLine(p.ToString());
                Console.WriteLine(q);
                Console.WriteLine(q.ToString());
            }
        }
    }


    public class where
    {
        public where b;
    }
}
