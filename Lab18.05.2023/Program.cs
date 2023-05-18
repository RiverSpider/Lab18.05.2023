using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 10, 15, -20, 25, -30, 35, 40, 45, 50 };
        Console.WriteLine("Массив: ");
        foreach (var n in numbers)
        {
            Console.Write(n + " ");
        }
        var positiveNumbers = from n in numbers
                              where n > 0
                              select n;

        Console.WriteLine("\nПоложительные числа: ");
        foreach (var n in positiveNumbers)
        {
            Console.Write(n + " ");
        }

        var negativeSum = (from n in numbers
                           where n < 0
                           select n).Sum();

        Console.WriteLine("\nСумма отрицательных чисел: " + negativeSum);

        var countMultipleOfFive = (from n in numbers
                                   where n % 5 == 0
                                   select n).Count();

        Console.WriteLine("Количество чисел, кратных 5: " + countMultipleOfFive);

        numbers = numbers.Where(n => n % 2 != 0).ToArray();

        Console.WriteLine("Массив после удаления четных элементов: ");
        foreach (var n in numbers)
        {
            Console.Write(n + " ");
        }

        var positiveNumbers2 = from n in numbers
                               where n > 0
                               select n;

        Console.WriteLine("\nПоложительные числа после удаления четных: ");
        foreach (var n in positiveNumbers2)
        {
            Console.Write(n + " ");
        }

        var negativeSum2 = (from n in numbers
                            where n < 0
                            select n).Sum();

        Console.WriteLine("\nСумма отрицательных чисел после удаления четных: " + negativeSum2);

        var countMultipleOfFive2 = (from n in numbers
                                    where n % 5 == 0
                                    select n).Count();

        Console.WriteLine("Количество чисел, кратных 5 после удаления четных: " + countMultipleOfFive2);
    }
}
