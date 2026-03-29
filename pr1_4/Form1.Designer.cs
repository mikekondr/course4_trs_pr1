namespace pr1_4
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
            txtC = new TextBox();
            txtB = new TextBox();
            txtA = new TextBox();
            btnSum = new Button();
            groupBox2 = new GroupBox();
            btnStart4 = new Button();
            lstVal = new ListBox();
            lblCurr = new Label();
            groupBox3 = new GroupBox();
            btnDel = new Button();
            btnCreate = new Button();
            txtCount = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtC);
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(btnSum);
            groupBox1.Location = new Point(24, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(352, 326);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Обчислення";
            // 
            // txtC
            // 
            txtC.Location = new Point(51, 240);
            txtC.Name = "txtC";
            txtC.Size = new Size(250, 39);
            txtC.TabIndex = 3;
            // 
            // txtB
            // 
            txtB.Location = new Point(51, 180);
            txtB.Name = "txtB";
            txtB.Size = new Size(250, 39);
            txtB.TabIndex = 2;
            // 
            // txtA
            // 
            txtA.Location = new Point(51, 120);
            txtA.Name = "txtA";
            txtA.Size = new Size(250, 39);
            txtA.TabIndex = 1;
            // 
            // btnSum
            // 
            btnSum.Location = new Point(101, 53);
            btnSum.Name = "btnSum";
            btnSum.Size = new Size(150, 46);
            btnSum.TabIndex = 0;
            btnSum.Text = "SUM";
            btnSum.UseVisualStyleBackColor = true;
            btnSum.Click += btnSum_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnStart4);
            groupBox2.Controls.Add(lstVal);
            groupBox2.Controls.Add(lblCurr);
            groupBox2.Location = new Point(396, 24);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(592, 699);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Декілька потоків";
            // 
            // btnStart4
            // 
            btnStart4.Location = new Point(400, 61);
            btnStart4.Name = "btnStart4";
            btnStart4.Size = new Size(150, 46);
            btnStart4.TabIndex = 2;
            btnStart4.Text = "Старт";
            btnStart4.UseVisualStyleBackColor = true;
            btnStart4.Click += btnStart4_Click;
            // 
            // lstVal
            // 
            lstVal.FormattingEnabled = true;
            lstVal.Location = new Point(143, 38);
            lstVal.Name = "lstVal";
            lstVal.Size = new Size(240, 644);
            lstVal.TabIndex = 1;
            // 
            // lblCurr
            // 
            lblCurr.AutoSize = true;
            lblCurr.Location = new Point(43, 68);
            lblCurr.Name = "lblCurr";
            lblCurr.Size = new Size(78, 32);
            lblCurr.TabIndex = 0;
            lblCurr.Text = "label1";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnDel);
            groupBox3.Controls.Add(btnCreate);
            groupBox3.Controls.Add(txtCount);
            groupBox3.Location = new Point(1013, 24);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(857, 699);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Створення елементів керування";
            // 
            // btnDel
            // 
            btnDel.Location = new Point(457, 44);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(150, 46);
            btnDel.TabIndex = 2;
            btnDel.Text = "Очистити";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(276, 44);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(150, 46);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Створити";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(39, 48);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(200, 39);
            txtCount.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1893, 737);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtC;
        private TextBox txtB;
        private TextBox txtA;
        private Button btnSum;
        private GroupBox groupBox2;
        private Label lblCurr;
        private Button btnStart4;
        private ListBox lstVal;
        private GroupBox groupBox3;
        private Button btnDel;
        private Button btnCreate;
        private TextBox txtCount;
    }
}
