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

        public static string RecursionCalc()
        {
            return Convert.ToString(RecursionRange(0, mass.Length));
        }
        private static long RecursionRange(long l, long r)
        {
            if (l > r) return 0;
            if (l == r) return mass[l];

            long mid = (l + r) / 2;
            long sumLeft = RecursionRange(0, mid);
            long sumRight = RecursionRange(mid + 1, mass.Length);

            return sumLeft + sumRight;
        }


    }
}
