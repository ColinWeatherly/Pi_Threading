/* Name: Colin Weatherly
 * Date: 3/10/2022
 * File: Program.cs
 * IDE: Visual Studio 2019
 */

using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pi_Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many throws do you want to make?");
            int NumThrows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many threads do you want?");
            int NumThreads = Convert.ToInt32(Console.ReadLine());

            List<Thread> ThreadList = new List<Thread>();
            List<FindPiThread> PiList = new List<FindPiThread>();

            for (int i = 0; i < NumThreads; i++)
            {
                FindPiThread FindPi = new FindPiThread(NumThrows);
                PiList.Add(FindPi);

                Thread PiThread = new Thread(new ThreadStart(FindPi.ThrowDarts));
                ThreadList.Add(PiThread);

                PiThread.Start();
                Thread.Sleep(16);
            }

            for (int i = 0; i < NumThreads; i++)
            {
                ThreadList[i].Join();
            }

            int InsideDarts = 0;
            for (int i = 0; i < NumThreads; i++)
            {
                InsideDarts += PiList[i].GetHits;
            }

            double PiEstimate = (4 * (Convert.ToDouble(InsideDarts)) / (NumThreads * NumThrows));
            Console.WriteLine("The Pi Estimate is " + PiEstimate);
            Console.ReadKey();
        }
    }
}
