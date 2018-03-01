using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCodeQuali_2018
{
    class Program
    {

        static void Main()
        {
            Simulation simulation = new Simulation(0);
            simulation.Calculate();
            simulation.Output();

            Console.WriteLine("finish");
            Console.ReadKey();
        }
    }
}
