namespace Tyuiu.StachinskiiVS.Sprint6.Task6.V30
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonYes_SVS = new Button();
            labelInfo_SVS = new Label();
            pictureBoxAvatar_SVS = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_SVS).BeginInit();
            SuspendLayout();
            // 
            // buttonYes_SVS
            // 
            buttonYes_SVS.Location = new Point(476, 238);
            buttonYes_SVS.Name = "buttonYes_SVS";
            buttonYes_SVS.Size = new Size(124, 47);
            buttonYes_SVS.TabIndex = 0;
            buttonYes_SVS.Text = "OK";
            buttonYes_SVS.UseVisualStyleBackColor = true;
            buttonYes_SVS.Click += buttonYes_SVS_Click;
            // 
            // labelInfo_SVS
            // 
            labelInfo_SVS.AutoSize = true;
            labelInfo_SVS.Location = new Point(185, 28);
            labelInfo_SVS.Name = "labelInfo_SVS";
            labelInfo_SVS.Size = new Size(393, 180);
            labelInfo_SVS.TabIndex = 1;
            labelInfo_SVS.Text = resources.GetString("labelInfo_SVS.Text");
            // 
            // pictureBoxAvatar_SVS
            // 
       
            pictureBoxAvatar_SVS.Location = new Point(12, 28);
            pictureBoxAvatar_SVS.Name = "pictureBoxAvatar_SVS";
            pictureBoxAvatar_SVS.Size = new Size(158, 213);
            pictureBoxAvatar_SVS.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar_SVS.TabIndex = 2;
            pictureBoxAvatar_SVS.TabStop = false;
            // 
            // ForSVSout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 306);
            Controls.Add(pictureBoxAvatar_SVS);
            Controls.Add(labelInfo_SVS);
            Controls.Add(buttonYes_SVS);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ForSVSout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_SVS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonYes_SVS;
        private Label labelInfo_SVS;
        private PictureBox pictureBoxAvatar_SVS;
    }
}
