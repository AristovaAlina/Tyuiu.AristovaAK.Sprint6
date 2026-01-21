using Tyuiu.AristovaAK.Sprint6.Task3.V13.Lib;
namespace Tyuiu.AristovaAK.Sprint6.Task3.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] matrix =
            {
            {-7, 34, -2, 25, 5 },
            {-16, -12, 30, -3, 17},
            {3, -15, 12, 5, -5 },
            {17, 22, -3, 32, -11},
            {9, 28, 1, -9, -2}
            };

        private void buttonDone_AAK_Click(object sender, EventArgs e)
        {
            int[,] result = ds.Calculate(matrix);
            int rows = result.GetLength(0);
            int cols = result.GetLength(1);

            dataGridViewResult_AAK.RowCount = rows;
            dataGridViewResult_AAK.ColumnCount = cols;

            for (int i = 0; i < 5; i++)
            {
                dataGridViewResult_AAK.Columns[i].Width = 60;
                dataGridViewResult_AAK.Rows[i].Height = 60;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewResult_AAK.Rows[i].Cells[j].Value = result[i, j];
                }
            }

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            dataGridViewMatrix_AAK.RowCount = rows;
            dataGridViewMatrix_AAK.ColumnCount = cols;

            for (int i = 0; i < 5; i++)
            {
                dataGridViewMatrix_AAK.Columns[i].Width = 60;
                dataGridViewMatrix_AAK.Rows[i].Height = 60;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix_AAK.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

        }

        private void buttonHelp_AAK_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнила студентка группы СМАРТб-25-1 Аристова Алина Константиновна", "Сообщение");
        }
    }
}
