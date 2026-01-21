using Tyuiu.AristovaAK.Sprint6.Task2.V18.Lib;
namespace Tyuiu.AristovaAK.Sprint6.Task1.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonResult_AAK_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStartValue_AAK.Text);
                int stop = Convert.ToInt32(textBoxStopValue_AAK.Text);

                int len = ds.GetMassFunction(start, stop).Length;
                double[] ValueArray = ds.GetMassFunction(start, stop);

                this.chartFunction_AAK.Titles.Add("График заданной функции: ");

                this.chartFunction_AAK.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_AAK.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction_AAK.Rows.Add(Convert.ToString(start), Convert.ToString(ValueArray[i]));
                    this.chartFunction_AAK.Series[0].Points.AddXY(start, ValueArray[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInformation_AAK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы СМАРТб-25-1 Аристова Алина Константиновна", "Сообщение");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonResult_AAK_MouseEnter(object sender, EventArgs e)
        {
            buttonResult_AAK.BackColor = Color.Crimson;
        }

        private void buttonResult_AAK_MouseLeave(object sender, EventArgs e)
        {
            buttonResult_AAK.BackColor = Color.SeaShell; 
        }

        private void buttonResult_AAK_MouseDown(object sender, MouseEventArgs e)
        {
            buttonResult_AAK.BackColor = Color.DarkSeaGreen;
        }
    }
}