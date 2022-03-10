/* Name: Colin Weatherly
 * Date: 3/10/2022
 * File: FindPiThread.cs
 * IDE: Visual Studio 2019
 */

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
            double x;
            double y;

            for (int i = 0; i < DartNumber; i++)
            {
                x = rand.NextDouble();
                y = rand.NextDouble();

                if ((x * x) + (y * y) <= 1.0)
                {
                    BoardHits++;
                }
            }          
        }
        public int GetHits
        {
            get => BoardHits;
        }
    }
}
