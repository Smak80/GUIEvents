namespace GUIEvents
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
            label1 = new Label();
            lblSeqSum = new Label();
            btnStartSeqSum = new Button();
            lblParSum = new Label();
            label3 = new Label();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(200, 15);
            label1.TabIndex = 0;
            label1.Text = "Последовательное суммирование:";
            // 
            // lblSeqSum
            // 
            lblSeqSum.AutoSize = true;
            lblSeqSum.Location = new Point(12, 39);
            lblSeqSum.Name = "lblSeqSum";
            lblSeqSum.Size = new Size(0, 15);
            lblSeqSum.TabIndex = 1;
            // 
            // btnStartSeqSum
            // 
            btnStartSeqSum.Location = new Point(12, 151);
            btnStartSeqSum.Name = "btnStartSeqSum";
            btnStartSeqSum.Size = new Size(143, 23);
            btnStartSeqSum.TabIndex = 2;
            btnStartSeqSum.Text = "Суммировать";
            btnStartSeqSum.UseVisualStyleBackColor = true;
            btnStartSeqSum.Click += btnStartSeqSum_Click;
            // 
            // lblParSum
            // 
            lblParSum.AutoSize = true;
            lblParSum.Location = new Point(12, 96);
            lblParSum.Name = "lblParSum";
            lblParSum.Size = new Size(0, 15);
            lblParSum.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 72);
            label3.Name = "label3";
            label3.Size = new Size(177, 15);
            label3.TabIndex = 3;
            label3.Text = "Параллельное суммирование:";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(161, 151);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(388, 23);
            progressBar1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 186);
            Controls.Add(progressBar1);
            Controls.Add(lblParSum);
            Controls.Add(label3);
            Controls.Add(btnStartSeqSum);
            Controls.Add(lblSeqSum);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblSeqSum;
        private Button btnStartSeqSum;
        private Label lblParSum;
        private Label label3;
        private ProgressBar progressBar1;
    }
}