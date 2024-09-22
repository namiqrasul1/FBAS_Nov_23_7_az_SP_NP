namespace FileCopy
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
            openFileSource = new OpenFileDialog();
            label1 = new Label();
            label2 = new Label();
            BtnCopy = new Button();
            BtnSoruce = new Button();
            BtnDest = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // openFileSource
            // 
            openFileSource.FileName = "openFileDialog1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 24);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 40);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 84);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 40);
            label2.TabIndex = 0;
            label2.Text = "To";
            // 
            // BtnCopy
            // 
            BtnCopy.AutoSize = true;
            BtnCopy.Location = new Point(689, 19);
            BtnCopy.Name = "BtnCopy";
            BtnCopy.Size = new Size(129, 50);
            BtnCopy.TabIndex = 1;
            BtnCopy.Text = "Copy";
            BtnCopy.UseVisualStyleBackColor = true;
            BtnCopy.Click += BtnCopy_Click;
            // 
            // BtnSoruce
            // 
            BtnSoruce.AutoSize = true;
            BtnSoruce.Location = new Point(646, 74);
            BtnSoruce.Name = "BtnSoruce";
            BtnSoruce.Size = new Size(173, 50);
            BtnSoruce.TabIndex = 1;
            BtnSoruce.Text = "Source";
            BtnSoruce.UseVisualStyleBackColor = true;
            BtnSoruce.Click += BtnSoruce_Click;
            // 
            // BtnDest
            // 
            BtnDest.AutoSize = true;
            BtnDest.Location = new Point(646, 130);
            BtnDest.Name = "BtnDest";
            BtnDest.Size = new Size(172, 50);
            BtnDest.TabIndex = 1;
            BtnDest.Text = "Destination";
            BtnDest.UseVisualStyleBackColor = true;
            BtnDest.Click += BtnDest_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 501);
            Controls.Add(BtnDest);
            Controls.Add(BtnSoruce);
            Controls.Add(BtnCopy);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileSource;
        private Label label1;
        private Label label2;
        private Button BtnCopy;
        private Button BtnSoruce;
        private Button BtnDest;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
