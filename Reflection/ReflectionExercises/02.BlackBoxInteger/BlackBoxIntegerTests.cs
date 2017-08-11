using System;
using System.Linq;
using System.Reflection;

namespace _02.BlackBoxInteger
{
    public class BlackBoxIntegerTests
    {
        private const BindingFlags NonPublicFlags = BindingFlags.Instance | BindingFlags.NonPublic;

        public static void Main()
        {
            var blackBoxType = typeof(BlackBoxInt);

            //create private constructor instance
            //var blackBoxCtor = blackBoxType.GetConstructor(
            //    BindingFlags.NonPublic | BindingFlags.Instance, Type.DefaultBinder, new Type[] { }, null);

            //create private constructor instance
            var blackBoxInstance = (BlackBoxInt)Activator.CreateInstance(blackBoxType, true);

            while (true)
            {
                var tokens = Console.ReadLine().Split('_');

                var methodName = tokens[0];

                if (methodName == "END")
                {
                    break;
                }

                var value = int.Parse(tokens[1]);

                blackBoxType.GetMethod(methodName, NonPublicFlags).
                    Invoke(blackBoxInstance, new object[] { value });

                var innerStateValue = blackBoxType.
                    GetFields(NonPublicFlags).
                    First().
                    GetValue(blackBoxInstance);

                Console.WriteLine(innerStateValue);
            }
        }
    }
}
