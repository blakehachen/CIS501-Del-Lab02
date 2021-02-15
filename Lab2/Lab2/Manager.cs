using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class Manager
    {
        private List<Helper> active;

        public void remove(Helper h)
        {
            active.Remove(h);
            h.finished();
        }

        public Helper requestHelp()
        {
            Helper h = new Helper(this);
            active.Add(h);
            return h;
        }
    }
}
