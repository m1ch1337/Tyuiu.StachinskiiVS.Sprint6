using Tyuiu.StachinskiiVS.Sprint6.Task2.V25.Lib;

namespace Tyuiu.StachinskiiVS.Sprint6.Task2.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonPerform_SVS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInputStart_SVS.Text);
                int stopStep = Convert.ToInt32(textBoxInputEnd_SVS.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] array = new double[len];
                array = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_SVS.Text = "";
                textBoxResult_SVS.AppendText("+------------+------------+" + Environment.NewLine);
                textBoxResult_SVS.AppendText("|      X     +     f(x)   +" + Environment.NewLine);
                textBoxResult_SVS.AppendText("+------------+------------+" + Environment.NewLine);
                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,5:d}      |   {1, 5:f2}     |", startStep, array[i]);
                    textBoxResult_SVS.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_SVS.AppendText("+------------+------------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxInputStart_SVS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxInputEnd_SVS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void buttonReference_SVS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИСПБ-24-1 Стачинский В.С.", "О программе", MessageBoxButtons.OK);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBoxThree_SVS_Enter(object sender, EventArgs e)
        {

        }
    }