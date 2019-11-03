using System;
using System.Collections.Generic;



namespace PromigasCsvReader
{
    class Program
    {
        static void Main(string[] args)
        {
            DataHolder dataHolder = new DataHolder();

            dataHolder.loadData();

            List<string> data;

            data = dataHolder.getAllData("CARA_U1_P1");

            if (data == null)
            {
                Console.WriteLine("CARA_U1_P1 null ");
            } else
            {
                Console.WriteLine("CARA_U1_P1 found "+data.Count+ "  "+ dataHolder.getCurrentData("CARA_U1_P1"));

                int c = 0;
                foreach (string text in data)
                {
                    c++;
                    Console.WriteLine(text);
                    if (c == 10)
                    {
                        break;
                    }
                }
            }


        }
    }
}
