using System;
using System.Collections.Generic;

namespace PromigasCsvReader
{
    public class Variable
    {
        public string name;
        public List<string> values;
        public Variable(string name, List<string> value)
        {
            values = new List<string>();
            this.name = name;
            foreach (string t in value)
            {
                this.values.Add(t);
            }
            
            //Console.WriteLine("Variable constructor " + name + " " + values[0]);
        }

    }
}
