namespace ex_1_6_3
{
    public partial class Form1 : Form
    {
        private Label lb;

        public Form1()
        {
            InitializeComponent();

            lb = new Label() { Parent = this, Height = 30};
            new Thread(Work) { IsBackground = true }.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        void Work()
        {
            var counter = 0;

            while (true)
            {
                counter++;
                Thread.Sleep(200);
                SetText(lb, counter.ToString());
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

    }
}
