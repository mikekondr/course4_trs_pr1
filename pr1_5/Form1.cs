namespace pr1_5
{
    public partial class Form1 : Form
    {
        public delegate void AddListItem(int x);
        public AddListItem myDelegate;

        public ListBox lb;

        private Label lbl;

        public Form1()
        {
            InitializeComponent();

            lbl = new Label()
            {
                Top = 10,
                Left = 1150,
                Height = 30,
                Parent = this
            };
            new Thread(Work) { IsBackground = true }.Start();
        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            Class1 cc = new Class1(this);
            myDelegate = new AddListItem(AddListItemMethod);
            int CountThreads = 4;

            Thread[] Threads = new Thread[CountThreads + 1];
            for (int p = 1; p <= CountThreads; p++)
            {
                Threads[p] = new Thread(cc.doSomeThing);
                Threads[p].Start(p * 100);
            }
        }

        public void AddListItemMethod(int x)
        {
            string myItem;
            Thread.Sleep(600 - x);
            for (int i = 1; i < 6; i++)
            {
                myItem = "My list item " + (x + i).ToString();
                lst1.Items.Add(myItem);
                lst1.Update();
                Thread.Sleep(600 - x);
            }
        }

        class Class1
        {
            Form1 f1;

            public Class1(Form1 form) { f1 = form; }

            public void doSomeThing(object data)
            {
                int i = (int)data;
                f1.Invoke(f1.myDelegate, new Object[] { i });
            }
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


        void Work()
        {
            var counter = 0;

            while (true)
            {
                counter++;
                Thread.Sleep(200);
                SetText(lbl, counter.ToString());
            }
        }

        private void SetText(Control ctrl, string text)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => SetText(ctrl, text)));
            }
            else
            {
                ctrl.Text = text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}