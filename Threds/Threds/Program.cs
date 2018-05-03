using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threds
{
    class Program
    {
        //блакирует(остонавить) основной поток 
        private static AutoResetEvent autoResetEvent = new AutoResetEvent(false);
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ThreadStart(PrintHello));
            Thread parametrizedthread = new Thread(new ParameterizedThreadStart(Sum));

            parametrizedthread.IsBackground = true;

            thread.Start();
            parametrizedthread.Start(new SumArgs { FirstNamber=1,SecondNamber=3});

            autoResetEvent.WaitOne();

            Console.WriteLine("work main thread the end");
            Console.ReadLine();
        }
        //обяз void //нет параметра для threadStart
        static void PrintHello()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Hello");
            autoResetEvent.Set();
            
        }
        //обяз void
        //обяз 1 object как параметр (аргумент)
        static void Sum(object args)
        {
           SumArgs convertedArgs = args as SumArgs;
           Console.WriteLine(convertedArgs.FirstNamber + convertedArgs.SecondNamber);
        }
    }
}
