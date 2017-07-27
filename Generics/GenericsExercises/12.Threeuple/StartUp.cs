using System;

public class StartUp
{
    public static void Main()
    {
        var name = string.Empty;

        var firstInput = Console.ReadLine().Split();
        name = firstInput[0] + " " + firstInput[1];
        var address = firstInput[2];
        var town = firstInput[3];
        var firstGenericTuple = new GenericTuple<string, string, string>(name, address, town);
        Console.WriteLine(firstGenericTuple.ToString());

        var secondInput = Console.ReadLine().Split();
        name = secondInput[0];
        var litersOfBeer = int.Parse(secondInput[1]);
        var isDrunk = false;
        if (secondInput[2] == "drunk")
        {
            isDrunk = true;
        }
        else
        {
            isDrunk = false;
        }
        var secondGenericTuple = new GenericTuple<string, int, bool>(name, litersOfBeer, isDrunk);
        Console.WriteLine(secondGenericTuple.ToString());

        var thirdInput = Console.ReadLine().Split();
        name = thirdInput[0];
        var accountBalance = double.Parse(thirdInput[1]);
        var bankName = thirdInput[2];
        var thirdGenericTuple = new GenericTuple<string, double, string>(name, accountBalance, bankName);
        Console.WriteLine(thirdGenericTuple.ToString());
    }
}

