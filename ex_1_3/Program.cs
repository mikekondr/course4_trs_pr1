using System.Diagnostics.Metrics;

namespace ex_1_3
{
    // ==========================================================
    // КЛАСИ ДЛЯ ПЕРЕДАЧІ ПАРАМЕТРІВ
    // ==========================================================

    public class Counter
    {
        public int x;
        public int y;
    }

    public class CounterWithLogic
    {
        private int x;
        private int y;


        public CounterWithLogic(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public void Count()
        {
            Console.WriteLine($"\t[1.3.3] Працює спеціальний клас. Добуток: {x * y}");
            Thread.Sleep(200);
        }
    }

    // ==========================================================
    // ГОЛОВНА ПРОГРАМА
    // ==========================================================
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== ДЕМОНСТРАЦІЯ ПЕРЕДАЧІ ПАРАМЕТРІВ ===\n");

            Console.WriteLine("1. Передача одного параметра (ParameterizedThreadStart):");
            int number = 4;
            Thread thread1 = new Thread(new ParameterizedThreadStart(CountSingle));
            thread1.Start(number);
            thread1.Join(); // Чекаємо, щоб не змішувати вивід


            Console.WriteLine("\n2. Передача кількох параметрів (через об'єкт класу):");
            Counter counterObj = new Counter();
            counterObj.x = 4;
            counterObj.y = 5;
            Thread thread2 = new Thread(new ParameterizedThreadStart(CountObject));
            thread2.Start(counterObj);
            thread2.Join();


            Console.WriteLine("\n3. Інкапсуляція в спеціальному класі (ThreadStart):");
            CounterWithLogic cLogic = new CounterWithLogic(5, 4);
            Thread thread3 = new Thread(new ThreadStart(cLogic.Count));
            thread3.Start();
            thread3.Join();
        }

        public static void CountSingle(object x)
        {
            int n = (int)x;
            Console.WriteLine($"\t[1.3.1] Отримано число: {n}");
            Thread.Sleep(200);
        }

        public static void CountObject(object obj)
        {
            Counter c = (Counter)obj;
            Console.WriteLine($"\t[1.3.2] Отримано x={c.x}, y={c.y}. Їх добуток: {c.x * c.y}");
            Thread.Sleep(200);
        }
    }
}
