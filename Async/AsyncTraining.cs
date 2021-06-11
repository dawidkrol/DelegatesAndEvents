using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    public class AsyncTraining
    {
        public static async Task zadanie(IProgress<int> progress)
        {
            for(int i = 0;i < 10;i++)
            {
                Console.WriteLine($"AsyncTraining: {i}");
                progress.Report(i*10);
                Thread.Sleep(100);
            }
        }
    }
}
