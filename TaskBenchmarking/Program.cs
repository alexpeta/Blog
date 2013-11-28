using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskBenchmarking
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch sw = new Stopwatch();
            Console.WriteLine("Press any key to start test...");
            Console.ReadLine();
            BenchmarkMethod1();

            BenchmarkMethod2();
            Console.ReadLine();
        }


        public async static void BenchmarkMethod1()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            await TaskToRun3000();
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }
        public async static void BenchmarkMethod2()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 3000; i++)
            {
                Action a = () =>
                {
                    System.Threading.Thread.Sleep(1);
                };
                await Task.Run(a);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.WriteLine("finished.");
        }


        private static async Task TaskToRun3000()
        {
            Action a = () =>
            {
                System.Threading.Thread.Sleep(3000 * 1);
            };
            await Task.Run(a);
        }
    }
}
