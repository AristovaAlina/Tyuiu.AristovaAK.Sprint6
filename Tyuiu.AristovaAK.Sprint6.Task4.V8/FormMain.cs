using Tyuiu.AristovaAK.Sprint6.Task4.V8.Lib;
namespace Tyuiu.AristovaAK.Sprint6.Task4.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_AAK_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStartValue_AAK.Text);
                int stop = Convert.ToInt32(textBoxStopValue_AAK.Text);
                int len = ds.GetMassFunction(start, stop).Length;

                double[] valueArray = ds.GetMassFunction(start, stop);

                this.chartResult_AAK.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_AAK.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_AAK.Text = "";
                chartResult_AAK.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartResult_AAK.Series[0].Points.AddXY(start, valueArray[i]);
                    textBoxResult_AAK.AppendText(valueArray[i] + Environment.NewLine);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSave_AAK_Click(object sender, EventArgs e)
        {
            try
            {
                string tempDir = Path.GetTempPath();
                string fileName = "OutPutFileTask4V8.txt";
                string path = Path.Combine(tempDir, fileName);

                File.WriteAllText(path, textBoxResult_AAK.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start("notepad.exe", path);

                    //System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    //txt.StartInfo.FileName = "notepad.exe";
                    //txt.StartInfo.Arguments = path;
                    //txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInformation_AAK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнила студентка группы СМАРТб-25-1 Аристова Алина Константиновна", "Сообщение");
        }
    }
}
