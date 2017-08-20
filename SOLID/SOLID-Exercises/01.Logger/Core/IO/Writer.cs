using _01.LoggerProblem.Interfaces;
using System;

namespace _01.LoggerProblem.Core.IO
{
    public class Writer : IWriter
    {
        public void WriteLine(string content)
        {
            Console.WriteLine(content);
        }
    }
}
