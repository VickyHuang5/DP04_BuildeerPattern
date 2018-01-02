using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Director director = new Director();
            Builder AsusComputer = new AsusComputerBuilder();
            Builder HpComputer = new HpComputerBuilder();

            director.Construct(AsusComputer, args);
            Computer productA = AsusComputer.GetComputer();
            productA.Show();

            Console.Read();
        }
    }
}
