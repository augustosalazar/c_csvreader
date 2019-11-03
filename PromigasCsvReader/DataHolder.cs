using System;
using System.Collections.Generic;
using System.IO;

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
            //string line;
            List<string> values = new List<string>();
            List<string> resLines = new List<string>();
            //System.IO.StreamReader file = new System.IO.StreamReader(@"C:\temp\HistoryData.csv");
            //while ((line = file.ReadLine()) != null)

            var strLines = File.ReadLines(@"C:\temp\HistoryData.csv");
            foreach (var line in strLines)

            {
                var res = line.Split(new char[] { ',' });

                string Name = res[0];
                values.Clear();
                for (int i = 1; i < res.Length; i++)
                {
                    values.Add(res[i]);
                }
                //Console.WriteLine("name " + Name +"  "+ values[0]);
                addVariable(new Variable(Name, values));

            }

            //Console.WriteLine("Total " + count());
        }
        

        public int count()
        {
            return theData.Count;
        }

        public List<string> getHistory(string variableName,int type)
        {
            int limit = 1;
            List<string> data = new List<string>();
            switch (type)
            {
                case 0:
                    limit = 10;
                    break;

                case 1:
                    limit = 10;
                    break;

                case 2:
                    limit = 10;
                    break;

            }

            foreach (Variable variable in theData)
            {
                if (variableName.Equals(variable.name))
                {
                    for (int i = 1; i <= limit; i++)
                    {
                        data.Add(variable.values[i]);
                    }
                    return data;
                }
            }

            for (int i = 1; i <= limit; i++)
            {
                data.Add("-1");
            }
            return data;
        }


        public string getCurrentData(string variableName)
        {
            string data;

            foreach (Variable variable in theData)
            {
                if (variableName == variable.name)
                {
                    data = variable.values[0];
                    return data;
                }
            }

            return "-1";
        }
    }




}
