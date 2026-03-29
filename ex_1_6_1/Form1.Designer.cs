namespace ex_1_6_1
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
            btnStart1 = new Button();
            lst1 = new ListBox();
            SuspendLayout();
            // 
            // btnStart1
            // 
            btnStart1.Location = new Point(362, 12);
            btnStart1.Name = "btnStart1";
            btnStart1.Size = new Size(150, 46);
            btnStart1.TabIndex = 3;
            btnStart1.Text = "Start";
            btnStart1.UseVisualStyleBackColor = true;
            btnStart1.Click += btnStart1_Click;
            // 
            // lst1
            // 
            lst1.FormattingEnabled = true;
            lst1.Location = new Point(12, 12);
            lst1.Name = "lst1";
            lst1.Size = new Size(344, 612);
            lst1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 652);
            Controls.Add(btnStart1);
            Controls.Add(lst1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart1;
        private ListBox lst1;
    }
}
