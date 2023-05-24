using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            Sum(n);
            Console.ReadKey();  
        }

        static void Sum(int n)
        {
            int s = 0;
            for (int i = 0; i < n; i++) 
            {
                s += 1;
                Thread.Sleep(10);
            }
            Console.WriteLine(s);
        }

        static async void SumAsync(int n)
        {
            await Task.Run(()=>Sum(n));
        }
    }
}
