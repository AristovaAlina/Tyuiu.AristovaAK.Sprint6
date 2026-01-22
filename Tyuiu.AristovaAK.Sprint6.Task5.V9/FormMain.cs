using Tyuiu.AristovaAK.Sprint6.Task5.V9.Lib;
namespace Tyuiu.AristovaAK.Sprint6.Task5.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        private void buttonInformation_AAK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 6 выполнила студентка группы СМАРТб-25-1 Аристова Алина Константиновна", "Сообщение");
        }

        private void buttonDone_AAK_Click(object sender, EventArgs e)
        {
            dataGridViewResult_AAK.ColumnCount = 2;
            dataGridViewResult_AAK.Columns[0].Width = 50;
            dataGridViewResult_AAK.Columns[1].Width = 100;
            dataGridViewResult_AAK.Rows.Clear();

            this.chartResult_AAK.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartResult_AAK.ChartAreas[0].AxisY.Title = "Ось Y";

            chartResult_AAK.Series[0].Points.Clear();

            string tempDir = Path.GetTempPath();
            string fileName = "InPutFileTask5V9.txt";
            string path = Path.Combine(tempDir, fileName);

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_AAK.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartResult_AAK.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpen_AAK_Click(object sender, EventArgs e)
        {
            string tempDir = Path.GetTempPath();
            string fileName = "InPutFileTask5V9.txt";
            string path = Path.Combine(tempDir, fileName);
            System.Diagnostics.Process.Start("notepad.exe", path);
        }

    }
}

