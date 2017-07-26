using System;

public class StartUp
{
    public static void Main()
    {
        var interpreter = new CommandInterpreter();

        while (true)
        {
            var inputLine = Console.ReadLine();

            if (inputLine == "END")
            {
                break;
            }

            interpreter.ProcessCommand(inputLine);
        }
    }
}

