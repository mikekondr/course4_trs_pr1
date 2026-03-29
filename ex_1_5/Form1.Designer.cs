namespace ex_1_5_1
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
            txtC = new TextBox();
            txtB = new TextBox();
            txtA = new TextBox();
            btnSum = new Button();
            SuspendLayout();
            // 
            // txtC
            // 
            txtC.Location = new Point(65, 227);
            txtC.Name = "txtC";
            txtC.Size = new Size(250, 39);
            txtC.TabIndex = 7;
            // 
            // txtB
            // 
            txtB.Location = new Point(65, 167);
            txtB.Name = "txtB";
            txtB.Size = new Size(250, 39);
            txtB.TabIndex = 6;
            // 
            // txtA
            // 
            txtA.Location = new Point(65, 107);
            txtA.Name = "txtA";
            txtA.Size = new Size(250, 39);
            txtA.TabIndex = 5;
            // 
            // btnSum
            // 
            btnSum.Location = new Point(115, 40);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(150, 46);
            btnSum.TabIndex = 4;
            btnSum.Text = "SUM";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 314);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(btnSum);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtC;
        private TextBox txtB;
        private TextBox txtA;
        private Button btnSum;
    }
}
