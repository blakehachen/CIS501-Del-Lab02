using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class Manager
    {
        private List<Helper> active = new List<Helper>();

        public void remove(Helper h)
        {
            Console.WriteLine("Removing Helper from Active list");
            active.Remove(h);
            h.finished();
        }

        public Helper requestHelp()
        {
            Console.WriteLine("Client requesting Help");
            Helper h = new Helper(this);
            Console.WriteLine("Created helper");
            active.Add(h);
            Console.WriteLine("Adding helper to active list.");
            return h;
        }
    }
}
