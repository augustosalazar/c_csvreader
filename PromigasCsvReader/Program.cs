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

            //data = dataHolder.getAllData("hola");

            //if (data == null)
            //{
            //    Console.WriteLine("hola null ");
            //}

            data = dataHolder.getAllData("CARA_U1_P1");

            if (data == null)
            {
                Console.WriteLine("CARA_U1_P1 null ");
            } else
            {
                Console.WriteLine("CARA_U1_P1 found "+data.Count+ "  "+ dataHolder.getCurrentData("CARA_U1_P1"));

                foreach (string text in data)
                    Console.WriteLine(text);
            }


        }
    }
}
