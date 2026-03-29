namespace ex_1_6_4
{
    public partial class Form1 : Form
    {
        int n = 3;
        private Label[] lb;

        public Form1()
        {
            InitializeComponent();
            lb = new Label[n+1];

            for (int i = 0; i <= n; i++)
            {
                Point p = new Point(i * 150, 10);
                lb[i] = new Label()
                {
                    Parent = this,
                    Width = 120,
                    Height = 30,
                };
                lb[i].Location = p;
            }

            Thread[] tt = new Thread[n];
            for (int i = 0; i < n; i++)
            {
                tt[i] = new Thread(Work) { IsBackground = true};
                tt[i].Start(i);
            }

            Thread mm = new Thread(MainWork) { IsBackground = true };
            mm.Start();
        }

        void Work(object num)
        {
            int x = (int)num;
            var counter = 0;

            while (true)
            {
                counter++;
                Thread.Sleep(1000 + 300 * x);
                SetText(lb[x], counter.ToString());
            }
        }

        private void SetText(Control ctrl, string text)
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action)(() => SetText(ctrl, text) ));
            }
            else
            {
                ctrl.Text = text;
            }
        }

        private void MainWork()
        {
            var main_counter = 0;
            while (true)
            {
                main_counter++;
                Thread.Sleep(500);
                SetText(lb[n], "Main : " + main_counter.ToString());
            }
        }
    }
}
