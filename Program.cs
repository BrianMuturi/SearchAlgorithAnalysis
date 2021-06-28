using System;
using System.Diagnostics;
using System.Threading;

namespace SearchAlgorithAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 120, 101, 160, 250, 230, 190, 245, 210, 150, 211 };
            Console.WriteLine("Please enter the value you want to search:");
            int value = int.Parse(Console.ReadLine());
            int index= SimpleLinearSearch(arr, value);
            if(index<0)
            {
                Console.WriteLine($"Value not found!!");
            }
            else
            {
                Console.WriteLine($"The value has been found at {index} index");
            }
            ImprovedLinearSearch(arr, value);
            ImprovedLinearSearchWithSentinel(arr, value);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep(10000);
            stopWatch.Stop();
            // Get the elapsed time as a TimeSpan value.
            TimeSpan ts = stopWatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }

        private static void ImprovedLinearSearchWithSentinel(int[] arr, int x)
        {
            
        }

        private static void ImprovedLinearSearch(int[] arr, int x)
        {
          
        }

        private static int SimpleLinearSearch(int[] arr, int x)
        {
           for (int i=0; i<arr.Length; i++)
            {
                if(arr[i]==x)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
