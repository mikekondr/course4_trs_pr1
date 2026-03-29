namespace pr1_4
{
    struct Data
    {
        public int a;
        public int b;
    }

    public partial class Form1 : Form
    {
        private List<Label> listLabels;
        private Thread _createLables;
        private volatile bool _stopCreate;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startWorkers(3);
        }

        /// ---=== Обчислення в потоці

        private void btnSum_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Sum);
            Data temp = new Data();
            try
            {
                temp.a = int.Parse(txtA.Text);
                temp.b = int.Parse(txtB.Text);
                t.Start(temp);
            }
            catch { }
        }

        private void Sum(object input)
        {
            Data d = (Data)input;
            int res = d.a + d.b;
            Invoke(new Action(() => txtC.Text = res.ToString()));
        }

        /// ---=== Запис в елемент керування з потоків

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

        /// ---=== Створення елементів керування в потоці

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int x;
            try
            {
                x = int.Parse(txtCount.Text);
            }
            catch { return; }

            _stopCreate = false;
            _createLables = new Thread(createLables);
            _createLables.IsBackground = true;
            _createLables.Start(x);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (_createLables != null && _createLables.IsAlive)
            {
                _stopCreate = true;
                _createLables.Join();
            }

            Thread t = new Thread(delLabels);
            t.IsBackground = true;
            t.Start();
        }

        private void createLables(object input)
        {
            Random rnd = new Random();

            if (listLabels == null)
                listLabels = new List<Label>();
            int count = (int)input + listLabels.Count;

            for (int i = listLabels.Count; i < count; i++)
            {
                if (_stopCreate)
                    break;

                Color rndColor = Color.FromArgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));

                if (groupBox3.InvokeRequired)
                    groupBox3.Invoke(new Action(() =>
                    {
                        Label l = new Label();
                        l.Location = new Point(10 + i * 50, 100 + i * 50);
                        l.BackColor = rndColor;
                        l.Size = new Size(100, 50);
                        l.Text = i.ToString();
                        listLabels.Add(l);
                        groupBox3.Controls.Add(l);
                    }));
                Thread.Sleep(500);
            }
        }

        private void delLabels()
        {
            if (listLabels == null)
                return;

            for (int i = listLabels.Count - 1; i >= 0; i--)
            {
                if (groupBox3.InvokeRequired)
                    groupBox3.Invoke(new Action(() =>
                    {
                        groupBox3.Controls.Remove(listLabels[i]);
                        listLabels.RemoveAt(i);
                    }));
                Thread.Sleep(200);
            }
        }
    }
}
