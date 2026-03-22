namespace Tyuiu.StachinskiiVS.Sprint6.Task5.V14
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            label1 = new Label();
            labelTask = new Label();
            buttonGo = new Button();
            buttonHelp = new Button();
            buttonSave = new Button();
            panel2 = new Panel();
            GridBox = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridBox).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(labelTask);
            panel1.Controls.Add(buttonGo);
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(buttonSave);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 94);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 42);
            label1.Name = "label1";
            label1.Size = new Size(421, 15);
            label1.TabIndex = 1;
            label1.Text = "Вывести все числа, меньше 10. Построить диаграмму по этим значениям. ";
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(10, 16);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(409, 15);
            labelTask.TabIndex = 1;
            labelTask.Text = "Прочитать данные из файла InPutFileTask5V14xt. Вывести в dataGridView. ";
            labelTask.Click += labelTask_Click;
            // 
            // buttonGo
            // 
            buttonGo.Location = new Point(628, 9);
            buttonGo.Margin = new Padding(3, 2, 3, 2);
            buttonGo.Name = "buttonGo";
            buttonGo.Size = new Size(97, 22);
            buttonGo.TabIndex = 0;
            buttonGo.Text = "Выполнить";
            buttonGo.UseVisualStyleBackColor = true;
            buttonGo.Click += buttonGo_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(662, 62);
            buttonHelp.Margin = new Padding(3, 2, 3, 2);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(32, 22);
            buttonHelp.TabIndex = 0;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(628, 35);
            buttonSave.Margin = new Padding(3, 2, 3, 2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(97, 22);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(GridBox);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 94);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 320);
            panel2.TabIndex = 0;
            // 
            // GridBox
            // 
            GridBox.AllowUserToAddRows = false;
            GridBox.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridBox.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            GridBox.Dock = DockStyle.Left;
            GridBox.Location = new Point(0, 0);
            GridBox.Margin = new Padding(3, 2, 3, 2);
            GridBox.Name = "GridBox";
            GridBox.RowHeadersVisible = false;
            GridBox.RowHeadersWidth = 51;
            GridBox.Size = new Size(200, 320);
            GridBox.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = " ";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = " ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // panel3
            // 
            panel3.Controls.Add(chart);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(200, 94);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(576, 320);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // chart
            // 
            chartArea2.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea2);
            chart.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chart.Legends.Add(legend2);
            chart.Location = new Point(0, 0);
            chart.Margin = new Padding(3, 2, 3, 2);
            chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart.Series.Add(series2);
            chart.Size = new Size(576, 320);
            chart.TabIndex = 0;
            chart.Text = "chart1";
            chart.Click += chart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 414);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridBox).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private DataGridView GridBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private Label labelTask;
        private Button buttonGo;
        private Button buttonHelp;
        private Button buttonSave;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}