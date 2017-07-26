using System;

public class CommandInterpreter
{
    private readonly CustomList<string> customList;

    public CommandInterpreter()
    {
        this.customList = new CustomList<string>();
    }

    public void ProcessCommand(string inputLine)
    {
        var tokens = inputLine.Split();

        var command = tokens[0];
        var element = string.Empty;
        var index = 0;
        var index1 = 0;
        var index2 = 0;

        switch (command)
        {
            case "Add":
                element = tokens[1];
                customList.Add(element);
                break;
            case "Remove":
                index = int.Parse(tokens[1]);
                customList.Remove(index);
                break;
            case "Contains":
                element = tokens[1];
                Console.WriteLine(customList.Contains(element));
                break;
            case "Swap":
                index1 = int.Parse(tokens[1]);
                index2 = int.Parse(tokens[2]);
                customList.Swap(index1, index2);
                break;
            case "Greater":
                element = tokens[1];
                Console.WriteLine(customList.CountGreaterThan(element));
                break;
            case "Max":
                Console.WriteLine(customList.Max());
                break;
            case "Min":
                Console.WriteLine(customList.Min());
                break;
            case "Print":
                foreach (var item in customList.Elements)
                {
                    Console.WriteLine(item);
                }
                break;
        }
    }
}

