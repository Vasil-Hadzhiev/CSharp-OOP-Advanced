using System;

public class Engine
{
    public Engine()
    {

    }

    public void Run()
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

