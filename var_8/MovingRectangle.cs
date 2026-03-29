namespace var_8
{
    // ==========================================
    // 1. АБСТРАКТНИЙ БАЗОВИЙ КЛАС ТА СПАДКОЄМЦІ
    // ==========================================
    public abstract class MovingRectangleBase
    {
        protected Form1 _form;
        protected int _speed;
        public Panel UIElement;
        public Rectangle LogicalBounds;
        public bool IsAlive = true;
        protected Thread _thread;

        public abstract bool IsHorizontal { get; }

        public MovingRectangleBase(Form1 form, Rectangle bounds, int speed, Color color)
        {
            _form = form;
            LogicalBounds = bounds;
            _speed = speed;

            UIElement = new Panel()
            {
                Size = LogicalBounds.Size,
                Location = LogicalBounds.Location,
                BackColor = color
            };
            _form.Controls.Add(UIElement);
        }

        public void Start()
        {
            _thread = new Thread(MoveLoop) { IsBackground = true };
            _thread.Start();
        }

        // Абстрактні методи, які реалізують нащадки
        protected abstract void MoveLogic();
        protected abstract bool CheckOutOfBounds();

        private void MoveLoop()
        {
            while (IsAlive)
            {
                MoveLogic();

                if (CheckOutOfBounds())
                {
                    Destroy();
                    break;
                }

                CheckCollisions();

                if (IsAlive)
                {
                    try
                    {
                        _form.Invoke(new Action(() =>
                        {
                            if (UIElement != null && !UIElement.IsDisposed)
                                UIElement.Location = LogicalBounds.Location;
                        }));
                    }
                    catch { }
                }

                Thread.Sleep(30);
            }
        }

        private void CheckCollisions()
        {
            List<MovingRectangleBase> targetsToDestroy = new List<MovingRectangleBase>();

            lock (_form.syncRoot)
            {
                foreach (var other in _form.Rectangles)
                {
                    if (other != this && other.IsAlive && this.LogicalBounds.IntersectsWith(other.LogicalBounds))
                    {
                        targetsToDestroy.Add(other);
                        targetsToDestroy.Add(this);
                        break;
                    }
                }
            }

            if (targetsToDestroy.Count > 0)
            {
                foreach (var target in targetsToDestroy)
                {
                    target.Destroy();
                }
            }
        }

        public void Destroy()
        {
            if (!IsAlive) return;
            IsAlive = false;
            _form.RemoveAndRespawn(this);
        }
    }

    // --- КОНКРЕТНІ КЛАСИ ---

    public class HorizontalRectangle : MovingRectangleBase
    {
        public HorizontalRectangle(Form1 form, Rectangle bounds, int speed, Color color)
            : base(form, bounds, speed, color) { }

        public override bool IsHorizontal => true;

        protected override void MoveLogic() => LogicalBounds.X += _speed;
        protected override bool CheckOutOfBounds() => LogicalBounds.X > _form.ClientSize.Width;
    }

    public class VerticalRectangle : MovingRectangleBase
    {
        public VerticalRectangle(Form1 form, Rectangle bounds, int speed, Color color)
            : base(form, bounds, speed, color) { }

        public override bool IsHorizontal => false;

        protected override void MoveLogic() => LogicalBounds.Y -= _speed;
        protected override bool CheckOutOfBounds() => LogicalBounds.Bottom < 0;
    }

    public class CannonRectangle : MovingRectangleBase
    {
        private int _dir = 1;

        public CannonRectangle(Form1 form, Rectangle bounds, int speed, Color color)
            : base(form, bounds, speed, color) { }
        public override bool IsHorizontal => true; // Можна вважати за горизонтальний
        protected override void MoveLogic()
        {
            LogicalBounds.X += _speed * _dir;

            if (LogicalBounds.Right >= _form.ClientSize.Width - 10) _dir = -1;
            else if (LogicalBounds.Left <= 10) _dir = 1;
        }
        protected override bool CheckOutOfBounds() => false;
        public int GetX() => LogicalBounds.X + LogicalBounds.Width / 2;
    }

    // ==========================================
    // 2. BUILDER
    // ==========================================
    public abstract class RectangleBuilder
    {
        protected Form1 _form;
        protected int _width, _height, _speed, _x, _y;
        protected Color _color;

        public RectangleBuilder SetForm(Form1 form) { _form = form; return this; }
        public RectangleBuilder SetSize(int w, int h) { _width = w; _height = h; return this; }
        public RectangleBuilder SetPosition(int x, int y) { _x = x; _y = y; return this; }
        public RectangleBuilder SetSpeed(int speed) { _speed = speed; return this; }
        public RectangleBuilder SetColor(Color c) { _color = c; return this; }

        public abstract MovingRectangleBase Build();
    }

    public class HorizontalBuilder : RectangleBuilder
    {
        public override MovingRectangleBase Build()
        {
            return new HorizontalRectangle(_form, new Rectangle(_x, _y, _width, _height), _speed, _color);
        }
    }

    public class VerticalBuilder : RectangleBuilder
    {
        public override MovingRectangleBase Build()
        {
            return new VerticalRectangle(_form, new Rectangle(_x, _y, _width, _height), _speed, _color);
        }
    }
}