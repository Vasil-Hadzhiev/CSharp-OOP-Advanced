namespace _03.Ferrari
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var driver = Console.ReadLine();
            var ferrari = new Ferrari(driver);
            Console.WriteLine(ferrari.ToString());

            var ferrariName = typeof(Ferrari).Name;
            var iCarInterfaceName = typeof(ICar).Name;

            bool isCreated = typeof(ICar).IsInterface;
            if (!isCreated)
            {
                throw new Exception("No interface ICar was created");
            }
        }
    }
}