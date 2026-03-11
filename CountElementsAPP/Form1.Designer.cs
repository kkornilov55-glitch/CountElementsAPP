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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cauntElementsTB = new TextBox();
            panel2 = new Panel();
            textBox1 = new TextBox();
            GenerateB = new Button();
            label4 = new Label();
            label5 = new Label();
            IterativeB = new Button();
            RecursionB = new Button();
            AllCalcB = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Chocolate;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(829, 74);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(183, 239, 255);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(87, 87, 87);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(829, 74);
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
            cauntElementsTB.Size = new Size(297, 39);
            cauntElementsTB.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(183, 239, 255);
            panel2.Location = new Point(400, 324);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 509);
            panel2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(183, 239, 255);
            textBox1.Location = new Point(238, 206);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Horizontal;
            textBox1.Size = new Size(297, 39);
            textBox1.TabIndex = 5;
            // 
            // GenerateB
            // 
            GenerateB.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            GenerateB.ForeColor = Color.FromArgb(87, 87, 87);
            GenerateB.Location = new Point(541, 142);
            GenerateB.Name = "GenerateB";
            GenerateB.Size = new Size(183, 39);
            GenerateB.TabIndex = 6;
            GenerateB.Text = "Сгенерировать";
            GenerateB.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(183, 239, 255);
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.FromArgb(87, 87, 87);
            label4.Location = new Point(12, 324);
            label4.Name = "label4";
            label4.Size = new Size(382, 39);
            label4.TabIndex = 7;
            label4.Text = "Итеративно";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.FromArgb(183, 239, 255);
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.FromArgb(87, 87, 87);
            label5.Location = new Point(416, 324);
            label5.Name = "label5";
            label5.Size = new Size(401, 39);
            label5.TabIndex = 8;
            label5.Text = "Рекурсивно";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // IterativeB
            // 
            IterativeB.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            IterativeB.ForeColor = Color.FromArgb(87, 87, 87);
            IterativeB.Location = new Point(12, 395);
            IterativeB.Name = "IterativeB";
            IterativeB.Size = new Size(382, 39);
            IterativeB.TabIndex = 9;
            IterativeB.Text = "Посчитать";
            IterativeB.UseVisualStyleBackColor = true;
            // 
            // RecursionB
            // 
            RecursionB.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            RecursionB.ForeColor = Color.FromArgb(87, 87, 87);
            RecursionB.Location = new Point(416, 395);
            RecursionB.Name = "RecursionB";
            RecursionB.Size = new Size(401, 39);
            RecursionB.TabIndex = 10;
            RecursionB.Text = "Посчитать";
            RecursionB.UseVisualStyleBackColor = true;
            // 
            // AllCalcB
            // 
            AllCalcB.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            AllCalcB.ForeColor = Color.FromArgb(87, 87, 87);
            AllCalcB.Location = new Point(541, 206);
            AllCalcB.Name = "AllCalcB";
            AllCalcB.Size = new Size(183, 39);
            AllCalcB.TabIndex = 11;
            AllCalcB.Text = "Посчитать полностью";
            AllCalcB.UseVisualStyleBackColor = true;
            // 
            // CountElementsF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(829, 845);
            Controls.Add(AllCalcB);
            Controls.Add(RecursionB);
            Controls.Add(IterativeB);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(GenerateB);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(cauntElementsTB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "CountElementsF";
            Text = "CountElementsF";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox cauntElementsTB;
        private Panel panel2;
        private TextBox textBox1;
        private Button GenerateB;
        private Label label4;
        private Label label5;
        private Button IterativeB;
        private Button RecursionB;
        private Button AllCalcB;
    }
}
