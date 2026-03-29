namespace ex_1_6_2
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
            btnStart2 = new Button();
            lst2 = new ListBox();
            SuspendLayout();
            // 
            // btnStart2
            // 
            btnStart2.Location = new Point(427, 12);
            btnStart2.Name = "btnStart2";
            btnStart2.Size = new Size(150, 46);
            btnStart2.TabIndex = 3;
            btnStart2.Text = "Start";
            btnStart2.UseVisualStyleBackColor = true;
            btnStart2.Click += btnStart2_Click;
            // 
            // lst2
            // 
            lst2.FormattingEnabled = true;
            lst2.Location = new Point(12, 12);
            lst2.Name = "lst2";
            lst2.Size = new Size(409, 964);
            lst2.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 991);
            Controls.Add(btnStart2);
            Controls.Add(lst2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart2;
        private ListBox lst2;
    }
}
