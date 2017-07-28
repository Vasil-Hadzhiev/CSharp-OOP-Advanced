using System;
using System.Linq;

namespace _01.ListyIterator
{
    public class StartUp
    {
        public static void Main()
        {
            var create = Console.ReadLine().Split();
            var elements = create.Skip(1).Take(create.Length - 1).ToList();

            var listyIterator = new ListyIterator<string>(elements);

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                switch (command)
                {
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "Print":
                        try
                        {
                            listyIterator.Print();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                }
            }
        }
    }
}
