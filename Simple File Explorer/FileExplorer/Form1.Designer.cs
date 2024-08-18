namespace FileExplorer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            backButton = new Button();
            nextButton = new Button();
            listView1 = new ListView();
            iconList = new ImageList(components);
            filePathTextBox = new TextBox();
            label1 = new Label();
            fileNameLabel = new Label();
            label3 = new Label();
            fileTypeLabel = new Label();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 0;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(897, 12);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(75, 23);
            nextButton.TabIndex = 1;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // listView1
            // 
            listView1.LargeImageList = iconList;
            listView1.Location = new Point(12, 41);
            listView1.Name = "listView1";
            listView1.Size = new Size(960, 516);
            listView1.SmallImageList = iconList;
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.ItemSelectionChanged += listView1_ItemSelectionChanged;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // iconList
            // 
            iconList.ColorDepth = ColorDepth.Depth32Bit;
            iconList.ImageStream = (ImageListStreamer)resources.GetObject("iconList.ImageStream");
            iconList.TransparentColor = Color.Transparent;
            iconList.Images.SetKeyName(0, "doc.png");
            iconList.Images.SetKeyName(1, "exe.png");
            iconList.Images.SetKeyName(2, "folder2.png");
            iconList.Images.SetKeyName(3, "folder64.png");
            iconList.Images.SetKeyName(4, "mp3.png");
            iconList.Images.SetKeyName(5, "mp4-.png");
            iconList.Images.SetKeyName(6, "pdf.png");
            iconList.Images.SetKeyName(7, "png.png");
            iconList.Images.SetKeyName(8, "txt.png");
            iconList.Images.SetKeyName(9, "unknown.png");
            iconList.Images.SetKeyName(10, "folder.png");
            // 
            // filePathTextBox
            // 
            filePathTextBox.Location = new Point(93, 12);
            filePathTextBox.Name = "filePathTextBox";
            filePathTextBox.Size = new Size(798, 23);
            filePathTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 572);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 4;
            label1.Text = "File Name";
            // 
            // fileNameLabel
            // 
            fileNameLabel.AutoSize = true;
            fileNameLabel.Location = new Point(78, 572);
            fileNameLabel.Name = "fileNameLabel";
            fileNameLabel.Size = new Size(17, 15);
            fileNameLabel.TabIndex = 5;
            fileNameLabel.Text = "--";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(843, 572);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 6;
            label3.Text = "File Type";
            // 
            // fileTypeLabel
            // 
            fileTypeLabel.AutoSize = true;
            fileTypeLabel.Location = new Point(897, 572);
            fileTypeLabel.Name = "fileTypeLabel";
            fileTypeLabel.Size = new Size(17, 15);
            fileTypeLabel.TabIndex = 7;
            fileTypeLabel.Text = "--";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(fileTypeLabel);
            Controls.Add(label3);
            Controls.Add(fileNameLabel);
            Controls.Add(label1);
            Controls.Add(filePathTextBox);
            Controls.Add(listView1);
            Controls.Add(nextButton);
            Controls.Add(backButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple File Explorer";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button backButton;
        private Button nextButton;
        private ListView listView1;
        private TextBox filePathTextBox;
        private Label label1;
        private Label fileNameLabel;
        private Label label3;
        private Label fileTypeLabel;
        private ImageList iconList;
    }
}
