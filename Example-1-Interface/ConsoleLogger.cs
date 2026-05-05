using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1_Interface
{
    class ConsoleLogger : ILogger
    {
        public string Name => "Console";

        public void Log(string message)
        {
            Console.WriteLine($"[{Name}] {message}");
        }
    }
}
