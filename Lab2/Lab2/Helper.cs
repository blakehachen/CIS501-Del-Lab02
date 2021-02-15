using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    public class Helper
    {
        public Helper(Manager myManager)
        {
            myManager.remove(this);
        }

        public void doWork()
        {

        }

        public void finished()
        {

        }

        
    }
}
