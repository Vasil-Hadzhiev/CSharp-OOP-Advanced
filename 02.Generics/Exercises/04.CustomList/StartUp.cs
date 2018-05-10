namespace _04.CustomList
{
    using System;
    using Commands;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var commandInterpreter = new CommandInterpreter();

            while (input != "END")
            {
                commandInterpreter.ProcessCommand(input);
                input = Console.ReadLine();
            }
        }
    }
}