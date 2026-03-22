namespace Tyuiu.StachinskiiVS.Sprint6.Task2.V25
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxOne_SVS = new GroupBox();
            labelCondition_SVS = new Label();
            groupBoxTwo_SVS = new GroupBox();
            buttonPerform_SVS = new Button();
            buttonReference_SVS = new Button();
            textBoxInputEnd_SVS = new TextBox();
            textBoxInputStart_SVS = new TextBox();
            labelEnd_SVS = new Label();
            labelStart_SVS = new Label();
            groupBoxThree_SVS = new GroupBox();
            textBoxResult_SVS = new TextBox();
            labelResult_SVS = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxOne_SVS.SuspendLayout();
            groupBoxTwo_SVS.SuspendLayout();
            groupBoxThree_SVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxOne_SVS
            // 
            groupBoxOne_SVS.Controls.Add(chart1);
            groupBoxOne_SVS.Controls.Add(labelCondition_SVS);
            groupBoxOne_SVS.Location = new Point(12, 12);
            groupBoxOne_SVS.Name = "groupBoxOne_SVS";
            groupBoxOne_SVS.Size = new Size(535, 341);
            groupBoxOne_SVS.TabIndex = 0;
            groupBoxOne_SVS.TabStop = false;
            groupBoxOne_SVS.Text = "Условие";
            // 
            // labelCondition_SVS
            // 
            labelCondition_SVS.AutoSize = true;
            labelCondition_SVS.Location = new Point(6, 25);
            labelCondition_SVS.Name = "labelCondition_SVS";
            labelCondition_SVS.Size = new Size(319, 45);
            labelCondition_SVS.TabIndex = 0;
            labelCondition_SVS.Text = "Протабуллировать функцию (x) на заданном диапазоне.\r\nРезультат вывести в форме таблицы\r\n\r\n";
            // 
            // groupBoxTwo_SVS
            // 
            groupBoxTwo_SVS.Controls.Add(buttonPerform_SVS);
            groupBoxTwo_SVS.Controls.Add(buttonReference_SVS);
            groupBoxTwo_SVS.Controls.Add(textBoxInputEnd_SVS);
            groupBoxTwo_SVS.Controls.Add(textBoxInputStart_SVS);
            groupBoxTwo_SVS.Controls.Add(labelEnd_SVS);
            groupBoxTwo_SVS.Controls.Add(labelStart_SVS);
            groupBoxTwo_SVS.Location = new Point(12, 359);
            groupBoxTwo_SVS.Name = "groupBoxTwo_SVS";
            groupBoxTwo_SVS.Size = new Size(535, 79);
            groupBoxTwo_SVS.TabIndex = 1;
            groupBoxTwo_SVS.TabStop = false;
            groupBoxTwo_SVS.Text = "Вывод данных";
            // 
            // buttonPerform_SVS
            // 
            buttonPerform_SVS.BackColor = Color.Green;
            buttonPerform_SVS.Location = new Point(381, 18);
            buttonPerform_SVS.Name = "buttonPerform_SVS";
            buttonPerform_SVS.Size = new Size(148, 55);
            buttonPerform_SVS.TabIndex = 6;
            buttonPerform_SVS.Text = "Выполнить";
            buttonPerform_SVS.UseVisualStyleBackColor = false;
            // 
            // buttonReference_SVS
            // 
            buttonReference_SVS.BackColor = Color.FromArgb(0, 192, 192);
            buttonReference_SVS.Location = new Point(294, 18);
            buttonReference_SVS.Name = "buttonReference_SVS";
            buttonReference_SVS.Size = new Size(81, 55);
            buttonReference_SVS.TabIndex = 5;
            buttonReference_SVS.Text = "Справка";
            buttonReference_SVS.UseVisualStyleBackColor = false;
            // 
            // textBoxInputEnd_SVS
            // 
            textBoxInputEnd_SVS.Location = new Point(151, 49);
            textBoxInputEnd_SVS.Multiline = true;
            textBoxInputEnd_SVS.Name = "textBoxInputEnd_SVS";
            textBoxInputEnd_SVS.Size = new Size(121, 30);
            textBoxInputEnd_SVS.TabIndex = 3;
            // 
            // textBoxInputStart_SVS
            // 
            textBoxInputStart_SVS.Location = new Point(0, 49);
            textBoxInputStart_SVS.Multiline = true;
            textBoxInputStart_SVS.Name = "textBoxInputStart_SVS";
            textBoxInputStart_SVS.Size = new Size(124, 30);
            textBoxInputStart_SVS.TabIndex = 2;
            // 
            // labelEnd_SVS
            // 
            labelEnd_SVS.AutoSize = true;
            labelEnd_SVS.Location = new Point(151, 28);
            labelEnd_SVS.Name = "labelEnd_SVS";
            labelEnd_SVS.Size = new Size(75, 15);
            labelEnd_SVS.TabIndex = 1;
            labelEnd_SVS.Text = "Конец шага:";
            // 
            // labelStart_SVS
            // 
            labelStart_SVS.AutoSize = true;
            labelStart_SVS.Location = new Point(6, 25);
            labelStart_SVS.Name = "labelStart_SVS";
            labelStart_SVS.Size = new Size(72, 15);
            labelStart_SVS.TabIndex = 0;
            labelStart_SVS.Text = "Старт шага:";
            // 
            // groupBoxThree_SVS
            // 
            groupBoxThree_SVS.Controls.Add(textBoxResult_SVS);
            groupBoxThree_SVS.Controls.Add(labelResult_SVS);
            groupBoxThree_SVS.Location = new Point(562, 12);
            groupBoxThree_SVS.Name = "groupBoxThree_SVS";
            groupBoxThree_SVS.Size = new Size(226, 426);
            groupBoxThree_SVS.TabIndex = 1;
            groupBoxThree_SVS.TabStop = false;
            groupBoxThree_SVS.Text = "Вывод данных";
            groupBoxThree_SVS.Enter += groupBoxThree_SVS_Enter;
            // 
            // textBoxResult_SVS
            // 
            textBoxResult_SVS.Location = new Point(6, 49);
            textBoxResult_SVS.Multiline = true;
            textBoxResult_SVS.Name = "textBoxResult_SVS";
            textBoxResult_SVS.ScrollBars = ScrollBars.Vertical;
            textBoxResult_SVS.Size = new Size(214, 371);
            textBoxResult_SVS.TabIndex = 1;
            // 
            // labelResult_SVS
            // 
            labelResult_SVS.AutoSize = true;
            labelResult_SVS.Location = new Point(6, 25);
            labelResult_SVS.Name = "labelResult_SVS";
            labelResult_SVS.Size = new Size(63, 15);
            labelResult_SVS.TabIndex = 0;
            labelResult_SVS.Text = "Результат:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(229, 41);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(300, 300);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxTwo_SVS);
            Controls.Add(groupBoxThree_SVS);
            Controls.Add(groupBoxOne_SVS);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            groupBoxOne_SVS.ResumeLayout(false);
            groupBoxOne_SVS.PerformLayout();
            groupBoxTwo_SVS.ResumeLayout(false);
            groupBoxTwo_SVS.PerformLayout();
            groupBoxThree_SVS.ResumeLayout(false);
            groupBoxThree_SVS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOne_SVS;
        private Label labelCondition_SVS;
        private GroupBox groupBoxTwo_SVS;
        private GroupBox groupBoxThree_SVS;
        private Label labelResult_SVS;
        private Label labelEnd_SVS;
        private Label labelStart_SVS;
        private Button buttonPerform_SVS;
        private Button buttonReference_SVS;
        private TextBox textBoxInputEnd_SVS;
        private TextBox textBoxInputStart_SVS;
        private TextBox textBoxResult_SVS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
