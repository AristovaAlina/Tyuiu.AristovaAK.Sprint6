namespace Tyuiu.AristovaAK.Sprint6.Task1.V6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_AAK = new GroupBox();
            pictureBoxFormula_AAK = new PictureBox();
            textBoxTask_AAK = new TextBox();
            groupBoxInput_AAK = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            textBoxStopValue_AAK = new TextBox();
            textBoxStartValue_AAK = new TextBox();
            groupBoxResult_AAK = new GroupBox();
            dataGridViewFunction_AAK = new DataGridView();
            chartFunction_AAK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label3 = new Label();
            buttonInformation_AAK = new Button();
            buttonResult_AAK = new Button();
            ColumnX = new DataGridViewTextBoxColumn();
            ColumnFx = new DataGridViewTextBoxColumn();
            groupBoxTask_AAK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_AAK).BeginInit();
            groupBoxInput_AAK.SuspendLayout();
            groupBoxResult_AAK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_AAK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_AAK).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_AAK
            // 
            groupBoxTask_AAK.Controls.Add(pictureBoxFormula_AAK);
            groupBoxTask_AAK.Controls.Add(textBoxTask_AAK);
            groupBoxTask_AAK.Location = new Point(12, 12);
            groupBoxTask_AAK.Name = "groupBoxTask_AAK";
            groupBoxTask_AAK.Size = new Size(814, 377);
            groupBoxTask_AAK.TabIndex = 0;
            groupBoxTask_AAK.TabStop = false;
            groupBoxTask_AAK.Text = "Условие";
            // 
            // pictureBoxFormula_AAK
            // 
            pictureBoxFormula_AAK.Image = (Image)resources.GetObject("pictureBoxFormula_AAK.Image");
            pictureBoxFormula_AAK.Location = new Point(61, 278);
            pictureBoxFormula_AAK.Name = "pictureBoxFormula_AAK";
            pictureBoxFormula_AAK.Size = new Size(666, 72);
            pictureBoxFormula_AAK.TabIndex = 1;
            pictureBoxFormula_AAK.TabStop = false;
            // 
            // textBoxTask_AAK
            // 
            textBoxTask_AAK.Location = new Point(6, 43);
            textBoxTask_AAK.Multiline = true;
            textBoxTask_AAK.Name = "textBoxTask_AAK";
            textBoxTask_AAK.PlaceholderText = "FDSFDFSDF";
            textBoxTask_AAK.ReadOnly = true;
            textBoxTask_AAK.Size = new Size(802, 213);
            textBoxTask_AAK.TabIndex = 0;
            textBoxTask_AAK.Text = "Протабулировать функцию на заданном диапазоне. Результат вывести в dataGridView. Построить график.";
            // 
            // groupBoxInput_AAK
            // 
            groupBoxInput_AAK.Controls.Add(label2);
            groupBoxInput_AAK.Controls.Add(label1);
            groupBoxInput_AAK.Controls.Add(textBoxStopValue_AAK);
            groupBoxInput_AAK.Controls.Add(textBoxStartValue_AAK);
            groupBoxInput_AAK.Location = new Point(12, 395);
            groupBoxInput_AAK.Name = "groupBoxInput_AAK";
            groupBoxInput_AAK.Size = new Size(465, 122);
            groupBoxInput_AAK.TabIndex = 1;
            groupBoxInput_AAK.TabStop = false;
            groupBoxInput_AAK.Text = "Ввод данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 32);
            label2.Name = "label2";
            label2.Size = new Size(147, 32);
            label2.TabIndex = 3;
            label2.Text = "Конец шага:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 32);
            label1.Name = "label1";
            label1.Size = new Size(139, 32);
            label1.TabIndex = 2;
            label1.Text = "Старт шага:";
            // 
            // textBoxStopValue_AAK
            // 
            textBoxStopValue_AAK.Location = new Point(238, 67);
            textBoxStopValue_AAK.Name = "textBoxStopValue_AAK";
            textBoxStopValue_AAK.Size = new Size(200, 39);
            textBoxStopValue_AAK.TabIndex = 1;
            // 
            // textBoxStartValue_AAK
            // 
            textBoxStartValue_AAK.Location = new Point(17, 64);
            textBoxStartValue_AAK.Name = "textBoxStartValue_AAK";
            textBoxStartValue_AAK.Size = new Size(200, 39);
            textBoxStartValue_AAK.TabIndex = 0;
            // 
            // groupBoxResult_AAK
            // 
            groupBoxResult_AAK.Controls.Add(dataGridViewFunction_AAK);
            groupBoxResult_AAK.Controls.Add(chartFunction_AAK);
            groupBoxResult_AAK.Controls.Add(label3);
            groupBoxResult_AAK.Location = new Point(832, 12);
            groupBoxResult_AAK.Name = "groupBoxResult_AAK";
            groupBoxResult_AAK.Size = new Size(930, 505);
            groupBoxResult_AAK.TabIndex = 2;
            groupBoxResult_AAK.TabStop = false;
            groupBoxResult_AAK.Text = "Вывод данных";
            // 
            // dataGridViewFunction_AAK
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewFunction_AAK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewFunction_AAK.ColumnHeadersHeight = 46;
            dataGridViewFunction_AAK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewFunction_AAK.Columns.AddRange(new DataGridViewColumn[] { ColumnX, ColumnFx });
            dataGridViewFunction_AAK.Location = new Point(10, 77);
            dataGridViewFunction_AAK.Name = "dataGridViewFunction_AAK";
            dataGridViewFunction_AAK.ReadOnly = true;
            dataGridViewFunction_AAK.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewFunction_AAK.RowHeadersVisible = false;
            dataGridViewFunction_AAK.RowHeadersWidth = 82;
            dataGridViewFunction_AAK.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewFunction_AAK.Size = new Size(200, 429);
            dataGridViewFunction_AAK.TabIndex = 4;
            // 
            // chartFunction_AAK
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_AAK.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartFunction_AAK.Legends.Add(legend1);
            chartFunction_AAK.Location = new Point(223, 77);
            chartFunction_AAK.Name = "chartFunction_AAK";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_AAK.Series.Add(series1);
            chartFunction_AAK.Size = new Size(707, 428);
            chartFunction_AAK.TabIndex = 3;
            chartFunction_AAK.Text = "chart1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 36);
            label3.Name = "label3";
            label3.Size = new Size(125, 32);
            label3.TabIndex = 1;
            label3.Text = "Результат:";
            // 
            // buttonInformation_AAK
            // 
            buttonInformation_AAK.BackColor = SystemColors.InactiveCaption;
            buttonInformation_AAK.Location = new Point(483, 409);
            buttonInformation_AAK.Name = "buttonInformation_AAK";
            buttonInformation_AAK.Size = new Size(150, 108);
            buttonInformation_AAK.TabIndex = 3;
            buttonInformation_AAK.Text = "Справка";
            buttonInformation_AAK.UseVisualStyleBackColor = false;
            buttonInformation_AAK.Click += buttonInformation_AAK_Click;
            // 
            // buttonResult_AAK
            // 
            buttonResult_AAK.BackColor = Color.SeaShell;
            buttonResult_AAK.Location = new Point(639, 409);
            buttonResult_AAK.Name = "buttonResult_AAK";
            buttonResult_AAK.Size = new Size(187, 108);
            buttonResult_AAK.TabIndex = 4;
            buttonResult_AAK.Text = "Выполнить";
            buttonResult_AAK.UseVisualStyleBackColor = false;
            buttonResult_AAK.Click += buttonResult_AAK_Click;
            buttonResult_AAK.MouseDown += buttonResult_AAK_MouseDown;
            buttonResult_AAK.MouseEnter += buttonResult_AAK_MouseEnter;
            buttonResult_AAK.MouseLeave += buttonResult_AAK_MouseLeave;
            // 
            // ColumnX
            // 
            ColumnX.HeaderText = "x";
            ColumnX.MinimumWidth = 10;
            ColumnX.Name = "ColumnX";
            ColumnX.ReadOnly = true;
            // 
            // ColumnFx
            // 
            ColumnFx.HeaderText = "F(x)";
            ColumnFx.MinimumWidth = 10;
            ColumnFx.Name = "ColumnFx";
            ColumnFx.ReadOnly = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1774, 529);
            Controls.Add(buttonResult_AAK);
            Controls.Add(buttonInformation_AAK);
            Controls.Add(groupBoxResult_AAK);
            Controls.Add(groupBoxInput_AAK);
            Controls.Add(groupBoxTask_AAK);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 18 | Аристова А. К.";
            groupBoxTask_AAK.ResumeLayout(false);
            groupBoxTask_AAK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_AAK).EndInit();
            groupBoxInput_AAK.ResumeLayout(false);
            groupBoxInput_AAK.PerformLayout();
            groupBoxResult_AAK.ResumeLayout(false);
            groupBoxResult_AAK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_AAK).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartFunction_AAK).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_AAK;
        private GroupBox groupBoxInput_AAK;
        private GroupBox groupBoxResult_AAK;
        private Button buttonInformation_AAK;
        private Button buttonResult_AAK;
        private TextBox textBoxTask_AAK;
        private TextBox textBoxStopValue_AAK;
        private TextBox textBoxStartValue_AAK;
        private PictureBox pictureBoxFormula_AAK;
        private Label label2;
        private Label label1;
        private Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_AAK;
        private DataGridView dataGridViewFunction_AAK;
        private DataGridViewTextBoxColumn ColumnX;
        private DataGridViewTextBoxColumn ColumnFx;
    }
}
