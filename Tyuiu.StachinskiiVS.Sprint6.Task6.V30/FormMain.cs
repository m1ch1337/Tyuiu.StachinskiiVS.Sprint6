using Tyuiu.StachinskiiVS.Sprint6.Task6.V30.Lib;

namespace Tyuiu.StachinskiiVS.Sprint6.Task6.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void button3_Click(object sender, EventArgs e)
        {
            FormAbout formABout = new FormAbout();
            formABout.ShowDialog();
        }

        private void buttonOpenFile_SVS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SVS.ShowDialog();
            openFilePath = openFileDialogTask_SVS.FileName;

            textBoxInputData_SVS.Text = File.ReadAllText(openFilePath);
            groupBoxInputData_SVS.Text = groupBoxInputData_SVS.Text + " " + openFileDialogTask_SVS.FileName;
            buttonDone_SVS.Enabled = true;


        }
    }
}
