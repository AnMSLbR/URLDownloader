namespace URLDownloader
{
    partial class MainWindow
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
            tb_URL = new TextBox();
            btn_Save = new Button();
            fbd_OutputPath = new FolderBrowserDialog();
            tb_OutputPath = new TextBox();
            btn_OutputPath = new Button();
            SuspendLayout();
            // 
            // tb_URL
            // 
            tb_URL.Location = new Point(12, 66);
            tb_URL.Name = "tb_URL";
            tb_URL.Size = new Size(294, 23);
            tb_URL.TabIndex = 0;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(231, 95);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(75, 23);
            btn_Save.TabIndex = 1;
            btn_Save.Text = "Скачать";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // tb_OutputPath
            // 
            tb_OutputPath.Location = new Point(12, 12);
            tb_OutputPath.Name = "tb_OutputPath";
            tb_OutputPath.Size = new Size(212, 23);
            tb_OutputPath.TabIndex = 2;
            // 
            // btn_OutputPath
            // 
            btn_OutputPath.Location = new Point(231, 12);
            btn_OutputPath.Name = "btn_OutputPath";
            btn_OutputPath.Size = new Size(75, 23);
            btn_OutputPath.TabIndex = 3;
            btn_OutputPath.Text = "...";
            btn_OutputPath.UseVisualStyleBackColor = true;
            btn_OutputPath.Click += btn_OutputPath_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 411);
            Controls.Add(btn_OutputPath);
            Controls.Add(tb_OutputPath);
            Controls.Add(btn_Save);
            Controls.Add(tb_URL);
            MaximizeBox = false;
            MaximumSize = new Size(350, 450);
            MinimumSize = new Size(350, 450);
            Name = "MainWindow";
            Text = "URLDownloader";
            Load += MainWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_URL;
        private Button btn_Save;
        private FolderBrowserDialog fbd_OutputPath;
        private TextBox tb_OutputPath;
        private Button btn_OutputPath;
    }
}