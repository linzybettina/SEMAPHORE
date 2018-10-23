using System;
using System.Threading;


class Semaphoredemo
    {
        static Semaphore semaphore = new Semaphore(5, 5);
        public static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                new Thread(Semaphoredemo.DoSomething).Start(i);


            }

        }
        static void DoSomething(object id)
        {
            Console.WriteLine(id +"Wants to access the Semaphore");
            semaphore.WaitOne();
            Console.WriteLine(id +"has succeeded to access the semaphore");
            Thread.Sleep(3000);
            Console.WriteLine(id +"is about to leave the semaphore");
            semaphore.Release();
            Console.ReadLine();

        }


    }

