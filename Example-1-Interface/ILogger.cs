using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1_Interface
{
    interface ILogger
    {
        void Log(string message);
        string Name { get; }
    }
}
