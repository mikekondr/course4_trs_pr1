using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ex_1_5_1
{
    struct Data
    {
        public int a;
        public int b;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
    }
}
