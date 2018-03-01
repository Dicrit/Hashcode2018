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

            Array.ForEach(FileManager.GetIntArray(FileManager.getAllLines(0)[0]), i =>
            Console.WriteLine(i + " " + i.GetType()));
            var writer = FileManager.createOutput();
            writer.WriteLine("acdc");
            writer.Close();
            Console.ReadKey();
        }
    }
}
