using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorApp
{
    public class Helper
    {
        public static int getRandom(int max)
        {
            Random rnd = new Random();
            return rnd.Next(1, max + 1);
        }

        public static int getRandom(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max + 1);
        }
    }
}
