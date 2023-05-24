using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Action action = new Action(Method1);
            //Task task=new Task(action);
            //task.Start();

            //Task task1=new Task(Method1);


           int r= MethodAsync().Result;

            Method2(100);


            Console.ReadKey();
        }
        static async Task<int> MethodAsync()
        {
            Console.WriteLine("MethodAsync начал работату");
            int result=await Task.Run(() => Method3());
            Console.WriteLine("MethodAsync окончил работату");
            return result;
        }
        static void Method1()
        {
            Console.WriteLine("Method1 начал работу");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Method1 выводит счётчик = {i}");
                Thread.Sleep(100);
            }
            Console.WriteLine("Method1 окончил работу");
        }
        static void Method2(int a)
        {
            int n = (int)a;
            Console.WriteLine("Method2 начал работу");
            for (int i = n; i < n + 10; i++)
            {
                Console.WriteLine($"Method2 выводит счётчик = {i}");
                Thread.Sleep(800);
            }
            Console.WriteLine("Method2 окончил работу");
        }
        static int Method3()
        {
            Console.WriteLine("Method3 начал работу");
            int S = 0;
            for (int i = 0; i < 10; i++)
            {
                S += i;
                Thread.Sleep(500);
            }
            Console.WriteLine("Method3 окончил работу");
            return (S);
        }
    }
}
