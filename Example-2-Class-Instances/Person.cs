using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2_Class_Instances
{
    public  class Person(string name, int age)
    {
        public string Name { get; set; } = name;
        public int Age { get; set;} = age;
    }
}
