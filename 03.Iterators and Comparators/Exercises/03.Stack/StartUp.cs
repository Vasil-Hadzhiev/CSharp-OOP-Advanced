namespace _03.Stack
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            CustomStack<string> customStack = new CustomStack<string>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                var tokens = input.
                    Split(new char[] { ' ', ',' },
                    StringSplitOptions.RemoveEmptyEntries).
                    ToArray();

                var command = tokens[0];

                switch (command)
                {
                    case "Push":
                        var elements = tokens.Skip(1).Take(tokens.Length - 1).ToList();
                        for (int i = 0; i < elements.Count; i++)
                        {
                            customStack.Push(elements[i]);
                        }
                        break;
                    case "Pop":
                        try
                        {
                            customStack.Pop();
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                }
            }

            foreach (var item in customStack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in customStack)
            {
                Console.WriteLine(item);
            }
        }
    }
}