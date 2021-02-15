using System;
using System.Collections.Generic;

namespace InterfacePart
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.work();
        }
    }
    
    public delegate void RemoveMethod(Helper h);

    public class Helper
    {

        public void remove(Helper h)
        {
            h.remove(this);
        }
        
        public Helper(RemoveMethod done)
        {
            done(this);
        }
        
        public void doWork()
        {
            Console.WriteLine("Working");
        }

        public void finished()
        {
            Console.WriteLine("Done..");
        }
    }

    public class Manager
    {
        private List<Helper> active = new List<Helper>();

        public void remove(Helper h)
        {
            active.Remove(h);
            Console.WriteLine("Removing Helper from Active list");
            h.finished();
        }

        public Helper requestHelp()
        {
            Console.WriteLine("Client requesting help.");
            Helper h = new Helper(remove);
            Console.WriteLine("Created Helper");
            active.Add(h);
            Console.WriteLine("Adding Helper to Active list");
            return h;
        }
    }

    public class Client
    {
        public Manager mgr = new Manager();

        public void work()
        {
            Console.WriteLine("Requesting help to Manager");
            Helper h = mgr.requestHelp();
            h.doWork();
            h.finished();
            Console.WriteLine("I am a happy client.");
        }
    }
}
