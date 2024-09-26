using ForFarhadLibrary;

internal class Program
{
    private static int _count = 0;
    private static object _lock = new object();

    #region Lock


    //private static void Increment()
    //{
    //    lock (_lock)
    //    {
    //        _count = 0;

    //        for (int i = 0; i < 10; i++)
    //        {
    //            Console.WriteLine($"{Thread.CurrentThread.Name}: {++_count}");
    //        }
    //    }

    //}

    //private static void Main(string[] args)
    //{
    //    for (int i = 0;i < 5;i++)
    //    {
    //        Thread thread = new(Increment);
    //        thread.Name = $"Thread{i}";
    //        thread.Start();
    //    } 
    //}

    #endregion

    #region Mutex (Internal Thread)

    //private static Mutex _mutexObj = new();
    //private static void Increment()
    //{
    //    _mutexObj.WaitOne();

    //    _count = 0;

    //    for (int i = 0; i < 10; i++)
    //    {
    //        Console.WriteLine($"{Thread.CurrentThread.Name}: {++_count}");
    //        Thread.Sleep(100);
    //    }

    //    _mutexObj.ReleaseMutex();
    //}

    //private static void Main(string[] args)
    //{

    //    for (int i = 0; i < 5; i++)
    //    {
    //        Thread thread = new(Increment);
    //        thread.Name = $"Thread{i}";
    //        thread.Start();
    //    }

    //    Thread.Sleep(1000);
    //    Console.WriteLine("salam");
    //}

    #endregion

    #region Mutex (External Thread)

    //private static Mutex _mutexObj = new(false, "BabatMutex");
    //private static void Increment()
    //{
    //    _mutexObj.WaitOne();

    //    _count = 0;

    //    for (int i = 0; i < 10; i++)
    //    {
    //        Console.WriteLine($"{Thread.CurrentThread.Name}: {++_count}");
    //        Thread.Sleep(100);
    //    }

    //    _mutexObj.ReleaseMutex();
    //}

    //private static void Main(string[] args)
    //{
    //    Console.ReadKey();
    //    for (int i = 0; i < 5; i++)
    //    {
    //        Thread thread = new(Increment);
    //        thread.Name = $"Thread{i}";
    //        thread.Start();
    //    }

    //    Thread.Sleep(1000);
    //    Console.WriteLine("salam");
    //}


    private static void Main(string[] args)
    {
        var mutex = new Mutex(false, "AzDanish");
        try
        {
            if (mutex.WaitOne(1))
            {
                Console.WriteLine("Process is running");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Another process is running... go away");
                Environment.Exit(0);
            }
        }
        finally 
        {
            mutex.ReleaseMutex();
        }

        Product product = new();
        product.Id = 2;



    }

    #endregion

}