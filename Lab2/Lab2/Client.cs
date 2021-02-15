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
            Helper h = mgr.requestHelp();
            h.doWork();
            h.finished();
        }
    }
}
