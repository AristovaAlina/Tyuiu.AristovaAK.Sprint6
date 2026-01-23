namespace Tyuiu.AristovaAK.Sprint6.Task6.V7
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonOK_AAK = new Button();
            textBoxInfo_AAK = new TextBox();
            pictureBoxAvatar_AAK = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_AAK).BeginInit();
            SuspendLayout();
            // 
            // buttonOK_AAK
            // 
            buttonOK_AAK.Location = new Point(721, 380);
            buttonOK_AAK.Name = "buttonOK_AAK";
            buttonOK_AAK.Size = new Size(150, 46);
            buttonOK_AAK.TabIndex = 1;
            buttonOK_AAK.Text = "Ok";
            buttonOK_AAK.UseVisualStyleBackColor = true;
            buttonOK_AAK.Click += buttonOK_AAK_Click;
            // 
            // textBoxInfo_AAK
            // 
            textBoxInfo_AAK.BorderStyle = BorderStyle.None;
            textBoxInfo_AAK.Location = new Point(243, 57);
            textBoxInfo_AAK.Multiline = true;
            textBoxInfo_AAK.Name = "textBoxInfo_AAK";
            textBoxInfo_AAK.ReadOnly = true;
            textBoxInfo_AAK.Size = new Size(628, 272);
            textBoxInfo_AAK.TabIndex = 3;
            textBoxInfo_AAK.Text = resources.GetString("textBoxInfo_AAK.Text");
            // 
            // pictureBoxAvatar_AAK
            // 
            pictureBoxAvatar_AAK.Image = (Image)resources.GetObject("pictureBoxAvatar_AAK.Image");
            pictureBoxAvatar_AAK.Location = new Point(23, 57);
            pictureBoxAvatar_AAK.Name = "pictureBoxAvatar_AAK";
            pictureBoxAvatar_AAK.Size = new Size(200, 272);
            pictureBoxAvatar_AAK.TabIndex = 0;
            pictureBoxAvatar_AAK.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 429);
            Controls.Add(buttonOK_AAK);
            Controls.Add(textBoxInfo_AAK);
            Controls.Add(pictureBoxAvatar_AAK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            Padding = new Padding(20, 0, 0, 0);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_AAK).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonOK_AAK;
        private TextBox textBoxInfo_AAK;
        private PictureBox pictureBoxAvatar_AAK;
    }
}