using Tyuiu.AristovaAK.Sprint6.Task6.V7.Lib;
namespace Tyuiu.AristovaAK.Sprint6.Task6.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        string openFilePath;
        DataService ds = new DataService();
        private void buttonOpenFile_AAK_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_AAK.ShowDialog();
                openFilePath = openFileDialogTask_AAK.FileName;
                textBoxLoadFromFile_AAK.Text = File.ReadAllText(openFilePath);
                groupBoxResult_AAK.Text = groupBoxResult_AAK.Text + " " + openFileDialogTask_AAK.FileName;
                buttonDone_AAK.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Возникла ошибка при загрузке файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_AAK_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_AAK_Click(object sender, EventArgs e)
        {
            textBoxOutPutData_AAK.Text = ds.CollectTextFromFile(openFilePath);
        }
    }

}
