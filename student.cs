using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    internal class student
    {
        string name = "ahmed";
        int age = 20;

        public override string ToString()
        {
            return $"Name: {name} , Age: {age}";
        }
    }
}
