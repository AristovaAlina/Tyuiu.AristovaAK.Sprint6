namespace Tyuiu.AristovaAK.Sprint6.Task4.V8
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask_AAK = new GroupBox();
            textBoxTask_AAK = new TextBox();
            groupBoxInput_AAK = new GroupBox();
            buttonInformation_AAK = new Button();
            buttonSave_AAK = new Button();
            textBoxStopValue_AAK = new TextBox();
            buttonDone_AAK = new Button();
            labelStopValue_AAK = new Label();
            labelStartValue_AAK = new Label();
            textBoxStartValue_AAK = new TextBox();
            tableLayoutPanelTask_AAK = new TableLayoutPanel();
            groupBoxResult_AAK = new GroupBox();
            chartResult_AAK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxResult_AAK = new TextBox();
            groupBoxTask_AAK.SuspendLayout();
            groupBoxInput_AAK.SuspendLayout();
            tableLayoutPanelTask_AAK.SuspendLayout();
            groupBoxResult_AAK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_AAK).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_AAK
            // 
            groupBoxTask_AAK.Controls.Add(textBoxTask_AAK);
            groupBoxTask_AAK.Dock = DockStyle.Fill;
            groupBoxTask_AAK.Location = new Point(3, 3);
            groupBoxTask_AAK.Name = "groupBoxTask_AAK";
            groupBoxTask_AAK.Size = new Size(781, 151);
            groupBoxTask_AAK.TabIndex = 0;
            groupBoxTask_AAK.TabStop = false;
            groupBoxTask_AAK.Text = "Условие";
            // 
            // textBoxTask_AAK
            // 
            textBoxTask_AAK.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxTask_AAK.Location = new Point(0, 38);
            textBoxTask_AAK.Multiline = true;
            textBoxTask_AAK.Name = "textBoxTask_AAK";
            textBoxTask_AAK.ReadOnly = true;
            textBoxTask_AAK.Size = new Size(775, 112);
            textBoxTask_AAK.TabIndex = 0;
            textBoxTask_AAK.Text = "Написать программу, которая выводит таблицу значений функции на заданном диапазоне. Результат вывести в TextBox, построить график функции и сохранить в файл по нажатию кнопки. ";
            // 
            // groupBoxInput_AAK
            // 
            groupBoxInput_AAK.Controls.Add(buttonInformation_AAK);
            groupBoxInput_AAK.Controls.Add(buttonSave_AAK);
            groupBoxInput_AAK.Controls.Add(textBoxStopValue_AAK);
            groupBoxInput_AAK.Controls.Add(buttonDone_AAK);
            groupBoxInput_AAK.Controls.Add(labelStopValue_AAK);
            groupBoxInput_AAK.Controls.Add(labelStartValue_AAK);
            groupBoxInput_AAK.Controls.Add(textBoxStartValue_AAK);
            groupBoxInput_AAK.Dock = DockStyle.Fill;
            groupBoxInput_AAK.Location = new Point(790, 3);
            groupBoxInput_AAK.Name = "groupBoxInput_AAK";
            groupBoxInput_AAK.Size = new Size(781, 151);
            groupBoxInput_AAK.TabIndex = 1;
            groupBoxInput_AAK.TabStop = false;
            groupBoxInput_AAK.Text = "Ввод данных";
            // 
            // buttonInformation_AAK
            // 
            buttonInformation_AAK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInformation_AAK.Cursor = Cursors.Hand;
            buttonInformation_AAK.FlatStyle = FlatStyle.Flat;
            buttonInformation_AAK.Location = new Point(627, 22);
            buttonInformation_AAK.Name = "buttonInformation_AAK";
            buttonInformation_AAK.Size = new Size(145, 113);
            buttonInformation_AAK.TabIndex = 12;
            buttonInformation_AAK.Text = "Справка";
            buttonInformation_AAK.UseVisualStyleBackColor = true;
            buttonInformation_AAK.Click += buttonInformation_AAK_Click;
            // 
            // buttonSave_AAK
            // 
            buttonSave_AAK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave_AAK.BackColor = SystemColors.ActiveCaption;
            buttonSave_AAK.Cursor = Cursors.Hand;
            buttonSave_AAK.Location = new Point(483, 22);
            buttonSave_AAK.Name = "buttonSave_AAK";
            buttonSave_AAK.Size = new Size(138, 113);
            buttonSave_AAK.TabIndex = 11;
            buttonSave_AAK.Text = "Сохранить";
            buttonSave_AAK.UseVisualStyleBackColor = false;
            buttonSave_AAK.Click += buttonSave_AAK_Click;
            // 
            // textBoxStopValue_AAK
            // 
            textBoxStopValue_AAK.Location = new Point(163, 75);
            textBoxStopValue_AAK.Name = "textBoxStopValue_AAK";
            textBoxStopValue_AAK.Size = new Size(146, 39);
            textBoxStopValue_AAK.TabIndex = 10;
            // 
            // buttonDone_AAK
            // 
            buttonDone_AAK.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonDone_AAK.BackColor = SystemColors.MenuHighlight;
            buttonDone_AAK.Cursor = Cursors.Hand;
            buttonDone_AAK.Location = new Point(316, 22);
            buttonDone_AAK.Name = "buttonDone_AAK";
            buttonDone_AAK.Size = new Size(161, 113);
            buttonDone_AAK.TabIndex = 8;
            buttonDone_AAK.Text = "Выполнить";
            buttonDone_AAK.UseVisualStyleBackColor = false;
            buttonDone_AAK.Click += buttonDone_AAK_Click;
            // 
            // labelStopValue_AAK
            // 
            labelStopValue_AAK.AutoSize = true;
            labelStopValue_AAK.Location = new Point(163, 38);
            labelStopValue_AAK.Name = "labelStopValue_AAK";
            labelStopValue_AAK.Size = new Size(147, 32);
            labelStopValue_AAK.TabIndex = 6;
            labelStopValue_AAK.Text = "Конец шага:";
            // 
            // labelStartValue_AAK
            // 
            labelStartValue_AAK.AutoSize = true;
            labelStartValue_AAK.Location = new Point(10, 40);
            labelStartValue_AAK.Name = "labelStartValue_AAK";
            labelStartValue_AAK.Size = new Size(139, 32);
            labelStartValue_AAK.TabIndex = 5;
            labelStartValue_AAK.Text = "Старт шага:";
            // 
            // textBoxStartValue_AAK
            // 
            textBoxStartValue_AAK.Location = new Point(10, 75);
            textBoxStartValue_AAK.Name = "textBoxStartValue_AAK";
            textBoxStartValue_AAK.Size = new Size(147, 39);
            textBoxStartValue_AAK.TabIndex = 3;
            // 
            // tableLayoutPanelTask_AAK
            // 
            tableLayoutPanelTask_AAK.ColumnCount = 2;
            tableLayoutPanelTask_AAK.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTask_AAK.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelTask_AAK.Controls.Add(groupBoxTask_AAK, 0, 0);
            tableLayoutPanelTask_AAK.Controls.Add(groupBoxInput_AAK, 1, 0);
            tableLayoutPanelTask_AAK.Dock = DockStyle.Top;
            tableLayoutPanelTask_AAK.Location = new Point(0, 0);
            tableLayoutPanelTask_AAK.Name = "tableLayoutPanelTask_AAK";
            tableLayoutPanelTask_AAK.RowCount = 1;
            tableLayoutPanelTask_AAK.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelTask_AAK.Size = new Size(1574, 157);
            tableLayoutPanelTask_AAK.TabIndex = 1;
            // 
            // groupBoxResult_AAK
            // 
            groupBoxResult_AAK.Controls.Add(chartResult_AAK);
            groupBoxResult_AAK.Controls.Add(textBoxResult_AAK);
            groupBoxResult_AAK.Dock = DockStyle.Fill;
            groupBoxResult_AAK.Location = new Point(0, 157);
            groupBoxResult_AAK.Name = "groupBoxResult_AAK";
            groupBoxResult_AAK.Size = new Size(1574, 754);
            groupBoxResult_AAK.TabIndex = 3;
            groupBoxResult_AAK.TabStop = false;
            groupBoxResult_AAK.Text = "Вывод данных";
            // 
            // chartResult_AAK
            // 
            chartArea1.Name = "ChartArea1";
            chartResult_AAK.ChartAreas.Add(chartArea1);
            chartResult_AAK.Dock = DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartResult_AAK.Legends.Add(legend1);
            chartResult_AAK.Location = new Point(287, 35);
            chartResult_AAK.Name = "chartResult_AAK";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult_AAK.Series.Add(series1);
            chartResult_AAK.Size = new Size(1284, 716);
            chartResult_AAK.TabIndex = 1;
            chartResult_AAK.Text = "chartResult";
            title1.Font = new Font("Microsoft Sans Serif", 12F);
            title1.Name = "Title1";
            title1.Text = "График функции";
            chartResult_AAK.Titles.Add(title1);
            // 
            // textBoxResult_AAK
            // 
            textBoxResult_AAK.Dock = DockStyle.Left;
            textBoxResult_AAK.Location = new Point(3, 35);
            textBoxResult_AAK.Multiline = true;
            textBoxResult_AAK.Name = "textBoxResult_AAK";
            textBoxResult_AAK.ReadOnly = true;
            textBoxResult_AAK.ScrollBars = ScrollBars.Both;
            textBoxResult_AAK.Size = new Size(284, 716);
            textBoxResult_AAK.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 911);
            Controls.Add(groupBoxResult_AAK);
            Controls.Add(tableLayoutPanelTask_AAK);
            MinimumSize = new Size(1600, 900);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 8 | Аристова А. К.";
            groupBoxTask_AAK.ResumeLayout(false);
            groupBoxTask_AAK.PerformLayout();
            groupBoxInput_AAK.ResumeLayout(false);
            groupBoxInput_AAK.PerformLayout();
            tableLayoutPanelTask_AAK.ResumeLayout(false);
            groupBoxResult_AAK.ResumeLayout(false);
            groupBoxResult_AAK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult_AAK).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_AAK;
        private TextBox textBoxTask_AAK;
        private GroupBox groupBoxInput_AAK;
        private Label labelStopValue_AAK;
        private Label labelStartValue_AAK;
        private TextBox textBoxStartValue_AAK;
        private Button buttonDone_AAK;
        private TextBox textBoxStopValue_AAK;
        private Button buttonInformation_AAK;
        private Button buttonSave_AAK;
        private TableLayoutPanel tableLayoutPanelTask_AAK;
        private GroupBox groupBoxResult_AAK;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_AAK;
        private TextBox textBoxResult_AAK;
    }
}
