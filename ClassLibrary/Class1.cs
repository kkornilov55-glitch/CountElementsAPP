using System.Timers;

namespace ClassLibrary
{
    public class MassSum
    {
        public static bool error = false;
        const int MAX_VALUE = 100000;
        const int MIN_VALUE = 100;

        public static string IterativeCalc(int[] mass)
        {
            long sum = 0;

            foreach (int el in mass)
            {
                if (el < MIN_VALUE || el > MAX_VALUE)
                {
                    error = true;
                    return "Ошибка: Значение элемента выходит за границы допустимого!";
                }

                if (sum + el > long.MaxValue)
                {
                    error = true;
                    return "Ошибка: Переполнение Long!";
                }

                sum += el;
            }

            return sum.ToString();
        }

        private static string RecursionCalc(int[] mass, int indx, long sum)
        {
            if (indx == mass.Length)
                return sum.ToString();

            if (sum + mass[indx] > long.MaxValue)
            {
                error = true;
                return "Ошибка: Переполнение Long!";
            }

            if (mass[indx] > MAX_VALUE || mass[indx] < MIN_VALUE)
            {
                error = true;
                return "Ошибка: Значение элемента выходит за допустимые границы!";
            }

            sum += mass[indx];

            return RecursionCalc(mass, indx + 1, sum);
        }

    }
}
