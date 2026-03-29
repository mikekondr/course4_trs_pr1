namespace ex_1_4
{
    class MyThread
    {
        public int Count;

        public void Run(object x)
        {
            Console.WriteLine($"\tПотік {x} запущено.");
            do
            {
                Thread.Sleep(2 + 5 * (int)x);
                Console.WriteLine("Потік - " + x + " - " + Count);
                Count++;
            } while (Count <= 10);
            Console.WriteLine($"\tПотік {x} завершено.");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int n = 3;
            Console.WriteLine("Головний запущено.");
            MyThread[] mt = new MyThread[n];

            for (int i = 0; i < n; i++)
            {
                mt[i] = new MyThread();
            }

            Thread[] newThrd = new Thread[n];

            for (int i = 0; i < n; i++)
            {
                newThrd[i] = new Thread(mt[i].Run);
            }

            for (int i = 0; i < n; i++)
            {
                newThrd[i].Start(i);
            }

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("\t\tГоловний ");
                Thread.Sleep(7);
            }

            for (int i = 0; i < n; i++)
            {
                newThrd[i].Join();
            }

            Console.WriteLine("\nГоловний закінчив.");
        }
    }
}
