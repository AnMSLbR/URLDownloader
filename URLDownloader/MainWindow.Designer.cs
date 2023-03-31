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
            ofd_UrlList = new OpenFileDialog();
            tb_UrlList = new TextBox();
            btn_UrlList = new Button();
            btn_SaveAll = new Button();
            lbl_CounterLabel = new Label();
            lbl_FileCounter = new Label();
            SuspendLayout();
            // 
            // tb_URL
            // 
            tb_URL.Location = new Point(12, 82);
            tb_URL.Name = "tb_URL";
            tb_URL.Size = new Size(294, 23);
            tb_URL.TabIndex = 0;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(231, 111);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(75, 23);
            btn_Save.TabIndex = 1;
            btn_Save.Text = "Download";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_ClickAsync;
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
            // ofd_UrlList
            // 
            ofd_UrlList.FileName = "openFileDialog1";
            ofd_UrlList.Filter = "Текстовые файлы(*.txt)|*.txt";
            // 
            // tb_UrlList
            // 
            tb_UrlList.Location = new Point(12, 152);
            tb_UrlList.Name = "tb_UrlList";
            tb_UrlList.Size = new Size(212, 23);
            tb_UrlList.TabIndex = 4;
            // 
            // btn_UrlList
            // 
            btn_UrlList.Location = new Point(231, 153);
            btn_UrlList.Name = "btn_UrlList";
            btn_UrlList.Size = new Size(75, 23);
            btn_UrlList.TabIndex = 5;
            btn_UrlList.Text = "...";
            btn_UrlList.UseVisualStyleBackColor = true;
            btn_UrlList.Click += btn_UrlList_Click;
            // 
            // btn_SaveAll
            // 
            btn_SaveAll.Location = new Point(231, 182);
            btn_SaveAll.Name = "btn_SaveAll";
            btn_SaveAll.Size = new Size(75, 23);
            btn_SaveAll.TabIndex = 6;
            btn_SaveAll.Text = "Download";
            btn_SaveAll.UseVisualStyleBackColor = true;
            btn_SaveAll.Click += btn_SaveAll_Click;
            // 
            // lbl_CounterLabel
            // 
            lbl_CounterLabel.AutoSize = true;
            lbl_CounterLabel.Location = new Point(12, 387);
            lbl_CounterLabel.Name = "lbl_CounterLabel";
            lbl_CounterLabel.Size = new Size(72, 15);
            lbl_CounterLabel.TabIndex = 7;
            lbl_CounterLabel.Text = "Files loaded:";
            // 
            // lbl_FileCounter
            // 
            lbl_FileCounter.AutoSize = true;
            lbl_FileCounter.Location = new Point(90, 387);
            lbl_FileCounter.Name = "lbl_FileCounter";
            lbl_FileCounter.Size = new Size(0, 15);
            lbl_FileCounter.TabIndex = 8;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 411);
            Controls.Add(lbl_FileCounter);
            Controls.Add(lbl_CounterLabel);
            Controls.Add(btn_SaveAll);
            Controls.Add(btn_UrlList);
            Controls.Add(tb_UrlList);
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
        private OpenFileDialog ofd_UrlList;
        private TextBox tb_UrlList;
        private Button btn_UrlList;
        private Button btn_SaveAll;
        private Label lbl_CounterLabel;
        private Label lbl_FileCounter;
    }
}