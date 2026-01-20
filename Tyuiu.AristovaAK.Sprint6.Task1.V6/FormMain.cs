using Tyuiu.AristovaAK.Sprint6.Task1.V6.Lib;
namespace Tyuiu.AristovaAK.Sprint6.Task1.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonResult_AAK_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStartValue_AAK.Text);
                int stop = Convert.ToInt32(textBoxStopValue_AAK.Text);
                string strLine;

                int len = ds.GetMassFunction(start, stop).Length;
                double[] ValueArray = ds.GetMassFunction(start, stop);
                textBoxResult_AAK.Text = "";
                textBoxResult_AAK.AppendText("+--------+--------+" + Environment.NewLine);
                textBoxResult_AAK.AppendText("|    x   |   f(x) |" + Environment.NewLine);
                textBoxResult_AAK.AppendText("+--------+--------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,5:d}   | {1,6:f2} |", start, ValueArray[i]);
                    textBoxResult_AAK.AppendText(strLine + Environment.NewLine);
                    start++;
                }
                textBoxResult_AAK.AppendText("+--------+--------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInformation_AAK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнила студентка группы СМАРТб-25-1 Аристова Алина Константиновна", "Сообщение");
        }
    }
}