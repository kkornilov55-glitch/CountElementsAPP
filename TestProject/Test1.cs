using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Reflection;

namespace TestProject
{
    [TestClass]
    public class MassSumTests
    {
        /// <summary>
        /// Устанавливает приватное поле mass для указанного экземпляра MassSum.
        /// </summary>
        private void SetMass(MassSum instance, int[] array)
        {
            var field = typeof(MassSum).GetField("mass", BindingFlags.NonPublic | BindingFlags.Instance);
            field.SetValue(instance, array);
        }

        // ==================== ТЕСТЫ ДЛЯ GENERATEARRAY ====================

        [TestMethod]
        public void GenerateArray_NegativeCount_SetsError()
        {
            var massSum = new MassSum();
            massSum.GenerateArray(-5);
            Assert.IsTrue(massSum.error);
            Assert.AreEqual("Число элементов должно быть больше 0!", massSum.msgError);
        }

        [TestMethod]
        public void GenerateArray_ZeroCount_SetsError()
        {
            var massSum = new MassSum();
            massSum.GenerateArray(0);
            Assert.IsTrue(massSum.error);
            Assert.AreEqual("Число элементов должно быть больше 0!", massSum.msgError);
        }

        [TestMethod]
        public void GenerateArray_CountTooLarge_SetsError()
        {
            var massSum = new MassSum();
            massSum.GenerateArray(100001);
            Assert.IsTrue(massSum.error);
            Assert.AreEqual("Превышен максимальный размер массива (100000)", massSum.msgError);
        }

        [TestMethod]
        public void GenerateArray_PositiveCount_CreatesArrayWithoutError()
        {
            var massSum = new MassSum();
            massSum.GenerateArray(10);
            Assert.IsFalse(massSum.error);
            string result = massSum.PrintArray();
            Assert.IsNotNull(result);
            StringAssert.Contains(result, ",");
        }

        // ==================== ТЕСТЫ ДЛЯ PRINTARRAY ====================

        [TestMethod]
        public void PrintArray_WhenMassIsNull_ReturnsMessage()
        {
            var massSum = new MassSum();
            // mass не установлен, по умолчанию null
            string result = massSum.PrintArray();
            Assert.AreEqual("Массив не создан", result);
        }

        [TestMethod]
        public void PrintArray_ReturnsFormattedString()
        {
            var massSum = new MassSum();
            SetMass(massSum, new int[] { 1, 2, 3 });
            string result = massSum.PrintArray();
            Assert.AreEqual("1, 2, 3", result);
        }

        // ==================== ТЕСТЫ ДЛЯ ITERATIVECALC ====================

        [TestMethod]
        public void IterativeCalc_SimpleArray_ReturnsCorrectSum()
        {
            var massSum = new MassSum();
            SetMass(massSum, new int[] { 1, 2, 3, 4, 5 });
            long steps = 0;
            double time;
            string result = massSum.IterativeCalc(out time, ref steps);
            Assert.AreEqual("15", result);
            Assert.IsFalse(massSum.error);
            Assert.IsTrue(time >= 0);
            Assert.IsTrue(steps > 0);
        }

        [TestMethod]
        public void IterativeCalc_SingleElement_ReturnsElementAndCorrectSteps()
        {
            var massSum = new MassSum();
            SetMass(massSum, new int[] { 42 });
            long steps = 0;
            double time;
            massSum.IterativeCalc(out time, ref steps);
            // Ожидаемые шаги: 1 (инициализация) + 3 (за элемент) + 1 (завершение) = 5
            Assert.AreEqual(5, steps);
        }

        [TestMethod]
        public void IterativeCalc_TwoElements_StepsCountMatchesExpected()
        {
            var massSum = new MassSum();
            SetMass(massSum, new int[] { 10, 20 });
            long steps = 0;
            double time;
            massSum.IterativeCalc(out time, ref steps);
            // Ожидаемые шаги: 1 + 2*3 + 1 = 8
            Assert.AreEqual(8, steps);
        }

        [TestMethod]
        public void IterativeCalc_LargeArray_NoErrorAndCorrectSum()
        {
            var massSum = new MassSum();
            int size = 10000;
            int[] array = new int[size];
            for (int i = 0; i < size; i++) array[i] = 1; // сумма = size
            SetMass(massSum, array);
            long steps = 0;
            double time;
            string result = massSum.IterativeCalc(out time, ref steps);
            Assert.AreEqual(size.ToString(), result);
            Assert.IsFalse(massSum.error);
        }

        // ==================== ТЕСТЫ ДЛЯ RECURSIONCALC ====================

        [TestMethod]
        public void RecursionCalc_SimpleArray_ReturnsCorrectSum()
        {
            var massSum = new MassSum();
            SetMass(massSum, new int[] { 1, 2, 3, 4, 5 });
            long steps = 0;
            double time;
            string result = massSum.RecursionCalc(out time, ref steps);
            Assert.AreEqual("15", result);
            Assert.IsFalse(massSum.error);
            Assert.IsTrue(time >= 0);
            Assert.IsTrue(steps > 0);
        }

        [TestMethod]
        public void RecursionCalc_SingleElement_ReturnsElementAndSteps4()
        {
            var massSum = new MassSum();
            SetMass(massSum, new int[] { 42 });
            long steps = 0;
            double time;
            massSum.RecursionCalc(out time, ref steps);
            // steps = 4 (начальные) + 0 (в RecursionRange) = 4
            Assert.AreEqual(4, steps);
        }

        [TestMethod]
        public void RecursionCalc_TwoElements_StepsCountMatchesExpected()
        {
            var massSum = new MassSum();
            SetMass(massSum, new int[] { 5, 7 });
            long steps = 0;
            double time;
            massSum.RecursionCalc(out time, ref steps);
            // Ожидаемые шаги: 4 (начальные) + 1 (проверка l<r) + 4 (mid) + 1 (сложение) = 10
            Assert.AreEqual(10, steps);
        }

        [TestMethod]
        public void RecursionCalc_LargeArray_NoError()
        {
            var massSum = new MassSum();
            int size = 10000;
            int[] array = new int[size];
            for (int i = 0; i < size; i++) array[i] = 1;
            SetMass(massSum, array);
            long steps = 0;
            double time;
            string result = massSum.RecursionCalc(out time, ref steps);
            Assert.AreEqual(size.ToString(), result);
            Assert.IsFalse(massSum.error);
        }


        [TestMethod]
        public void RecursionCalc_WhenErrorIsTrue_ReturnsErrorMessageAndAddsSteps()
        {
            var massSum = new MassSum();
            massSum.error = true;
            massSum.msgError = "Тестовая ошибка";
            SetMass(massSum, new int[] { 1, 2, 3 }); // не должен использоваться
            long steps = 5; // начальное значение
            double time;
            string result = massSum.RecursionCalc(out time, ref steps);
            Assert.AreEqual("Тестовая ошибка",
                result);
            Assert.AreEqual(0, time);
            Assert.AreEqual(8, steps); // 5 + 3 = 8
        }
    }
}