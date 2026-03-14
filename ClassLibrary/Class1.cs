using System.Diagnostics;

namespace ClassLibrary
{
    public class MassSum
    {
        public bool error = false;
        public string msgError;
        private int[] mass;
        private static readonly Random rnd = new Random();

        /// <summary>
        /// Генерирует массив случайных чисел заданного размера.
        /// </summary>
        /// <param name="countElements">Количество элементов (от 1 до 100000).</param>
        public void GenerateArray(int countElements)
        {
            // Проверка на отрицательное или нулевое количество элементов
            if (countElements <= 0)
            {
                error = true;
                msgError = "Число элементов должно быть больше 0!";
                return;
            }

            // Проверка максимального размера
            if (countElements > 100000)
            {
                error = true;
                msgError = "Превышен максимальный размер массива (100000)";
                return;
            }

            mass = new int[countElements];
            for (int i = 0; i < countElements; i++)
            {
                mass[i] = rnd.Next(100, 100000);
            }
        }

        /// <summary>
        /// Возвращает строковое представление массива.
        /// </summary>
        public string PrintArray()
        {
            if (mass == null) return "Массив не создан";
            //if (mass.Length == 0) return string.Empty;

            string array = string.Empty;
            foreach (int el in mass)
                array += (el + ", ");

            return array.Remove(array.Length - 2);
        }

        /// <summary>
        /// Итеративное вычисление суммы элементов массива.
        /// </summary>
        /// <param name="time">Время выполнения в миллисекундах.</param>
        /// <param name="steps">Счётчик элементарных операций.</param>
        /// <returns>Строка с суммой или пустая строка при ошибке.</returns>
        public string IterativeCalc(out double time, ref long steps)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            long sum = 0;
            steps++;

            foreach (int el in mass)
            {
                sum += el;
                steps += 3;
            }

            timer.Stop();
            time = timer.Elapsed.TotalMilliseconds;
            steps++;

            return sum.ToString();
        }

        /// <summary>
        /// Рекурсивное вычисление суммы элементов массива (метод «разделяй и властвуй»).
        /// </summary>
        public string RecursionCalc(out double time, ref long steps)
        {
            if (error)
            {
                time = 0;
                steps += 3;
                return msgError;
            }

            Stopwatch timer = new Stopwatch();
            steps += 4; // исправлено: добавляем, а не присваиваем
            timer.Start();

            long sum = RecursionRange(0, mass.Length - 1, ref steps);

            timer.Stop();
            time = timer.Elapsed.TotalMilliseconds;

            return sum.ToString();
        }

        private long RecursionRange(long l, long r, ref long steps)
        {
            if (l > r) return 0;
            if (l == r) return mass[l];

            steps += 1;

            long mid = (l + r) / 2;
            steps += 4;

            long sumLeft = RecursionRange(l, mid, ref steps);
            long sumRight = RecursionRange(mid + 1, r, ref steps);

            steps++;
            return sumLeft + sumRight;
        }
    }
}