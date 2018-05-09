namespace _04.Telephony
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] { ' ' });
            var urls = Console.ReadLine().Split(new[] { ' ' });

            var phone = new Smartphone(numbers, urls);

            Console.Write(phone.ToString());
        }
    }
}