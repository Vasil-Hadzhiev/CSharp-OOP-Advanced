using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GenericSwapMethodStrings
{
    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var elements = new List<Box<string>>();

            for (int i = 0; i < n; i++)
            {
                var box = new Box<String>(Console.ReadLine());

                elements.Add(box);
            }

            var indexes = Console.ReadLine().
                Split().
                Select(int.Parse).
                ToArray();

            var firstIndex = indexes[0];
            var secondIndex = indexes[1];

            Box<string>.Swap(elements, firstIndex, secondIndex);

            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }
        }
    }
}
