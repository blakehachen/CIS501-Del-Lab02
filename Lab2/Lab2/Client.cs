using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class Client
    {
        Manager mgr;
        
        public void work()
        {
            Console.WriteLine("Requesting help to Manager");
            Helper h = mgr.requestHelp();
            h.doWork();
            h.finished();
        }
    }
}
