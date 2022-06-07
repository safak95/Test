# Test

using System;
using System.Linq;

namespace HeapSortDemo
{
    public class Test
    {
        public static int FindResult(int[] array)
        {
            int totalNumbers = array.Distinct().Count();
            int[] numberOfConflicts = new int[totalNumbers];
            for (int i = 0; i < array.Length; i++)
            {
                int number = array[i];
                numberOfConflicts[number - 1]++;
            }
            return numberOfConflicts.ToList().IndexOf(numberOfConflicts.Max()) + 1;
        }

        public static void Main()
        {
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            if (arrayLength < 5 || arrayLength > 200000)
            {
                Console.WriteLine("Dizi uzunluğu 5 ile 200.000 arasında olmalıdır. Program sonlandırılıyor.");
                return;
            }

            int[] wolfs = new int[arrayLength];
            string input = Console.ReadLine();
            input = input.Trim();
            input = input.Replace(" ", string.Empty);
            int[] validNumbers = new int[5] { 1, 2, 3, 4, 5 };

            if (input.Length != arrayLength)
            {
                Console.WriteLine("Dizi uzunluğu doğru değil. Program sonlandırılıyor.");
                return;
            }

            for (int i = 0; i < arrayLength; i++)
            {
                var isNumeric = int.TryParse(input[i].ToString(), out int parsed);

                if (!isNumeric)
                {
                    Console.WriteLine("Sayı girmelisiniz. Program sonlandırılıyor.");
                    return;
                }

                if (!validNumbers.Contains(parsed))
                {
                    Console.WriteLine("Elemanlar 1 ile 5 arasında olmalıdır. Program sonlandırılıyor.");
                    return;
                }

                wolfs[i] = parsed;
            }
            Console.WriteLine(FindResult(wolfs));
        }
    }
}
