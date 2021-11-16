using System;
using System.Collections.Generic;
using System.IO;


namespace jemsunlucky
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var stream = Console.OpenStandardInput())
            {
                using (var reader = new StreamReader(stream))
                {
                    var expReader = new Expreader(reader);
                    string token;
                    while ((token = expReader.Read()) != null)
                    {
                        Console.WriteLine(token);
                    }

                }
            }
        }
    }
}
