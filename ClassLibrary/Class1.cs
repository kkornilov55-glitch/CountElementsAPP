using System.Timers;

namespace ClassLibrary
{
    public class MassSum
    {
        public static bool error = false;
        static int[] mass;

        public static void GenerateArray(int countElements)
        {
            Random rnd = new Random();
            const int MAX_VALUE = 100000;
            const int MIN_VALUE = 100;
            mass = new int[countElements];
            for (int i = 0; i < countElements; i++) 
                mass[i] = rnd.Next(MIN_VALUE, MAX_VALUE);
        }

        public static string IterativeCalc()
        {
            long sum = 0;

            foreach (int el in mass)
            {
                if (sum + el > long.MaxValue)
                {
                    error = true;
                    return "Ошибка: Переполнение Long!";
                }

                sum += el;
            }

            return sum.ToString();
        }

        private static string RecursionCalc(int indx, long sum)
        {
            //Базовый случай
            if (indx == mass.Length)
                return sum.ToString();

            //Проверка переполнения
            if (sum + mass[indx] > long.MaxValue)
            {
                error = true;
                return "Ошибка: Переполнение Long!";
            }
            //Расчёт суммы
            sum += mass[indx];

            return RecursionCalc(indx + 1, sum);
        }

    }
}
