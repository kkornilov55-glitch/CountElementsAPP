using ClassLibrary;

namespace CountElementsAPP
{
    public partial class CountElementsF : Form
    {
        public CountElementsF()
        {
            InitializeComponent();
        }

        private void GenerateB_Click(object sender, EventArgs e)
        {
            const int maxElements = 1000000;
            int ce;
            try
            {
                ce = int.Parse(cauntElementsTB.Text);
                MassSum.GenerateArray(ce);
                if (MassSum.error)
                {
                    MessageBox.Show(MassSum.msgError, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MassSum.error = false;
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка при генерации массива. Введите корректное количество элементов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MassSum.error = false;
                return;
            }

            if (ce <= maxElements)
                massTB.Text = MassSum.PrintArray();
            else
                massTB.Text = "Массив слишком большой. Кол-во элементов: " + ce.ToString();
        }
        private void CalcB_Click(object sender, EventArgs e)
        {
            long stepsRec = 0, stepsIter = 0;

            string iterRes = MassSum.IterativeCalc(out double timeIter, ref stepsIter);
            string recRes = MassSum.RecursionCalc(out double timeRec, ref stepsRec);

            resultsGV.Rows.Clear();
            resultsGV.Rows.Add("Итеративный", timeIter.ToString() + " мс", stepsIter);
            resultsGV.Rows.Add("Рекурсивный", timeRec.ToString() + " мс", stepsRec);


            IterSumL.Text = iterRes;
            RecSumL.Text = recRes;
        }
    }
}
