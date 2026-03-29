namespace pr1_1
{
    class MyThread
    {
        public int Count;

        public void Run()
        {
            Console.WriteLine("Новий потік запущено");
            Console.Write("Підрахунок: ");
            do
            {
                Thread.Sleep(500);
                Console.Write(Count + " ");
                Count++;
            } while (Count <= 10);
            Console.WriteLine("Новий потік закінчено");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("\t--- Створення другого потоку ---\n");

            MyThread mt = new MyThread();
            Thread newThrd = new Thread(mt.Run);

            Console.WriteLine("\tГоловний потік підрахунок = " + mt.Count);

            newThrd.Start();

            for (int i = 20; i < 30; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("\tГоловний потік = " + i);
            }

            newThrd.Join();
            Console.WriteLine("\tГоловний потік підрахунок = " + mt.Count);

            Console.WriteLine("\n\n\t--- Послідовний виклик (без створення другого потоку) ---\n");

            Console.WriteLine("\tГоловний потік підрахунок = " + mt.Count);

            mt = new MyThread();
            mt.Run();

            for (int i = 20; i < 30; i++)
            {
                Thread.Sleep(500);
                Console.WriteLine("\tГоловний потік = " + i);
            }

            Console.WriteLine("\tГоловний потік підрахунок = " + mt.Count);
        }
    }
}
