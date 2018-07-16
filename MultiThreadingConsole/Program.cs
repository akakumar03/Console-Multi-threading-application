using System;
using System.Threading;
namespace MultiThreadingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadWork threadWork = new ThreadWork(); //Accessing the other class
            Thread FirstThread = new Thread(new ThreadStart(threadWork.FirstCount));
            Thread SecondThread = new Thread(new ThreadStart(threadWork.SecondCount));
            FirstThread.Start();
            SecondThread.Start();
            Console.Read();
        }
       
    }
}


//Thread is a light weight process which helps in increasing the performance.