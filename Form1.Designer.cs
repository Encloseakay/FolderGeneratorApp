namespace FolderGeneratorApp
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
            txtFolderCount = new TextBox();
            btnGenerate = new Button();
            txtFolderPrefix = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtFolderPath = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtFolderCount
            // 
            txtFolderCount.Location = new Point(24, 119);
            txtFolderCount.Name = "txtFolderCount";
            txtFolderCount.Size = new Size(100, 23);
            txtFolderCount.TabIndex = 0;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(174, 115);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(100, 31);
            btnGenerate.TabIndex = 1;
            btnGenerate.Text = "开始创建";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // txtFolderPrefix
            // 
            txtFolderPrefix.Location = new Point(24, 49);
            txtFolderPrefix.Name = "txtFolderPrefix";
            txtFolderPrefix.Size = new Size(100, 23);
            txtFolderPrefix.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(92, 17);
            label1.TabIndex = 3;
            label1.Text = "创建的文件夹名";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 95);
            label2.Name = "label2";
            label2.Size = new Size(104, 17);
            label2.TabIndex = 4;
            label2.Text = "创建的文件夹数量";
            // 
            // txtFolderPath
            // 
            txtFolderPath.Location = new Point(24, 181);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.Size = new Size(250, 23);
            txtFolderPath.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 160);
            label3.Name = "label3";
            label3.Size = new Size(128, 17);
            label3.TabIndex = 6;
            label3.Text = "自定义的文件创建地址";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 211);
            Controls.Add(label3);
            Controls.Add(txtFolderPath);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFolderPrefix);
            Controls.Add(btnGenerate);
            Controls.Add(txtFolderCount);
            Name = "Form1";
            Text = "文件夹生成器";
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFolderCount;
        private Button btnGenerate;
        private TextBox txtFolderPrefix;
        private Label label1;
        private Label label2;
        private TextBox txtFolderPath;
        private Label label3;
    }
}
