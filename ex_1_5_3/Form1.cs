using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ex_1_5_3
{
    public partial class Form1 : Form
    {
        private List<Label> listLabels;
        private Thread _createLables;
        private volatile bool _stopCreate;

        public Form1()
        {
            InitializeComponent();
        }

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

                if (InvokeRequired)
                    Invoke(new Action(() =>
                    {
                        Label l = new Label();
                        l.Location = new Point(10 + i * 50, 100 + i * 50);
                        l.BackColor = rndColor;
                        l.Size = new Size(100, 50);
                        l.Text = i.ToString();
                        listLabels.Add(l);
                        Controls.Add(l);
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
                if (InvokeRequired)
                    Invoke(new Action(() =>
                    {
                        Controls.Remove(listLabels[i]);
                        listLabels.RemoveAt(i);
                    }));
                Thread.Sleep(200);
            }
        }
    }
}
