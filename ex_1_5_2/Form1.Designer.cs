namespace ex_1_5_2
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
            btnStart4 = new Button();
            lstVal = new ListBox();
            lblCurr = new Label();
            SuspendLayout();
            // 
            // btnStart4
            // 
            btnStart4.Location = new Point(380, 53);
            btnStart4.Name = "btnStart4";
            btnStart4.Size = new Size(150, 46);
            btnStart4.TabIndex = 5;
            btnStart4.Text = "Старт";
            btnStart4.UseVisualStyleBackColor = true;
            btnStart4.Click += btnStart4_Click;
            // 
            // lstVal
            // 
            lstVal.FormattingEnabled = true;
            lstVal.Location = new Point(123, 30);
            lstVal.Name = "lstVal";
            lstVal.Size = new Size(240, 644);
            lstVal.TabIndex = 4;
            // 
            // lblCurr
            // 
            lblCurr.AutoSize = true;
            lblCurr.Location = new Point(23, 60);
            lblCurr.Name = "lblCurr";
            lblCurr.Size = new Size(78, 32);
            lblCurr.TabIndex = 3;
            lblCurr.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(590, 737);
            Controls.Add(btnStart4);
            Controls.Add(lstVal);
            Controls.Add(lblCurr);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart4;
        private ListBox lstVal;
        private Label lblCurr;
    }
}
