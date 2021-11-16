using System;
using System.IO;

namespace kcalc
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
