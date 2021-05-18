using System;
using System.Collections.Generic;
using System.Linq;

namespace kontrolnayarabota2
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = GenerateLists(10, 5);

            // обьединение и выбор 5 элементов
            var sequence = ListSequence(list, 5);

            foreach (var n in sequence)
            {
                Console.Write(n + " ");
            }

            Console.ReadKey();
        }

        // метод объединения списков и выборки первых N
        static IEnumerable<int> ListSequence(List<List<int>> list, int n)
        {
            IEnumerable<int> result = new List<int>();

            foreach (var nested in list)
            {
                result = result.Union(nested);
            }

            if (result.Count() >= n)
            {
                result = result.ToList().GetRange(0, n);
            }

            return result;
        }

        // генерируем списки из списков, которые содержат целочисленные значения
        static List<List<int>> GenerateLists(int k, int n)
        {
            var list = new List<List<int>>();
            var rand = new Random();

            for (int i = 0; i < k; i++)
            {
                var nested = new List<int>();

                for (int j = 0; j < n; j++)
                {

                    nested.Add(rand.Next(0, 9));
                }

                nested.Sort();

                // добавляем в основной список
                list.Add(nested);
            }

            return list;
        }
    }
}

