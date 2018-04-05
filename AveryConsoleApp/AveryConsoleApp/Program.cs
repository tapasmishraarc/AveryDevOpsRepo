using AveryBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AveryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Utility util = new Utility();
            int sum =util.Add(5, 6);
            Console.WriteLine(sum);

        }
    }
}
