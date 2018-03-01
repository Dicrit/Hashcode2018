using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace HashCodeQuali_2018
{
    class Program
    {

        static void Main()
        {
            Stopwatch sw = new Stopwatch();

            for (int i = 0; i < 5; i++)
            {
                sw.Restart();
                Simulation simulation = new Simulation(i);
                simulation.Calculate();
                simulation.Output("v11");
                Console.WriteLine("calculated " + i + " time: "+ sw.Elapsed );
            }

            Console.WriteLine("finish");
            Console.ReadKey();
        }
    }
}
