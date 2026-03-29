namespace pr1_5
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
            groupBox1 = new GroupBox();
            btnStart1 = new Button();
            lst1 = new ListBox();
            groupBox2 = new GroupBox();
            btnStart2 = new Button();
            lst2 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnStart1);
            groupBox1.Controls.Add(lst1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(513, 661);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Запис з декількох потоків";
            // 
            // btnStart1
            // 
            btnStart1.Location = new Point(356, 38);
            btnStart1.Name = "btnStart1";
            btnStart1.Size = new Size(150, 46);
            btnStart1.TabIndex = 1;
            btnStart1.Text = "Start";
            btnStart1.UseVisualStyleBackColor = true;
            btnStart1.Click += btnStart1_Click;
            // 
            // lst1
            // 
            lst1.FormattingEnabled = true;
            lst1.Location = new Point(6, 38);
            lst1.Name = "lst1";
            lst1.Size = new Size(344, 612);
            lst1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnStart2);
            groupBox2.Controls.Add(lst2);
            groupBox2.Location = new Point(531, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(582, 661);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Паралельні потоки";
            // 
            // btnStart2
            // 
            btnStart2.Location = new Point(421, 38);
            btnStart2.Name = "btnStart2";
            btnStart2.Size = new Size(150, 46);
            btnStart2.TabIndex = 1;
            btnStart2.Text = "Start";
            btnStart2.UseVisualStyleBackColor = true;
            btnStart2.Click += btnStart2_Click;
            // 
            // lst2
            // 
            lst2.FormattingEnabled = true;
            lst2.Location = new Point(6, 38);
            lst2.Name = "lst2";
            lst2.Size = new Size(409, 612);
            lst2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1925, 1038);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnStart1;
        private ListBox lst1;
        private GroupBox groupBox2;
        private Button btnStart2;
        private ListBox lst2;
    }
}
