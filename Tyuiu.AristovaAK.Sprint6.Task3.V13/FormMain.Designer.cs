namespace Tyuiu.AristovaAK.Sprint6.Task3.V13
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxTask_AAK = new GroupBox();
            dataGridViewMatrix_AAK = new DataGridView();
            buttonHelp_AAK = new Button();
            buttonDone_AAK = new Button();
            textBoxTask_AAK = new TextBox();
            groupBoxResult_AAK = new GroupBox();
            dataGridViewResult_AAK = new DataGridView();
            labelResult_AAK = new Label();
            groupBoxTask_AAK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_AAK).BeginInit();
            groupBoxResult_AAK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_AAK).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_AAK
            // 
            groupBoxTask_AAK.Controls.Add(dataGridViewMatrix_AAK);
            groupBoxTask_AAK.Controls.Add(buttonHelp_AAK);
            groupBoxTask_AAK.Controls.Add(buttonDone_AAK);
            groupBoxTask_AAK.Controls.Add(textBoxTask_AAK);
            groupBoxTask_AAK.Location = new Point(12, 12);
            groupBoxTask_AAK.Name = "groupBoxTask_AAK";
            groupBoxTask_AAK.Size = new Size(769, 505);
            groupBoxTask_AAK.TabIndex = 0;
            groupBoxTask_AAK.TabStop = false;
            groupBoxTask_AAK.Text = "Условие";
            // 
            // dataGridViewMatrix_AAK
            // 
            dataGridViewMatrix_AAK.ColumnHeadersHeight = 60;
            dataGridViewMatrix_AAK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewMatrix_AAK.ColumnHeadersVisible = false;
            dataGridViewMatrix_AAK.Location = new Point(16, 162);
            dataGridViewMatrix_AAK.Name = "dataGridViewMatrix_AAK";
            dataGridViewMatrix_AAK.ReadOnly = true;
            dataGridViewMatrix_AAK.RowHeadersVisible = false;
            dataGridViewMatrix_AAK.RowHeadersWidth = 82;
            dataGridViewMatrix_AAK.ScrollBars = ScrollBars.None;
            dataGridViewMatrix_AAK.Size = new Size(300, 300);
            dataGridViewMatrix_AAK.TabIndex = 3;
            // 
            // buttonHelp_AAK
            // 
            buttonHelp_AAK.FlatStyle = FlatStyle.Flat;
            buttonHelp_AAK.Location = new Point(551, 440);
            buttonHelp_AAK.Name = "buttonHelp_AAK";
            buttonHelp_AAK.Size = new Size(47, 46);
            buttonHelp_AAK.TabIndex = 2;
            buttonHelp_AAK.Text = "?";
            buttonHelp_AAK.UseVisualStyleBackColor = true;
            buttonHelp_AAK.Click += buttonHelp_AAK_Click_1;
            // 
            // buttonDone_AAK
            // 
            buttonDone_AAK.Location = new Point(604, 440);
            buttonDone_AAK.Name = "buttonDone_AAK";
            buttonDone_AAK.Size = new Size(150, 46);
            buttonDone_AAK.TabIndex = 1;
            buttonDone_AAK.Text = "Выполнить";
            buttonDone_AAK.UseVisualStyleBackColor = true;
            buttonDone_AAK.Click += buttonDone_AAK_Click;
            // 
            // textBoxTask_AAK
            // 
            textBoxTask_AAK.Location = new Point(16, 51);
            textBoxTask_AAK.Multiline = true;
            textBoxTask_AAK.Name = "textBoxTask_AAK";
            textBoxTask_AAK.ReadOnly = true;
            textBoxTask_AAK.Size = new Size(701, 105);
            textBoxTask_AAK.TabIndex = 0;
            textBoxTask_AAK.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию во втором столбце. Результат вывести в DataGridView.";
            // 
            // groupBoxResult_AAK
            // 
            groupBoxResult_AAK.Controls.Add(dataGridViewResult_AAK);
            groupBoxResult_AAK.Controls.Add(labelResult_AAK);
            groupBoxResult_AAK.Location = new Point(787, 12);
            groupBoxResult_AAK.Name = "groupBoxResult_AAK";
            groupBoxResult_AAK.Size = new Size(375, 505);
            groupBoxResult_AAK.TabIndex = 1;
            groupBoxResult_AAK.TabStop = false;
            groupBoxResult_AAK.Text = "Вывод данных";
            // 
            // dataGridViewResult_AAK
            // 
            dataGridViewResult_AAK.ColumnHeadersHeight = 60;
            dataGridViewResult_AAK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewResult_AAK.ColumnHeadersVisible = false;
            dataGridViewResult_AAK.Location = new Point(15, 88);
            dataGridViewResult_AAK.Name = "dataGridViewResult_AAK";
            dataGridViewResult_AAK.ReadOnly = true;
            dataGridViewResult_AAK.RowHeadersVisible = false;
            dataGridViewResult_AAK.RowHeadersWidth = 82;
            dataGridViewResult_AAK.ScrollBars = ScrollBars.None;
            dataGridViewResult_AAK.Size = new Size(300, 300);
            dataGridViewResult_AAK.TabIndex = 1;
            // 
            // labelResult_AAK
            // 
            labelResult_AAK.AutoSize = true;
            labelResult_AAK.Location = new Point(15, 41);
            labelResult_AAK.Name = "labelResult_AAK";
            labelResult_AAK.Size = new Size(120, 32);
            labelResult_AAK.TabIndex = 0;
            labelResult_AAK.Text = "Результат";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 529);
            Controls.Add(groupBoxResult_AAK);
            Controls.Add(groupBoxTask_AAK);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 13 | Аристова А. К.";
            Load += FormMain_Load;
            groupBoxTask_AAK.ResumeLayout(false);
            groupBoxTask_AAK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_AAK).EndInit();
            groupBoxResult_AAK.ResumeLayout(false);
            groupBoxResult_AAK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_AAK).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_AAK;
        private DataGridView dataGridViewMatrix_AAK;
        private Button buttonHelp_AAK;
        private Button buttonDone_AAK;
        private TextBox textBoxTask_AAK;
        private GroupBox groupBoxResult_AAK;
        private DataGridView dataGridViewResult_AAK;
        private Label labelResult_AAK;
    }
}
