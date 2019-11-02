using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;

namespace PromigasCsvReader
{
    public class DataHolder
    {
        List<Variable> theData;

        public DataHolder()
        {
            theData = new List<Variable>();
        }

        public void addVariable(Variable variable)
        {
            theData.Add(variable);
        }

        public void loadData()
        {

            var path = @"/Users/augustosalazar/Projects/PromigasCsvReader/PromigasCsvReader/HistoryData.csv";
            Console.WriteLine("Hello World!");
            List<string> values = new List<string>();

            using (TextFieldParser csvParser = new TextFieldParser(path))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();

                while (!csvParser.EndOfData)
                {
                    // Read current line fields, pointer moves to the next line.
                    string[] fields = csvParser.ReadFields();
                    string Name = fields[0];
                    values.Clear();
                    for (int i = 1; i < fields.Length; i++)
                    {
                        values.Add(fields[i]);
                    }
                    Console.WriteLine("New variable " + Name+ "  "+ values.Count);
                    addVariable(new Variable(Name, values));

                }
            }
            Console.WriteLine("Total " + count());


        }

        public int count()
        {
            return theData.Count;
        }

        public List<string> getAllData(string variableName)
        {
            List<string> data = new List<string>();

            foreach (Variable variable in theData){
                if (variableName.Equals(variable.name))
                {
                    data = variable.values;
                    return data;
                }
            }

            return null;
        }

        public string getCurrentData(string variableName)
        {
            string data;

            foreach (Variable variable in theData)
            {
                if (variableName.Equals(variable.name))
                {
                    data = variable.values[0];
                    return data;
                }
            }

            return null;
        }
    }
}
