namespace Tyuiu.AristovaAK.Sprint6.Task0.V21
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
            buttonDone_AAK = new Button();
            groupBoxTask_AAK = new GroupBox();
            textBoxTask_AAK = new TextBox();
            pictureBoxFormula_AAK = new PictureBox();
            buttonHelp_AAK = new Button();
            groupBoxInput_AAK = new GroupBox();
            labelVarX_AAK = new Label();
            textBoxX_AAK = new TextBox();
            groupBoxResult_AAK = new GroupBox();
            labelResult_AAK = new Label();
            textBoxResult_AAK = new TextBox();
            groupBoxTask_AAK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_AAK).BeginInit();
            groupBoxInput_AAK.SuspendLayout();
            groupBoxResult_AAK.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone_AAK
            // 
            buttonDone_AAK.Location = new Point(973, 471);
            buttonDone_AAK.Name = "buttonDone_AAK";
            buttonDone_AAK.Size = new Size(189, 46);
            buttonDone_AAK.TabIndex = 0;
            buttonDone_AAK.Text = "Выполнить";
            buttonDone_AAK.UseVisualStyleBackColor = true;
            buttonDone_AAK.Click += buttonDone_AAK_Click;
            // 
            // groupBoxTask_AAK
            // 
            groupBoxTask_AAK.Controls.Add(textBoxTask_AAK);
            groupBoxTask_AAK.Controls.Add(pictureBoxFormula_AAK);
            groupBoxTask_AAK.Location = new Point(12, 12);
            groupBoxTask_AAK.Name = "groupBoxTask_AAK";
            groupBoxTask_AAK.Size = new Size(1123, 287);
            groupBoxTask_AAK.TabIndex = 1;
            groupBoxTask_AAK.TabStop = false;
            groupBoxTask_AAK.Text = "Условие";
            groupBoxTask_AAK.Enter += groupBox1_Enter;
            // 
            // textBoxTask_AAK
            // 
            textBoxTask_AAK.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            textBoxTask_AAK.Location = new Point(27, 58);
            textBoxTask_AAK.Multiline = true;
            textBoxTask_AAK.Name = "textBoxTask_AAK";
            textBoxTask_AAK.ReadOnly = true;
            textBoxTask_AAK.Size = new Size(575, 211);
            textBoxTask_AAK.TabIndex = 1;
            textBoxTask_AAK.Text = "Вычислить значение выражения по формуле:";
            // 
            // pictureBoxFormula_AAK
            // 
            pictureBoxFormula_AAK.Image = (Image)resources.GetObject("pictureBoxFormula_AAK.Image");
            pictureBoxFormula_AAK.Location = new Point(691, 58);
            pictureBoxFormula_AAK.Name = "pictureBoxFormula_AAK";
            pictureBoxFormula_AAK.Size = new Size(432, 61);
            pictureBoxFormula_AAK.TabIndex = 0;
            pictureBoxFormula_AAK.TabStop = false;
            pictureBoxFormula_AAK.Click += pictureBox1_Click;
            // 
            // buttonHelp_AAK
            // 
            buttonHelp_AAK.Cursor = Cursors.Help;
            buttonHelp_AAK.FlatStyle = FlatStyle.Flat;
            buttonHelp_AAK.Location = new Point(915, 471);
            buttonHelp_AAK.Name = "buttonHelp_AAK";
            buttonHelp_AAK.Size = new Size(52, 46);
            buttonHelp_AAK.TabIndex = 2;
            buttonHelp_AAK.Text = "?";
            buttonHelp_AAK.UseVisualStyleBackColor = true;
            buttonHelp_AAK.Click += buttonHelp_AAK_Click;
            // 
            // groupBoxInput_AAK
            // 
            groupBoxInput_AAK.Controls.Add(labelVarX_AAK);
            groupBoxInput_AAK.Controls.Add(textBoxX_AAK);
            groupBoxInput_AAK.Location = new Point(15, 304);
            groupBoxInput_AAK.Name = "groupBoxInput_AAK";
            groupBoxInput_AAK.Size = new Size(657, 146);
            groupBoxInput_AAK.TabIndex = 3;
            groupBoxInput_AAK.TabStop = false;
            groupBoxInput_AAK.Text = "Ввод данных";
            groupBoxInput_AAK.Enter += groupBoxInput_AAK_Enter;
            // 
            // labelVarX_AAK
            // 
            labelVarX_AAK.AutoSize = true;
            labelVarX_AAK.Location = new Point(24, 45);
            labelVarX_AAK.Name = "labelVarX_AAK";
            labelVarX_AAK.Size = new Size(179, 32);
            labelVarX_AAK.TabIndex = 1;
            labelVarX_AAK.Text = "Переменная X:";
            // 
            // textBoxX_AAK
            // 
            textBoxX_AAK.Location = new Point(24, 80);
            textBoxX_AAK.Name = "textBoxX_AAK";
            textBoxX_AAK.Size = new Size(200, 39);
            textBoxX_AAK.TabIndex = 0;
            textBoxX_AAK.TextChanged += textBoxX_AAK_TextChanged;
            textBoxX_AAK.KeyPress += textBoxX_AAK_KeyPress;
            // 
            // groupBoxResult_AAK
            // 
            groupBoxResult_AAK.Controls.Add(labelResult_AAK);
            groupBoxResult_AAK.Controls.Add(textBoxResult_AAK);
            groupBoxResult_AAK.Location = new Point(703, 304);
            groupBoxResult_AAK.Name = "groupBoxResult_AAK";
            groupBoxResult_AAK.Size = new Size(432, 146);
            groupBoxResult_AAK.TabIndex = 4;
            groupBoxResult_AAK.TabStop = false;
            groupBoxResult_AAK.Text = "Вывод данных";
            // 
            // labelResult_AAK
            // 
            labelResult_AAK.AutoSize = true;
            labelResult_AAK.Location = new Point(20, 45);
            labelResult_AAK.Name = "labelResult_AAK";
            labelResult_AAK.Size = new Size(125, 32);
            labelResult_AAK.TabIndex = 1;
            labelResult_AAK.Text = "Результат:";
            labelResult_AAK.Click += label1_Click;
            // 
            // textBoxResult_AAK
            // 
            textBoxResult_AAK.Location = new Point(20, 80);
            textBoxResult_AAK.Name = "textBoxResult_AAK";
            textBoxResult_AAK.ReadOnly = true;
            textBoxResult_AAK.Size = new Size(200, 39);
            textBoxResult_AAK.TabIndex = 0;
            textBoxResult_AAK.TextChanged += textBoxResult_AAK_TextChanged;
            // 
            // FormMain
            // 
            AccessibleDescription = "";
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 529);
            Controls.Add(groupBoxResult_AAK);
            Controls.Add(groupBoxInput_AAK);
            Controls.Add(buttonHelp_AAK);
            Controls.Add(groupBoxTask_AAK);
            Controls.Add(buttonDone_AAK);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 21 | Аристова А. К.";
            Load += FormMain_Load;
            groupBoxTask_AAK.ResumeLayout(false);
            groupBoxTask_AAK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_AAK).EndInit();
            groupBoxInput_AAK.ResumeLayout(false);
            groupBoxInput_AAK.PerformLayout();
            groupBoxResult_AAK.ResumeLayout(false);
            groupBoxResult_AAK.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone_AAK;
        private GroupBox groupBoxTask_AAK;
        private PictureBox pictureBoxFormula_AAK;
        private TextBox textBoxTask_AAK;
        private Button buttonHelp_AAK;
        private GroupBox groupBoxInput_AAK;
        private GroupBox groupBoxResult_AAK;
        private TextBox textBoxX_AAK;
        private TextBox textBoxResult_AAK;
        private Label labelResult_AAK;
        private Label labelVarX_AAK;
    }
}
