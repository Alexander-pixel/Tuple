using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Tuple
{
  internal class Program
  {
      static (int, int) Mult_10(int a, int b)
      {
          return (a * 10, b * 10);
      }

      public static void Main(string[] args)
      {
          var res = Mult_10(12, 23);
          Console.WriteLine(res);
          Console.WriteLine($"a = {res.Item1} b = {res.Item2}");
          
          (int, int) res1 = Mult_10(24, 55);
          Console.WriteLine(res1);
          
          (int first, int second) res2 = Mult_10(11, 44);
          Console.WriteLine($"first = {res2.first} second = {res2.second}");
          
          int a = 5, b = 3;
          Console.WriteLine($"a = {a} b = {b}");
          (a, b) = (b, a);
          Console.WriteLine($"a = {a} b = {b}");
      }
  }
}