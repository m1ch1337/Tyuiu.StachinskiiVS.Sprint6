using Tyuiu.StachinskiiVS.Sprint6.Task0.V14.Lib;

namespace Tyuiu.StachinskiiVS.Sprint6.Task0.V14
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonOutput_SVS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_SVS.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxIntX_SVS.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxIntX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47) || (e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void buttonQuestion_SVS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИСПБ-24-1 Стачинский В.С.");
        }
    }
}