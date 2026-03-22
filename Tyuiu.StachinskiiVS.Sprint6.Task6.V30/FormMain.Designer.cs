namespace Tyuiu.StachinskiiVS.Sprint6.Task6.V30
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelBotton_SVS = new Panel();
            buttonHelp_SVS = new Button();
            buttonDone_SVS = new Button();
            buttonOpenFile_SVS = new Button();
            panelTask_SVS = new Panel();
            groupBoxTask_SVS = new GroupBox();
            labelTask_SVS = new Label();
            panelInputData_SVS = new Panel();
            groupBoxInputData_SVS = new GroupBox();
            textBoxInputData_SVS = new TextBox();
            splitter_SVS = new Splitter();
            panelResult_SVS = new Panel();
            groupBoxResult_SVS = new GroupBox();
            textBoxRsult_SVS = new TextBox();
            openFileDialogTask_SVS = new OpenFileDialog();
            toolTip_SVS = new ToolTip(components);
            panelBotton_SVS.SuspendLayout();
            panelTask_SVS.SuspendLayout();
            groupBoxTask_SVS.SuspendLayout();
            panelInputData_SVS.SuspendLayout();
            groupBoxInputData_SVS.SuspendLayout();
            panelResult_SVS.SuspendLayout();
            groupBoxResult_SVS.SuspendLayout();
            SuspendLayout();
            // 
            // panelBotton_SVS
            // 
            panelBotton_SVS.Controls.Add(buttonHelp_SVS);
            panelBotton_SVS.Controls.Add(buttonDone_SVS);
            panelBotton_SVS.Controls.Add(buttonOpenFile_SVS);
            panelBotton_SVS.Dock = DockStyle.Top;
            panelBotton_SVS.Location = new Point(0, 0);
            panelBotton_SVS.Name = "panelBotton_SVS";
            panelBotton_SVS.Size = new Size(1125, 96);
            panelBotton_SVS.TabIndex = 0;
            // 
            // buttonHelp_SVS
            // 
         
            buttonHelp_SVS.Location = new Point(1003, 11);
            buttonHelp_SVS.Name = "buttonHelp_SVS";
            buttonHelp_SVS.Size = new Size(96, 69);
            buttonHelp_SVS.TabIndex = 2;
            toolTip_SVS.SetToolTip(buttonHelp_SVS, "Сведение о программе");
            buttonHelp_SVS.UseVisualStyleBackColor = true;
            buttonHelp_SVS.Click += button3_Click;
            // 
            // buttonDone_SVS
            // 
        
            buttonDone_SVS.Location = new Point(152, 12);
            buttonDone_SVS.Name = "buttonDone_SVS";
            buttonDone_SVS.Size = new Size(125, 69);
            buttonDone_SVS.TabIndex = 1;
            toolTip_SVS.SetToolTip(buttonDone_SVS, "Производит поиск в файле вхождений символов\r\nи конкатенирует строки в которых находятся эти символы\r\n");
            buttonDone_SVS.UseVisualStyleBackColor = true;
            buttonDone_SVS.Click += buttonDone_SVS_Click;
            // 
            // buttonOpenFile_SVS
            // 
          
            buttonOpenFile_SVS.Location = new Point(12, 11);
            buttonOpenFile_SVS.Name = "buttonOpenFile_SVS";
            buttonOpenFile_SVS.Size = new Size(114, 69);
            buttonOpenFile_SVS.TabIndex = 0;
            toolTip_SVS.SetToolTip(buttonOpenFile_SVS, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile_SVS.UseVisualStyleBackColor = true;
            buttonOpenFile_SVS.Click += buttonOpenFile_SVS_Click;
            // 
            // panelTask_SVS
            // 
            panelTask_SVS.Controls.Add(groupBoxTask_SVS);
            panelTask_SVS.Dock = DockStyle.Top;
            panelTask_SVS.Location = new Point(0, 96);
            panelTask_SVS.Name = "panelTask_SVS";
            panelTask_SVS.Size = new Size(1125, 112);
            panelTask_SVS.TabIndex = 1;
            // 
            // groupBoxTask_SVS
            // 
            groupBoxTask_SVS.Controls.Add(labelTask_SVS);
            groupBoxTask_SVS.Dock = DockStyle.Fill;
            groupBoxTask_SVS.Location = new Point(0, 0);
            groupBoxTask_SVS.Name = "groupBoxTask_SVS";
            groupBoxTask_SVS.Size = new Size(1125, 112);
            groupBoxTask_SVS.TabIndex = 0;
            groupBoxTask_SVS.TabStop = false;
            groupBoxTask_SVS.Text = "Условие";
            // 
            // labelTask_SVS
            // 
            labelTask_SVS.AutoSize = true;
            labelTask_SVS.Dock = DockStyle.Fill;
            labelTask_SVS.Location = new Point(3, 23);
            labelTask_SVS.Name = "labelTask_SVS";
            labelTask_SVS.Size = new Size(664, 60);
            labelTask_SVS.TabIndex = 0;
            labelTask_SVS.Text = resources.GetString("labelTask_SVS.Text");
            // 
            // panelInputData_SVS
            // 
            panelInputData_SVS.Controls.Add(groupBoxInputData_SVS);
            panelInputData_SVS.Controls.Add(splitter_SVS);
            panelInputData_SVS.Dock = DockStyle.Left;
            panelInputData_SVS.Location = new Point(0, 208);
            panelInputData_SVS.Name = "panelInputData_SVS";
            panelInputData_SVS.Size = new Size(518, 373);
            panelInputData_SVS.TabIndex = 2;
            // 
            // groupBoxInputData_SVS
            // 
            groupBoxInputData_SVS.Controls.Add(textBoxInputData_SVS);
            groupBoxInputData_SVS.Dock = DockStyle.Fill;
            groupBoxInputData_SVS.Location = new Point(4, 0);
            groupBoxInputData_SVS.Name = "groupBoxInputData_SVS";
            groupBoxInputData_SVS.Size = new Size(514, 373);
            groupBoxInputData_SVS.TabIndex = 1;
            groupBoxInputData_SVS.TabStop = false;
            groupBoxInputData_SVS.Text = "Ввод данных";
            // 
            // textBoxInputData_SVS
            // 
            textBoxInputData_SVS.Dock = DockStyle.Fill;
            textBoxInputData_SVS.Location = new Point(3, 23);
            textBoxInputData_SVS.Multiline = true;
            textBoxInputData_SVS.Name = "textBoxInputData_SVS";
            textBoxInputData_SVS.ReadOnly = true;
            textBoxInputData_SVS.ScrollBars = ScrollBars.Vertical;
            textBoxInputData_SVS.Size = new Size(508, 347);
            textBoxInputData_SVS.TabIndex = 0;
            // 
            // splitter_SVS
            // 
            splitter_SVS.Location = new Point(0, 0);
            splitter_SVS.Name = "splitter_SVS";
            splitter_SVS.Size = new Size(4, 373);
            splitter_SVS.TabIndex = 0;
            splitter_SVS.TabStop = false;
            // 
            // panelResult_SVS
            // 
            panelResult_SVS.Controls.Add(groupBoxResult_SVS);
            panelResult_SVS.Dock = DockStyle.Fill;
            panelResult_SVS.Location = new Point(518, 208);
            panelResult_SVS.Name = "panelResult_SVS";
            panelResult_SVS.Size = new Size(607, 373);
            panelResult_SVS.TabIndex = 3;
            // 
            // groupBoxResult_SVS
            // 
            groupBoxResult_SVS.Controls.Add(textBoxRsult_SVS);
            groupBoxResult_SVS.Dock = DockStyle.Fill;
            groupBoxResult_SVS.Location = new Point(0, 0);
            groupBoxResult_SVS.Name = "groupBoxResult_SVS";
            groupBoxResult_SVS.Size = new Size(607, 373);
            groupBoxResult_SVS.TabIndex = 0;
            groupBoxResult_SVS.TabStop = false;
            groupBoxResult_SVS.Text = "Вывод данных";
            // 
            // textBoxRsult_SVS
            // 
            textBoxRsult_SVS.Dock = DockStyle.Fill;
            textBoxRsult_SVS.Location = new Point(3, 23);
            textBoxRsult_SVS.Multiline = true;
            textBoxRsult_SVS.Name = "textBoxRsult_SVS";
            textBoxRsult_SVS.ReadOnly = true;
            textBoxRsult_SVS.ScrollBars = ScrollBars.Vertical;
            textBoxRsult_SVS.Size = new Size(601, 347);
            textBoxRsult_SVS.TabIndex = 0;
            // 
            // openFileDialogTask_SVS
            // 
            openFileDialogTask_SVS.FileName = "openFileDialog1";
            // 
            // toolTip_SVS
            // 
            toolTip_SVS.ToolTipIcon = ToolTipIcon.Info;
            toolTip_SVS.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 581);
            Controls.Add(panelResult_SVS);
            Controls.Add(panelInputData_SVS);
            Controls.Add(panelTask_SVS);
            Controls.Add(panelBotton_SVS);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 30 | Стачинский В.С.";
            panelBotton_SVS.ResumeLayout(false);
            panelTask_SVS.ResumeLayout(false);
            groupBoxTask_SVS.ResumeLayout(false);
            groupBoxTask_SVS.PerformLayout();
            panelInputData_SVS.ResumeLayout(false);
            groupBoxInputData_SVS.ResumeLayout(false);
            groupBoxInputData_SVS.PerformLayout();
            panelResult_SVS.ResumeLayout(false);
            groupBoxResult_SVS.ResumeLayout(false);
            groupBoxResult_SVS.PerformLayout();
            ResumeLayout(false);
        }

        private void buttonDone_SVS_Click(object sender, EventArgs e)
        {
            textBoxRsult_SVS.Text = ds.CollectTextFromFile(openFilePath);
        }



        #endregion

        private Panel panelBotton_SVS;
        private Panel panelTask_SVS;
        private Panel panelInputData_SVS;
        private Splitter splitter_SVS;
        private Panel panelResult_SVS;
        private GroupBox groupBoxTask_SVS;
        private Label labelTask_SVS;
        private GroupBox groupBoxInputData_SVS;
        private GroupBox groupBoxResult_SVS;
        private Button buttonHelp_SVS;
        private Button buttonDone_SVS;
        private Button buttonOpenFile_SVS;
        private ToolTip toolTip_SVS;
        private OpenFileDialog openFileDialogTask_SVS;
        private TextBox textBoxInputData_SVS;
        private TextBox textBoxRsult_SVS;
    }
}
