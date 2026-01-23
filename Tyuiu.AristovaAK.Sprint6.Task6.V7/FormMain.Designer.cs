namespace Tyuiu.AristovaAK.Sprint6.Task6.V7
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTask_AAK = new Panel();
            buttonHelp_AAK = new Button();
            groupBoxTask_AAK = new GroupBox();
            textBoxTask_AAK = new TextBox();
            buttonDone_AAK = new Button();
            buttonOpenFile_AAK = new Button();
            panelNums_AAK = new Panel();
            groupBoxResult_AAK = new GroupBox();
            textBoxOutPutData_AAK = new TextBox();
            groupBoxInput_AAK = new GroupBox();
            textBoxLoadFromFile_AAK = new TextBox();
            openFileDialogTask_AAK = new OpenFileDialog();
            toolTip_AAK = new ToolTip(components);
            panelTask_AAK.SuspendLayout();
            groupBoxTask_AAK.SuspendLayout();
            panelNums_AAK.SuspendLayout();
            groupBoxResult_AAK.SuspendLayout();
            groupBoxInput_AAK.SuspendLayout();
            SuspendLayout();
            // 
            // panelTask_AAK
            // 
            panelTask_AAK.Controls.Add(buttonHelp_AAK);
            panelTask_AAK.Controls.Add(groupBoxTask_AAK);
            panelTask_AAK.Controls.Add(buttonDone_AAK);
            panelTask_AAK.Controls.Add(buttonOpenFile_AAK);
            panelTask_AAK.Dock = DockStyle.Top;
            panelTask_AAK.Location = new Point(0, 0);
            panelTask_AAK.Name = "panelTask_AAK";
            panelTask_AAK.Size = new Size(1174, 274);
            panelTask_AAK.TabIndex = 0;
            // 
            // buttonHelp_AAK
            // 
            buttonHelp_AAK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_AAK.Image = (Image)resources.GetObject("buttonHelp_AAK.Image");
            buttonHelp_AAK.Location = new Point(1005, 12);
            buttonHelp_AAK.Name = "buttonHelp_AAK";
            buttonHelp_AAK.Size = new Size(157, 115);
            buttonHelp_AAK.TabIndex = 2;
            toolTip_AAK.SetToolTip(buttonHelp_AAK, "Сведения о программе\r\n\r\n");
            buttonHelp_AAK.UseVisualStyleBackColor = true;
            buttonHelp_AAK.Click += buttonHelp_AAK_Click;
            // 
            // groupBoxTask_AAK
            // 
            groupBoxTask_AAK.Controls.Add(textBoxTask_AAK);
            groupBoxTask_AAK.Dock = DockStyle.Bottom;
            groupBoxTask_AAK.Location = new Point(0, 124);
            groupBoxTask_AAK.Name = "groupBoxTask_AAK";
            groupBoxTask_AAK.Size = new Size(1174, 150);
            groupBoxTask_AAK.TabIndex = 3;
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
            textBoxTask_AAK.Size = new Size(1168, 112);
            textBoxTask_AAK.TabIndex = 0;
            textBoxTask_AAK.Text = resources.GetString("textBoxTask_AAK.Text");
            // 
            // buttonDone_AAK
            // 
            buttonDone_AAK.Enabled = false;
            buttonDone_AAK.Image = (Image)resources.GetObject("buttonDone_AAK.Image");
            buttonDone_AAK.Location = new Point(200, 3);
            buttonDone_AAK.Name = "buttonDone_AAK";
            buttonDone_AAK.Size = new Size(169, 115);
            buttonDone_AAK.TabIndex = 1;
            toolTip_AAK.SetToolTip(buttonDone_AAK, "Производит поиск в файле\r\n");
            buttonDone_AAK.UseVisualStyleBackColor = true;
            buttonDone_AAK.Click += buttonDone_AAK_Click;
            // 
            // buttonOpenFile_AAK
            // 
            buttonOpenFile_AAK.Image = (Image)resources.GetObject("buttonOpenFile_AAK.Image");
            buttonOpenFile_AAK.Location = new Point(34, 3);
            buttonOpenFile_AAK.Name = "buttonOpenFile_AAK";
            buttonOpenFile_AAK.Size = new Size(160, 115);
            buttonOpenFile_AAK.TabIndex = 0;
            toolTip_AAK.SetToolTip(buttonOpenFile_AAK, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile_AAK.UseVisualStyleBackColor = true;
            buttonOpenFile_AAK.Click += buttonOpenFile_AAK_Click;
            // 
            // panelNums_AAK
            // 
            panelNums_AAK.Controls.Add(groupBoxResult_AAK);
            panelNums_AAK.Controls.Add(groupBoxInput_AAK);
            panelNums_AAK.Dock = DockStyle.Fill;
            panelNums_AAK.Location = new Point(0, 274);
            panelNums_AAK.Name = "panelNums_AAK";
            panelNums_AAK.Size = new Size(1174, 455);
            panelNums_AAK.TabIndex = 3;
            // 
            // groupBoxResult_AAK
            // 
            groupBoxResult_AAK.Controls.Add(textBoxOutPutData_AAK);
            groupBoxResult_AAK.Dock = DockStyle.Right;
            groupBoxResult_AAK.Location = new Point(553, 0);
            groupBoxResult_AAK.Name = "groupBoxResult_AAK";
            groupBoxResult_AAK.Size = new Size(621, 455);
            groupBoxResult_AAK.TabIndex = 3;
            groupBoxResult_AAK.TabStop = false;
            groupBoxResult_AAK.Text = "Вывод:";
            // 
            // textBoxOutPutData_AAK
            // 
            textBoxOutPutData_AAK.Dock = DockStyle.Fill;
            textBoxOutPutData_AAK.Location = new Point(3, 35);
            textBoxOutPutData_AAK.Multiline = true;
            textBoxOutPutData_AAK.Name = "textBoxOutPutData_AAK";
            textBoxOutPutData_AAK.ReadOnly = true;
            textBoxOutPutData_AAK.ScrollBars = ScrollBars.Vertical;
            textBoxOutPutData_AAK.Size = new Size(615, 417);
            textBoxOutPutData_AAK.TabIndex = 1;
            // 
            // groupBoxInput_AAK
            // 
            groupBoxInput_AAK.Controls.Add(textBoxLoadFromFile_AAK);
            groupBoxInput_AAK.Dock = DockStyle.Left;
            groupBoxInput_AAK.Location = new Point(0, 0);
            groupBoxInput_AAK.Name = "groupBoxInput_AAK";
            groupBoxInput_AAK.Size = new Size(547, 455);
            groupBoxInput_AAK.TabIndex = 2;
            groupBoxInput_AAK.TabStop = false;
            groupBoxInput_AAK.Text = "Ввод:";
            // 
            // textBoxLoadFromFile_AAK
            // 
            textBoxLoadFromFile_AAK.Dock = DockStyle.Fill;
            textBoxLoadFromFile_AAK.Location = new Point(3, 35);
            textBoxLoadFromFile_AAK.Multiline = true;
            textBoxLoadFromFile_AAK.Name = "textBoxLoadFromFile_AAK";
            textBoxLoadFromFile_AAK.ReadOnly = true;
            textBoxLoadFromFile_AAK.ScrollBars = ScrollBars.Vertical;
            textBoxLoadFromFile_AAK.Size = new Size(541, 417);
            textBoxLoadFromFile_AAK.TabIndex = 0;
            // 
            // openFileDialogTask_AAK
            // 
            openFileDialogTask_AAK.FileName = "openFileDialog1";
            // 
            // toolTip_AAK
            // 
            toolTip_AAK.ToolTipIcon = ToolTipIcon.Info;
            toolTip_AAK.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 729);
            Controls.Add(panelNums_AAK);
            Controls.Add(panelTask_AAK);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 7 | Аристова А. К.";
            panelTask_AAK.ResumeLayout(false);
            groupBoxTask_AAK.ResumeLayout(false);
            groupBoxTask_AAK.PerformLayout();
            panelNums_AAK.ResumeLayout(false);
            groupBoxResult_AAK.ResumeLayout(false);
            groupBoxResult_AAK.PerformLayout();
            groupBoxInput_AAK.ResumeLayout(false);
            groupBoxInput_AAK.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTask_AAK;
        private GroupBox groupBoxTask_AAK;
        private TextBox textBoxTask_AAK;
        private Button buttonHelp_AAK;
        private Button buttonDone_AAK;
        private Button buttonOpenFile_AAK;
        private Panel panelNums_AAK;
        private GroupBox groupBoxResult_AAK;
        private TextBox textBoxOutPutData_AAK;
        private GroupBox groupBoxInput_AAK;
        private TextBox textBoxLoadFromFile_AAK;
        private OpenFileDialog openFileDialogTask_AAK;
        private ToolTip toolTip_AAK;
    }
}
