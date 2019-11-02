using System;
using System.Collections.Generic;

namespace PromigasCsvReader
{
    public class Variable
    {
        public string name;
        public List<string> values = new List<string>();
        public Variable(string name, List<string> values)
        {
            this.name = name;
            this.values = values;
        }

    }
}
