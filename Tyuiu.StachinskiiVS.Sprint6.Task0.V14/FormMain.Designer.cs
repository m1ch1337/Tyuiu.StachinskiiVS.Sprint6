namespace Tyuiu.StachinskiiVS.Sprint6.Task0.V14
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonOutput_SVS = new Button();
            textBoxCond_SVS = new TextBox();
            textBoxInput_SVS = new TextBox();
            textBoxOutput_SVS = new TextBox();
            textBoxX_SVS = new TextBox();
            textBoxIntX_SVS = new TextBox();
            textBoxRes_SVS = new TextBox();
            textBoxResult_SVS = new TextBox();
            pictureBoxFormula_SVS = new PictureBox();
            textBoxCondition_SVS = new TextBox();
            buttonQuestion_SVS = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_SVS).BeginInit();
            SuspendLayout();
            // 
            // buttonOutput_SVS
            // 
            buttonOutput_SVS.Location = new Point(307, 322);
            buttonOutput_SVS.Name = "buttonOutput_SVS";
            buttonOutput_SVS.Size = new Size(170, 79);
            buttonOutput_SVS.TabIndex = 0;
            buttonOutput_SVS.Text = "Вычислить\r\n";
            buttonOutput_SVS.UseVisualStyleBackColor = true;
            buttonOutput_SVS.Click += buttonOutput_SVS_Click;
            // 
            // textBoxCond_SVS
            // 
            textBoxCond_SVS.BackColor = SystemColors.Control;
            textBoxCond_SVS.BorderStyle = BorderStyle.None;
            textBoxCond_SVS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxCond_SVS.Location = new Point(13, 17);
            textBoxCond_SVS.Multiline = true;
            textBoxCond_SVS.Name = "textBoxCond_SVS";
            textBoxCond_SVS.ReadOnly = true;
            textBoxCond_SVS.Size = new Size(428, 193);
            textBoxCond_SVS.TabIndex = 1;
            textBoxCond_SVS.Text = "Вычислить выражение по формуле:";
            // 
            // textBoxInput_SVS
            // 
            textBoxInput_SVS.BackColor = SystemColors.Control;
            textBoxInput_SVS.BorderStyle = BorderStyle.None;
            textBoxInput_SVS.Location = new Point(13, 274);
            textBoxInput_SVS.Name = "textBoxInput_SVS";
            textBoxInput_SVS.ReadOnly = true;
            textBoxInput_SVS.Size = new Size(271, 20);
            textBoxInput_SVS.TabIndex = 2;
            textBoxInput_SVS.Text = "Ввод данных:";
            // 
            // textBoxOutput_SVS
            // 
            textBoxOutput_SVS.BackColor = SystemColors.Control;
            textBoxOutput_SVS.BorderStyle = BorderStyle.None;
            textBoxOutput_SVS.Location = new Point(498, 274);
            textBoxOutput_SVS.Name = "textBoxOutput_SVS";
            textBoxOutput_SVS.ReadOnly = true;
            textBoxOutput_SVS.Size = new Size(271, 20);
            textBoxOutput_SVS.TabIndex = 3;
            textBoxOutput_SVS.Text = "Вывод данных:";
            // 
            // textBoxX_SVS
            // 
            textBoxX_SVS.BackColor = SystemColors.Menu;
            textBoxX_SVS.BorderStyle = BorderStyle.None;
            textBoxX_SVS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxX_SVS.Location = new Point(146, 322);
            textBoxX_SVS.Name = "textBoxX_SVS";
            textBoxX_SVS.ReadOnly = true;
            textBoxX_SVS.Size = new Size(18, 27);
            textBoxX_SVS.TabIndex = 4;
            textBoxX_SVS.Text = "X";
            // 
            // textBoxIntX_SVS
            // 
            textBoxIntX_SVS.Location = new Point(114, 355);
            textBoxIntX_SVS.Name = "textBoxIntX_SVS";
            textBoxIntX_SVS.Size = new Size(77, 27);
            textBoxIntX_SVS.TabIndex = 5;
            textBoxIntX_SVS.KeyPress += textBoxIntX_KeyPress;
            // 
            // textBoxRes_SVS
            // 
            textBoxRes_SVS.BackColor = SystemColors.Control;
            textBoxRes_SVS.BorderStyle = BorderStyle.None;
            textBoxRes_SVS.Location = new Point(595, 322);
            textBoxRes_SVS.Name = "textBoxRes_SVS";
            textBoxRes_SVS.ReadOnly = true;
            textBoxRes_SVS.Size = new Size(113, 20);
            textBoxRes_SVS.TabIndex = 6;
            textBoxRes_SVS.Text = "Результат:";
            // 
            // textBoxResult_SVS
            // 
            textBoxResult_SVS.Location = new Point(557, 355);
            textBoxResult_SVS.Name = "textBoxResult_SVS";
            textBoxResult_SVS.ReadOnly = true;
            textBoxResult_SVS.Size = new Size(151, 27);
            textBoxResult_SVS.TabIndex = 7;
            // 
            // pictureBoxFormula_SVS
            // 
            pictureBoxFormula_SVS.Image = (Image)resources.GetObject("pictureBoxFormula_SVS.Image");
            pictureBoxFormula_SVS.Location = new Point(361, 17);
            pictureBoxFormula_SVS.Name = "pictureBoxFormula_SVS";
            pictureBoxFormula_SVS.Size = new Size(139, 72);
            pictureBoxFormula_SVS.TabIndex = 8;
            pictureBoxFormula_SVS.TabStop = false;
            // 
            // textBoxCondition_SVS
            // 
            textBoxCondition_SVS.BackColor = SystemColors.Control;
            textBoxCondition_SVS.BorderStyle = BorderStyle.None;
            textBoxCondition_SVS.Location = new Point(19, 4);
            textBoxCondition_SVS.Name = "textBoxCondition_SVS";
            textBoxCondition_SVS.ReadOnly = true;
            textBoxCondition_SVS.Size = new Size(145, 20);
            textBoxCondition_SVS.TabIndex = 9;
            textBoxCondition_SVS.Text = "Условие:";
            // 
            // buttonQuestion_SVS
            // 
            buttonQuestion_SVS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonQuestion_SVS.Location = new Point(261, 367);
            buttonQuestion_SVS.Name = "buttonQuestion_SVS";
            buttonQuestion_SVS.Size = new Size(40, 34);
            buttonQuestion_SVS.TabIndex = 10;
            buttonQuestion_SVS.Text = "?";
            buttonQuestion_SVS.UseVisualStyleBackColor = true;
            buttonQuestion_SVS.Click += buttonQuestion_SVS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonQuestion_SVS);
            Controls.Add(textBoxCondition_SVS);
            Controls.Add(pictureBoxFormula_SVS);
            Controls.Add(textBoxResult_SVS);
            Controls.Add(textBoxRes_SVS);
            Controls.Add(textBoxIntX_SVS);
            Controls.Add(textBoxX_SVS);
            Controls.Add(textBoxOutput_SVS);
            Controls.Add(textBoxInput_SVS);
            Controls.Add(textBoxCond_SVS);
            Controls.Add(buttonOutput_SVS);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 14 | Стачинский В. С.";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_SVS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOutput_SVS;
        private TextBox textBoxCond_SVS;
        private TextBox textBoxInput_SVS;
        private TextBox textBoxOutput_SVS;
        private TextBox textBoxX_SVS;
        private TextBox textBoxIntX_SVS;
        private TextBox textBoxRes_SVS;
        private TextBox textBoxResult_SVS;
        private PictureBox pictureBoxFormula_SVS;
        private TextBox textBoxCondition_SVS;
        private Button buttonQuestion_SVS;
    }
}
