using System;
using System.Collections.Generic;

namespace PromigasCsvReader
{
    public class Data
    {
        public string name;
        public List<string> values = new List<string>();
        public Data(string name, List<string> values)
        {
            this.name = name;
            this.values = values;
        }
    }
}
