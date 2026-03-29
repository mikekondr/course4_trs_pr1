namespace ex_1_6_1
{
    public partial class Form1 : Form
    {
        public delegate void AddListItem(int x);
        public AddListItem myDelegate;

        public Form1()
        {
            InitializeComponent();
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
    }
}
