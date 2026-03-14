using System.Diagnostics;

namespace ClassLibrary
{
    public class MassSum
    {
        public static bool error = false;
        public static string msgError;
        private static int[] mass;

        public static void GenerateArray(int countElements)
        {
            Random rnd = new Random();
            const int MAX_VALUE = 100000;
            const int MIN_VALUE = 100;
            const int MAX_COUNT = 100000;

            // Проверка на отрицательное количество элементов
            if (countElements <= 0)
            {
                error = true;
                msgError = "Число элементов должно быть положительным!";
                return;
            }

            mass = new int[countElements];
            for (int i = 0; i < countElements; i++)
            {
                mass[i] = rnd.Next(MIN_VALUE, MAX_VALUE);

            }

        }

        public static string PrintArray()
        {
            string array = string.Empty;
            foreach (int el in mass) array += (el + ", ");
            return array.Remove(array.Length - 2);
        }

        public static string IterativeCalc(out double time, ref long steps)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start(); //----------------------------------------

            long sum = 0;
            steps++;
            foreach (int el in mass)
            {
                if (sum + el > long.MaxValue)
                {
                    error = true;
                    msgError = "Переполнение Long!";
                    time = 0;
                    steps = 0;
                    return string.Empty;
                }

                sum += el;
                steps += 3;
            }
            timer.Stop(); //-----------------------------------------

            time = timer.Elapsed.TotalMilliseconds;
            steps++;

            return sum.ToString();
        }

        public static string RecursionCalc(out double time, ref long steps)
        {
            Stopwatch timer = new Stopwatch();
            steps = 4;

            if (error)
            {
                time = 0;
                return "ОШИБКА: Переполнение стека вызовов!";
            }
            else
            {
                timer.Start(); //----------------------------------------
                long sum = RecursionRange(0, mass.Length - 1, ref steps);
                timer.Stop();  //----------------------------------------

                time = timer.Elapsed.TotalMilliseconds;
                return Convert.ToString(sum);
            }
        }
        private static long RecursionRange(long l, long r, ref long steps)
        {
            if (l > r) return 0;
            if (l == r) return mass[l];
            steps += 1;

            long mid = (l + r) / 2;
            steps += 3;

            long sumLeft, sumRight;

            sumLeft = RecursionRange(l, mid, ref steps);
            sumRight = RecursionRange(mid + 1, r, ref steps);

            steps++;
            return sumLeft + sumRight;
        }
    }
}
