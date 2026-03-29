namespace ex_1_5_3
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
            btnDel = new Button();
            btnCreate = new Button();
            txtCount = new TextBox();
            SuspendLayout();
            // 
            // btnDel
            // 
            btnDel.Location = new Point(439, 21);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(150, 46);
            btnDel.TabIndex = 5;
            btnDel.Text = "Очистити";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(258, 21);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(150, 46);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Створити";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(21, 25);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(200, 39);
            txtCount.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1456, 1018);
            Controls.Add(btnDel);
            Controls.Add(btnCreate);
            Controls.Add(txtCount);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDel;
        private Button btnCreate;
        private TextBox txtCount;
    }
}
