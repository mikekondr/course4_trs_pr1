namespace ex_1_2
{
    internal class Program
    {
        static void WorkerMethod()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"\t[Фоновий потік] Стан: {Thread.CurrentThread.ThreadState}, Крок: {i}");
                Thread.Sleep(600);
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Thread newThrd = new Thread(WorkerMethod);
            newThrd.IsBackground = true;
            Console.WriteLine($"[Головний] Стан фонового потоку ДО старту: {newThrd.ThreadState}");
            newThrd.Start();
            Console.WriteLine($"[Головний] Стан фонового потоку ПІСЛЯ старту: {newThrd.ThreadState}");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"[Головний потік] Стан: {Thread.CurrentThread.ThreadState}, Крок: {i}");
                Thread.Sleep(300);
            }
            Console.WriteLine($"[Головний] Стан фонового потоку ПІСЛЯ завершення програми: {newThrd.ThreadState}");
            Console.WriteLine("[Головний] Завершення роботи програми.");
        }
    }
}
