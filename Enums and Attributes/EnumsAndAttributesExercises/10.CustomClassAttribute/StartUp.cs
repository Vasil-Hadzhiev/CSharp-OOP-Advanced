using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CustomClassAttribute
{
    [MyCustom("Pesho", 3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", "Pesho", "Svetlio")]
    public class StartUp
    {
        public static void Main()
        {
            var attr = (MyCustomAttribute)typeof(StartUp).GetCustomAttributes(false).First();

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                switch (command)
                {
                    case "Author":
                        Console.WriteLine($"Author: {attr.Author}");
                        break;
                    case "Revision":
                        Console.WriteLine($"Reiviosn: {attr.Revision}");
                        break;
                    case "Description":
                        Console.WriteLine($"Class description: {attr.Description}");
                        break;
                    case "Reviewers":
                        Console.WriteLine($"Reviewers: {string.Join(", ", attr.Reviewers)}");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
