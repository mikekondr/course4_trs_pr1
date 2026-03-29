namespace var_8
{
    public partial class Form1 : Form
    {
        public CannonRectangle Cannon;
        public List<MovingRectangleBase> Rectangles = new List<MovingRectangleBase>();

        public readonly object syncRoot = new object();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cannon = new CannonRectangle(this,
                new Rectangle(0, this.ClientSize.Height-10, 5, 10),
                30, Color.White);
            Cannon.Start();

            for (int i = 0; i < 5; i++)
            {
                SpawnRectangle(isHorizontal: true);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                SpawnRectangle(isHorizontal: false);
            }
        }

        private void SpawnRectangle(bool isHorizontal)
        {
            Random rnd = new Random();

            RectangleBuilder builder;
            MovingRectangleBase newRect;

            Color randomColor = Color.FromArgb(rnd.Next(100, 256), rnd.Next(100, 256), rnd.Next(100, 256));

            if (isHorizontal)
            {
                builder = new HorizontalBuilder();
                newRect = builder
                    .SetForm(this)
                    .SetSize(100, 20)
                    .SetSpeed(rnd.Next(3, 16))
                    .SetPosition(0, rnd.Next(10, this.ClientSize.Height - 100))
                    .SetColor(randomColor)
                    .Build();
            }
            else
            {
                builder = new VerticalBuilder();
                newRect = builder
                    .SetForm(this)
                    .SetSize(10, 50)
                    .SetSpeed(10)
                    .SetPosition(Cannon.GetX(), this.ClientSize.Height - 55)
                    .SetColor(randomColor)
                    .Build();
            }

            lock (syncRoot)
            {
                Rectangles.Add(newRect);
            }

            newRect.Start();
        }

        public void RemoveAndRespawn(MovingRectangleBase rect)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => RemoveAndRespawn(rect)));
                return;
            }

            if (rect.UIElement != null && !rect.UIElement.IsDisposed)
            {
                this.Controls.Remove(rect.UIElement);
                rect.UIElement.Dispose();
            }

            lock (syncRoot)
            {
                Rectangles.Remove(rect);
            }

            if (rect.IsHorizontal)
            {
                SpawnRectangle(true);
            }
        }
    }
}
