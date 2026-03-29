namespace ex_1_6_2
{
    public partial class Form1 : Form
    {
        public ListBox lb;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            lb = lst2;
            MyThread mt = new MyThread(this);
            Thread[] newThrd = new Thread[3];

            for (int i = 0; i < 3; i++)
            {
                newThrd[i] = new Thread(mt.Run);
            }
            lst2.Items.Add("main Count = " + mt.Count);

            for (int i = 0; i < 3; i++)
            {
                newThrd[i].Start(i);
                Thread.Sleep(200);
            }

            for (int i = 0; i < 3; i++)
            {
                if (!newThrd[i].IsAlive)
                {
                    lst2.Items.Add("main Count = " + mt.Count);
                }
                else
                {
                    lst2.Items.Add("potok " + i + " - " + newThrd[i].ThreadState);
                }
            }

        }

        class MyThread
        {
            public int Count;
            Form1 ff;

            public MyThread(Form1 form) { ff = form; }

            public void Run(object x)
            {
                int n = (int)x;
                if (ff.lb.InvokeRequired)
                {
                    ff.lb.Invoke(new Action(() =>
                    {
                        ff.lb.Items.Add("Thread " + n.ToString() + " is started.");
                    }));
                }
                do
                {
                    Thread.Sleep(300);
                    if (ff.lb.InvokeRequired)
                    {
                        ff.lb.BeginInvoke(new Action(() =>
                        {
                            ff.lb.Items.Add((Count + n * 100) + " ");
                        }));
                    }
                    Count++;
                } while (Count <= 10);
                if (ff.lb.InvokeRequired)
                {
                    ff.lb.Invoke(new Action(() =>
                    {
                        ff.lb.Items.Add("Thread " + n.ToString() + " is finished.");
                    }));
                }
            }
        }
    }
}
