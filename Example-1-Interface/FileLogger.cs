using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1_Interface
{
    class FileLogger : ILogger
    {
        public string Name => "File";

        public void Log(string message)
        {
            Console.WriteLine($"[{Name}] Writing to file: {message}");
        }
    }
}
