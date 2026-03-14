using ClassLibrary;
using System.Security.Cryptography.X509Certificates;

namespace CountElementsAPP
{
    public partial class CountElementsF : Form
    {
        public CountElementsF()
        {
            InitializeComponent();
        }

        public MassSum calc = new MassSum();

        private void GenerateB_Click(object sender, EventArgs e)
        {
            int ce;
            try
            {
                ce = int.Parse(cauntElementsTB.Text);
                calc.GenerateArray(ce);
                if (calc.error)
                {
                    MessageBox.Show(calc.msgError, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    calc.error = false;
                    return;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка при генерации массива. Введите корректное количество элементов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                calc.error = false;
                return;
            }

            massTB.Text = calc.PrintArray();
            CalcB.Visible = true;
        }
        private void CalcB_Click(object sender, EventArgs e)
        {
            long stepsRec = 0, stepsIter = 0;

            string iterRes = calc.IterativeCalc(out double timeIter, ref stepsIter);
            string recRes = calc.RecursionCalc(out double timeRec, ref stepsRec);

            resultsGV.Rows.Clear();
            resultsGV.Rows.Add("Итеративный", timeIter.ToString() + " мс", stepsIter); 
            if (calc.error)
            {
                MessageBox.Show(calc.msgError, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                calc.error = false;
                return;
            }
            resultsGV.Rows.Add("Рекурсивный", timeRec.ToString() + " мс", stepsRec);
            if (calc.error)
            {
                MessageBox.Show(calc.msgError, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                calc.error = false;
                return;
            }


            IterSumL.Text = iterRes;
            RecSumL.Text = recRes;
        }
    }
}
