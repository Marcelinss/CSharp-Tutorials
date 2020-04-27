using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharp_Tutorials
{
    class Yield
    {
        public static void Main(string[] args)
        {

            Stopwatch NormalMethodExecutionTime = new Stopwatch();
            NormalMethodExecutionTime.Start();

            foreach (int i in GetNormalEvenNumbers())
            {
                Console.WriteLine(i);
            }
            NormalMethodExecutionTime.Stop();
            Console.WriteLine("Time taken for GetNormalEvenNumbers is " + NormalMethodExecutionTime.Elapsed);

            Stopwatch YieldMethodExecutionTime = new Stopwatch();
            YieldMethodExecutionTime.Start();
            foreach (int i in GetYieldEvenNumbers())
            {
                Console.WriteLine(i);
            }
            YieldMethodExecutionTime.Stop();
            Console.WriteLine("Time taken for GetYieldEvenNumbers is " + YieldMethodExecutionTime.Elapsed);
            Console.ReadLine();
        }

        static IEnumerable<int> GetYieldEvenNumbers()
        {
            for(int i=0;i<10;i++)
            {                
                if(i%2==0)
                {
                    yield return i;
                }
            }
        }

        static IEnumerable<int> GetNormalEvenNumbers()
        {
            List<int> lstEven = new List<int>();
            for (int i = 0; i < 10; i++)
            {

                if (i % 2 == 0)
                {
                    lstEven.Add(i);
                }
            }

            return lstEven;
        }
    }
}
