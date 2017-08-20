using _01.LoggerProblem.Interfaces;
using System;

namespace _01.LoggerProblem.Core.IO
{
    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
