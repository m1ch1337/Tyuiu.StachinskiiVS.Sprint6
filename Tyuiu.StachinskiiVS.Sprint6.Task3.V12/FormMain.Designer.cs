namespace Tyuiu.StachinskiiVS.Sprint6.Task3.V12
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
            groupBoxResult_SVS = new GroupBox();
            labelCondition1_SVS = new Label();
            buttonResult_SVS = new Button();
            dataGridViewResult_SVS = new DataGridView();
            dataGridViewSorted_SVS = new DataGridView();
            groupBoxResult_SVS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SVS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSorted_SVS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxResult_SVS
            // 
            groupBoxResult_SVS.Controls.Add(labelCondition1_SVS);
            groupBoxResult_SVS.Location = new Point(12, 12);
            groupBoxResult_SVS.Name = "groupBoxResult_SVS";
            groupBoxResult_SVS.Size = new Size(339, 301);
            groupBoxResult_SVS.TabIndex = 0;
            groupBoxResult_SVS.TabStop = false;
            groupBoxResult_SVS.Text = "Условие";
            // 
            // labelCondition1_SVS
            // 
            labelCondition1_SVS.AutoSize = true;
            labelCondition1_SVS.Location = new Point(21, 28);
            labelCondition1_SVS.Name = "labelCondition1_SVS";
            labelCondition1_SVS.Size = new Size(168, 15);
            labelCondition1_SVS.TabIndex = 0;
            labelCondition1_SVS.Text = "Четные на 0 в первой строке ";
            // 
            // buttonResult_SVS
            // 
            buttonResult_SVS.Location = new Point(219, 319);
            buttonResult_SVS.Name = "buttonResult_SVS";
            buttonResult_SVS.Size = new Size(132, 66);
            buttonResult_SVS.TabIndex = 1;
            buttonResult_SVS.Text = "GOGOGO";
            buttonResult_SVS.UseVisualStyleBackColor = true;
            buttonResult_SVS.Click += buttonResult_SVS_Click;
            // 
            // dataGridViewResult_SVS
            // 
            dataGridViewResult_SVS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_SVS.Location = new Point(364, 44);
            dataGridViewResult_SVS.Name = "dataGridViewResult_SVS";
            dataGridViewResult_SVS.Size = new Size(240, 150);
            dataGridViewResult_SVS.TabIndex = 2;
            // 
            // dataGridViewSorted_SVS
            // 
            dataGridViewSorted_SVS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSorted_SVS.Location = new Point(364, 217);
            dataGridViewSorted_SVS.Name = "dataGridViewSorted_SVS";
            dataGridViewSorted_SVS.Size = new Size(240, 150);
            dataGridViewSorted_SVS.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewSorted_SVS);
            Controls.Add(dataGridViewResult_SVS);
            Controls.Add(buttonResult_SVS);
            Controls.Add(groupBoxResult_SVS);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxResult_SVS.ResumeLayout(false);
            groupBoxResult_SVS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_SVS).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSorted_SVS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxResult_SVS;
        private Label labelCondition1_SVS;
        private Button buttonResult_SVS;
        private DataGridView dataGridViewResult_SVS;
        private DataGridView dataGridViewSorted_SVS;
    }
}
