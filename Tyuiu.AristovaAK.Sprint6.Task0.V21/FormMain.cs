using Tyuiu.AristovaAK.Sprint6.Task0.V21.Lib;
namespace Tyuiu.AristovaAK.Sprint6.Task0.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxInput_AAK_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_AAK_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_AAK.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxX_AAK.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_AAK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студентка группы СМАРТб-25-1 Аристова Алина Константиновна", "Сообщение");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxX_AAK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
                e.Handled = true;
        }

        private void textBoxResult_AAK_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxX_AAK_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
