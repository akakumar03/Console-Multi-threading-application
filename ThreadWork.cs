using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MultiThreadingConsole
{
    class ThreadWork
    {
        public void FirstCount()
        {

            for (int i = 0; i < 20; i++)
            {

                //Print the line
                Console.WriteLine("This is the {0} time I'm printing thread 1", i);
                //Sleep a bit
                Thread.Sleep(100);

            }
        }
        public void SecondCount()
        {

            for (int i = 0; i < 20; i++)
            {

                //Print the line
                Console.WriteLine("This is the {0} time I'm printing thread 2", i);
                //Sleep a bit
                Thread.Sleep(100);

            }
        }
    }
}
