namespace ex_1_5_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startWorkers(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Thread t = new Thread(doSomeThing);
                t.Start(i * 100);
            }
        }

        private void doSomeThing(object input)
        {
            int i = (int)input;

            for (int j = 0; j < 3; j++)
            {
                if (lblCurr.InvokeRequired)
                    lblCurr.Invoke(new Action(() => lblCurr.Text = i.ToString()));

                if (lstVal.InvokeRequired)
                    lstVal.Invoke(new Action(() => lstVal.Items.Add(i)));

                i++;
                Thread.Sleep(300);
            }
        }

        private void btnStart4_Click(object sender, EventArgs e)
        {
            startWorkers(4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startWorkers(3);
        }
    }
}
