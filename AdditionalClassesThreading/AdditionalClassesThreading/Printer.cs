using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;


namespace AdditionalClassesThreading
{
    //блокирует все , весь класс  [Synchronization]
    [Synchronization]
    public class Printer : ContextBoundObject
    {
        private object lockObject = new object();
        public void Print()
        {
            //1)) потоки работают как обчередь , блокировка метода
            lock (lockObject)
            { 
            for (int i = 0; i <10; i++)
            {
                Random random = new Random();
                Thread.Sleep(5 * random.Next(150));
                Console.WriteLine("работает поток номер - {0}", Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine(i);
            }
            }
            /* //тоже самое что (1) 
             Monitor.Enter(lockObject);
             try
             {
             for (int i = 0; i < 10; i++)
             {
                 Random random = new Random();
                 Thread.Sleep(5 * random.Next(150));
                 Console.WriteLine("работает поток номер - {0}", Thread.CurrentThread.ManagedThreadId);
                 Console.WriteLine(i);
             }
             }
             finally
             {
                 Monitor.Exit(lockObject);
             }*/
            //Semaphore лудчше не использовать 
            //Semaphore semaphore = new Semaphore(50, 3);
            
            /*for (int i = 0; i < 10; i++)
            {
                Random random = new Random();
                Thread.Sleep(5 * random.Next(150));
                Console.WriteLine("работает поток номер - {0}", Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine(i);
            }
            semaphore.WaitOne();*/

        }
    }
}
