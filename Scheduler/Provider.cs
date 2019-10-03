using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scheduler
{
    public class Provider
    {
        public int GetRandomNum()
        {
            Random random = new Random();
            int randomNum = random.Next(1, 100);
            return randomNum;
        }
    }
}
