using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pi_Threading
{
    public class FindPiThread
    {
        int DartNumber;
        int BoardHits;
        Random rand;

        public FindPiThread(int num)
        {
            DartNumber = num;
            BoardHits = 0;
            rand = new Random();
        }

        public void ThrowDarts()
        {
            for (int i = 0; i < DartNumber; i++)
            {
                double x = rand.NextDouble();
                double y = rand.NextDouble();

                if ((x * x) + (y * y) >= 1)
                {
                    BoardHits++;
                }
            }          
        }
    }
}
