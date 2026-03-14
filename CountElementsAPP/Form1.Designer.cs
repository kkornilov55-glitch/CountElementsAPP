namespace CountElementsAPP
{
    partial class CountElementsF
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel12 = new Panel();
            panel11 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cauntElementsTB = new TextBox();
            massTB = new TextBox();
            GenerateB = new Button();
            CalcB = new Button();
            label6 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            resultsGV = new DataGridView();
            colMethodCalc = new DataGridViewTextBoxColumn();
            colTime = new DataGridViewTextBoxColumn();
            colSteps = new DataGridViewTextBoxColumn();
            panel5 = new Panel();
            panel6 = new Panel();
            label4 = new Label();
            RecSumL = new Label();
            IterSumL = new Label();
            panel13 = new Panel();
            panel14 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultsGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Chocolate;
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel12);
            panel1.Controls.Add(panel11);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(550, 74);
            panel1.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Turquoise;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Location = new Point(532, 25);
            panel9.Name = "panel9";
            panel9.Size = new Size(10, 24);
            panel9.TabIndex = 27;
            // 
            // panel10
            // 
            panel10.BackColor = Color.LightSeaGreen;
            panel10.BorderStyle = BorderStyle.FixedSingle;
            panel10.Location = new Point(527, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(20, 19);
            panel10.TabIndex = 26;
            // 
            // panel12
            // 
            panel12.BackColor = Color.LightSeaGreen;
            panel12.BorderStyle = BorderStyle.FixedSingle;
            panel12.Location = new Point(527, 55);
            panel12.Name = "panel12";
            panel12.Size = new Size(20, 19);
            panel12.TabIndex = 25;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Turquoise;
            panel11.BorderStyle = BorderStyle.FixedSingle;
            panel11.Location = new Point(7, 25);
            panel11.Name = "panel11";
            panel11.Size = new Size(10, 24);
            panel11.TabIndex = 24;
            // 
            // panel8
            // 
            panel8.BackColor = Color.LightSeaGreen;
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Location = new Point(2, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(20, 19);
            panel8.TabIndex = 21;
            // 
            // panel7
            // 
            panel7.BackColor = Color.LightSeaGreen;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Location = new Point(2, 55);
            panel7.Name = "panel7";
            panel7.Size = new Size(20, 19);
            panel7.TabIndex = 20;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(183, 239, 255);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(87, 87, 87);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(550, 74);
            label1.TabIndex = 0;
            label1.Text = "Сумма элементов массива";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(183, 239, 255);
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(87, 87, 87);
            label2.Location = new Point(12, 142);
            label2.Name = "label2";
            label2.Size = new Size(189, 39);
            label2.TabIndex = 1;
            label2.Text = "Количество элементов:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(183, 239, 255);
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(87, 87, 87);
            label3.Location = new Point(12, 206);
            label3.Name = "label3";
            label3.Size = new Size(189, 39);
            label3.TabIndex = 2;
            label3.Text = "Массив:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cauntElementsTB
            // 
            cauntElementsTB.BackColor = Color.FromArgb(183, 239, 255);
            cauntElementsTB.Location = new Point(238, 142);
            cauntElementsTB.Multiline = true;
            cauntElementsTB.Name = "cauntElementsTB";
            cauntElementsTB.Size = new Size(157, 39);
            cauntElementsTB.TabIndex = 3;
            // 
            // massTB
            // 
            massTB.BackColor = Color.FromArgb(183, 239, 255);
            massTB.Font = new Font("Segoe UI", 8F);
            massTB.Location = new Point(238, 206);
            massTB.Multiline = true;
            massTB.Name = "massTB";
            massTB.ReadOnly = true;
            massTB.ScrollBars = ScrollBars.Horizontal;
            massTB.Size = new Size(299, 39);
            massTB.TabIndex = 5;
            // 
            // GenerateB
            // 
            GenerateB.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            GenerateB.ForeColor = Color.FromArgb(87, 87, 87);
            GenerateB.Location = new Point(401, 142);
            GenerateB.Name = "GenerateB";
            GenerateB.Size = new Size(136, 39);
            GenerateB.TabIndex = 6;
            GenerateB.Text = "Сгенерировать";
            GenerateB.UseVisualStyleBackColor = true;
            GenerateB.Click += GenerateB_Click;
            // 
            // CalcB
            // 
            CalcB.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            CalcB.ForeColor = Color.FromArgb(87, 87, 87);
            CalcB.Location = new Point(12, 277);
            CalcB.Name = "CalcB";
            CalcB.Size = new Size(525, 39);
            CalcB.TabIndex = 11;
            CalcB.Text = "Посчитать";
            CalcB.UseVisualStyleBackColor = true;
            CalcB.Click += CalcB_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.FromArgb(183, 239, 255);
            label6.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(87, 87, 87);
            label6.Location = new Point(12, 402);
            label6.Name = "label6";
            label6.Size = new Size(525, 54);
            label6.TabIndex = 12;
            label6.Text = "Результаты";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSeaGreen;
            panel3.Location = new Point(495, 402);
            panel3.Name = "panel3";
            panel3.Size = new Size(42, 343);
            panel3.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Turquoise;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(12, 338);
            panel4.Name = "panel4";
            panel4.Size = new Size(525, 10);
            panel4.TabIndex = 15;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSeaGreen;
            panel2.Location = new Point(12, 402);
            panel2.Name = "panel2";
            panel2.Size = new Size(42, 343);
            panel2.TabIndex = 16;
            // 
            // resultsGV
            // 
            resultsGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsGV.Columns.AddRange(new DataGridViewColumn[] { colMethodCalc, colTime, colSteps });
            resultsGV.Location = new Point(60, 459);
            resultsGV.Name = "resultsGV";
            resultsGV.RowHeadersWidth = 51;
            resultsGV.Size = new Size(429, 140);
            resultsGV.TabIndex = 17;
            // 
            // colMethodCalc
            // 
            colMethodCalc.HeaderText = "Метод";
            colMethodCalc.MinimumWidth = 6;
            colMethodCalc.Name = "colMethodCalc";
            colMethodCalc.ReadOnly = true;
            colMethodCalc.Width = 125;
            // 
            // colTime
            // 
            colTime.HeaderText = "Время выполнения";
            colTime.MinimumWidth = 6;
            colTime.Name = "colTime";
            colTime.ReadOnly = true;
            colTime.Width = 125;
            // 
            // colSteps
            // 
            colSteps.HeaderText = "Шаги";
            colSteps.MinimumWidth = 6;
            colSteps.Name = "colSteps";
            colSteps.ReadOnly = true;
            colSteps.Width = 125;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Turquoise;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(12, 107);
            panel5.Name = "panel5";
            panel5.Size = new Size(525, 10);
            panel5.TabIndex = 18;
            // 
            // panel6
            // 
            panel6.BackColor = Color.LightSeaGreen;
            panel6.Location = new Point(12, 389);
            panel6.Name = "panel6";
            panel6.Size = new Size(525, 10);
            panel6.TabIndex = 19;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(183, 239, 255);
            label4.Font = new Font("MS Reference Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.FromArgb(87, 87, 87);
            label4.Location = new Point(60, 631);
            label4.Name = "label4";
            label4.Size = new Size(429, 43);
            label4.TabIndex = 20;
            label4.Text = "Сумма";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RecSumL
            // 
            RecSumL.BackColor = Color.FromArgb(183, 239, 255);
            RecSumL.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            RecSumL.ForeColor = Color.FromArgb(87, 87, 87);
            RecSumL.Location = new Point(277, 689);
            RecSumL.Name = "RecSumL";
            RecSumL.Size = new Size(212, 43);
            RecSumL.TabIndex = 22;
            RecSumL.Text = "Рекурсивная";
            // 
            // IterSumL
            // 
            IterSumL.BackColor = Color.FromArgb(183, 239, 255);
            IterSumL.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            IterSumL.ForeColor = Color.FromArgb(87, 87, 87);
            IterSumL.Location = new Point(60, 689);
            IterSumL.Name = "IterSumL";
            IterSumL.Size = new Size(212, 43);
            IterSumL.TabIndex = 23;
            IterSumL.Text = "Итеративная";
            // 
            // panel13
            // 
            panel13.BackColor = Color.Turquoise;
            panel13.BorderStyle = BorderStyle.FixedSingle;
            panel13.Location = new Point(60, 618);
            panel13.Name = "panel13";
            panel13.Size = new Size(429, 10);
            panel13.TabIndex = 24;
            // 
            // panel14
            // 
            panel14.BackColor = Color.Turquoise;
            panel14.BorderStyle = BorderStyle.FixedSingle;
            panel14.Location = new Point(60, 735);
            panel14.Name = "panel14";
            panel14.Size = new Size(429, 10);
            panel14.TabIndex = 25;
            // 
            // CountElementsF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(550, 765);
            Controls.Add(panel14);
            Controls.Add(panel13);
            Controls.Add(IterSumL);
            Controls.Add(RecSumL);
            Controls.Add(label4);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(resultsGV);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(label6);
            Controls.Add(CalcB);
            Controls.Add(GenerateB);
            Controls.Add(massTB);
            Controls.Add(cauntElementsTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CountElementsF";
            Text = "Сумма элементов массива";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resultsGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox cauntElementsTB;
        private TextBox massTB;
        private Button GenerateB;
        private Button IterativeB;
        private Button RecursionB;
        private Button CalcB;
        private Label label6;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private DataGridView resultsGV;
        private DataGridViewTextBoxColumn colMethodCalc;
        private DataGridViewTextBoxColumn colTime;
        private DataGridViewTextBoxColumn colSteps;
        private Panel panel5;
        private Panel panel6;
        private Panel panel9;
        private Panel panel10;
        private Panel panel12;
        private Panel panel11;
        private Panel panel8;
        private Panel panel7;
        private Label label4;
        private Label RecSumL;
        private Label IterSumL;
        private Panel panel13;
        private Panel panel14;
    }
}
