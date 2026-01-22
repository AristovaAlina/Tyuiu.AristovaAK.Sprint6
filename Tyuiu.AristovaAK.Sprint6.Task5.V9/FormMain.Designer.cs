namespace Tyuiu.AristovaAK.Sprint6.Task5.V9
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            buttonOpen_AAK = new Button();
            buttonInformation_AAK = new Button();
            buttonDone_AAK = new Button();
            groupBoxTask_AAK = new GroupBox();
            textBoxTask_AAK = new TextBox();
            panel2 = new Panel();
            chartResult_AAK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxResult_AAK = new GroupBox();
            dataGridViewResult_AAK = new DataGridView();
            panel1.SuspendLayout();
            groupBoxTask_AAK.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_AAK).BeginInit();
            groupBoxResult_AAK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_AAK).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonOpen_AAK);
            panel1.Controls.Add(buttonInformation_AAK);
            panel1.Controls.Add(buttonDone_AAK);
            panel1.Controls.Add(groupBoxTask_AAK);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1174, 157);
            panel1.TabIndex = 0;
            // 
            // buttonOpen_AAK
            // 
            buttonOpen_AAK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpen_AAK.BackColor = SystemColors.ActiveCaption;
            buttonOpen_AAK.Location = new Point(786, 30);
            buttonOpen_AAK.Name = "buttonOpen_AAK";
            buttonOpen_AAK.Size = new Size(185, 121);
            buttonOpen_AAK.TabIndex = 3;
            buttonOpen_AAK.Text = "Открыть файл";
            buttonOpen_AAK.UseVisualStyleBackColor = false;
            buttonOpen_AAK.Click += buttonOpen_AAK_Click;
            // 
            // buttonInformation_AAK
            // 
            buttonInformation_AAK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInformation_AAK.FlatStyle = FlatStyle.Flat;
            buttonInformation_AAK.Location = new Point(977, 30);
            buttonInformation_AAK.Name = "buttonInformation_AAK";
            buttonInformation_AAK.Size = new Size(185, 121);
            buttonInformation_AAK.TabIndex = 2;
            buttonInformation_AAK.Text = "Справка";
            buttonInformation_AAK.UseVisualStyleBackColor = true;
            buttonInformation_AAK.Click += buttonInformation_AAK_Click;
            // 
            // buttonDone_AAK
            // 
            buttonDone_AAK.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonDone_AAK.BackColor = SystemColors.Highlight;
            buttonDone_AAK.Location = new Point(618, 30);
            buttonDone_AAK.Name = "buttonDone_AAK";
            buttonDone_AAK.Size = new Size(162, 121);
            buttonDone_AAK.TabIndex = 1;
            buttonDone_AAK.Text = "Выполнить";
            buttonDone_AAK.UseVisualStyleBackColor = false;
            buttonDone_AAK.Click += buttonDone_AAK_Click;
            // 
            // groupBoxTask_AAK
            // 
            groupBoxTask_AAK.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxTask_AAK.Controls.Add(textBoxTask_AAK);
            groupBoxTask_AAK.Location = new Point(12, 12);
            groupBoxTask_AAK.Name = "groupBoxTask_AAK";
            groupBoxTask_AAK.Size = new Size(593, 139);
            groupBoxTask_AAK.TabIndex = 0;
            groupBoxTask_AAK.TabStop = false;
            groupBoxTask_AAK.Text = "Условие";
            // 
            // textBoxTask_AAK
            // 
            textBoxTask_AAK.Dock = DockStyle.Fill;
            textBoxTask_AAK.Location = new Point(3, 35);
            textBoxTask_AAK.Multiline = true;
            textBoxTask_AAK.Name = "textBoxTask_AAK";
            textBoxTask_AAK.ReadOnly = true;
            textBoxTask_AAK.Size = new Size(587, 101);
            textBoxTask_AAK.TabIndex = 0;
            textBoxTask_AAK.Text = "Прочитать данные из файла InPutFileTask5V9.txt. Вывести в dataGridView. Дан список из чисел. Вывести все элементы, равные 0.";
            // 
            // panel2
            // 
            panel2.Controls.Add(chartResult_AAK);
            panel2.Controls.Add(groupBoxResult_AAK);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 157);
            panel2.Name = "panel2";
            panel2.Size = new Size(1174, 572);
            panel2.TabIndex = 1;
            // 
            // chartResult_AAK
            // 
            chartArea1.Name = "ChartArea1";
            chartResult_AAK.ChartAreas.Add(chartArea1);
            chartResult_AAK.Dock = DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartResult_AAK.Legends.Add(legend1);
            chartResult_AAK.Location = new Point(281, 0);
            chartResult_AAK.Name = "chartResult_AAK";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult_AAK.Series.Add(series1);
            chartResult_AAK.Size = new Size(893, 572);
            chartResult_AAK.TabIndex = 1;
            chartResult_AAK.Text = "chart1";
            // 
            // groupBoxResult_AAK
            // 
            groupBoxResult_AAK.Controls.Add(dataGridViewResult_AAK);
            groupBoxResult_AAK.Dock = DockStyle.Left;
            groupBoxResult_AAK.Location = new Point(0, 0);
            groupBoxResult_AAK.Name = "groupBoxResult_AAK";
            groupBoxResult_AAK.Size = new Size(281, 572);
            groupBoxResult_AAK.TabIndex = 0;
            groupBoxResult_AAK.TabStop = false;
            groupBoxResult_AAK.Text = "Вывод данных";
            // 
            // dataGridViewResult_AAK
            // 
            dataGridViewResult_AAK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_AAK.ColumnHeadersVisible = false;
            dataGridViewResult_AAK.Dock = DockStyle.Fill;
            dataGridViewResult_AAK.Location = new Point(3, 35);
            dataGridViewResult_AAK.Name = "dataGridViewResult_AAK";
            dataGridViewResult_AAK.ReadOnly = true;
            dataGridViewResult_AAK.RowHeadersVisible = false;
            dataGridViewResult_AAK.RowHeadersWidth = 82;
            dataGridViewResult_AAK.Size = new Size(275, 534);
            dataGridViewResult_AAK.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 729);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1200, 800);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 9 | Аристова А. К.";
            panel1.ResumeLayout(false);
            groupBoxTask_AAK.ResumeLayout(false);
            groupBoxTask_AAK.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartResult_AAK).EndInit();
            groupBoxResult_AAK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_AAK).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBoxTask_AAK;
        private Panel panel2;
        private GroupBox groupBoxResult_AAK;
        private Button buttonOpen_AAK;
        private Button buttonInformation_AAK;
        private Button buttonDone_AAK;
        private TextBox textBoxTask_AAK;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_AAK;
        private DataGridView dataGridViewResult_AAK;
    }
}
