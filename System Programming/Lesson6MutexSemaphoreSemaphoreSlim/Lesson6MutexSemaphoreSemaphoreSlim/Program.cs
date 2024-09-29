using System.ComponentModel.Design;

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


    //private static void Main(string[] args)
    //{
    //    var mutex = new Mutex(false, "AzDanish");
    //    try
    //    {
    //        if (mutex.WaitOne(1))
    //        {
    //            Console.WriteLine("Process is running");
    //            Console.ReadKey();
    //        }
    //        else
    //        {
    //            Console.WriteLine("Another process is running... go away");
    //            Environment.Exit(0);
    //        }
    //    }
    //    finally 
    //    {
    //        mutex.ReleaseMutex();
    //    }


    //}

    #endregion

    #region Semaphore (Internal Thread)

    //private static void SomeMethod(object? state)
    //{
    //    if (state is Semaphore semaphore)
    //    {
    //        var st = false;
    //        while (!st)
    //        {
    //            if (semaphore.WaitOne(1000))
    //            {
    //                try
    //                {
    //                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} got the key");
    //                    Thread.Sleep(2000);
    //                }
    //                finally
    //                {
    //                    st = true;
    //                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} returned the key");
    //                    semaphore.Release();
    //                }
    //            }
    //            else
    //            {
    //                Console.WriteLine($"Mister Thread {Thread.CurrentThread.ManagedThreadId}, we dont have enough key. Please wait...");
    //            }
    //        }
    //    }
    //}

    //private static void Main(string[] args)
    //{
    //    var semaphore = new Semaphore(5, 5);
    //    for (int i = 0; i< 10; i++)
    //    {
    //        ThreadPool.QueueUserWorkItem(SomeMethod, semaphore);
    //    }

    //    Console.ReadKey();
    //}





    #endregion

    #region Semaphore (External Thread)

    //private static void SomeMethod(object? state)
    //{
    //    if (state is Semaphore semaphore)
    //    {
    //        var st = false;
    //        while (!st)
    //        {
    //            if (semaphore.WaitOne(1000))
    //            {
    //                try
    //                {
    //                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} got the key");
    //                    Thread.Sleep(2000);
    //                }
    //                finally
    //                {
    //                    st = true;
    //                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} returned the key");
    //                    semaphore.Release();
    //                }
    //            }
    //            else
    //            {
    //                Console.WriteLine($"Mister Thread {Thread.CurrentThread.ManagedThreadId}, we dont have enough key. Please wait...");
    //            }
    //        }
    //    }
    //}

    //private static void Main(string[] args)
    //{
    //    Console.ReadKey();

    //    var semaphore = new Semaphore(3, 3, "BabatSemaphore");
    //    for (int i = 0; i < 10; i++)
    //    {
    //        ThreadPool.QueueUserWorkItem(SomeMethod, semaphore);
    //    }

    //    Console.ReadKey();
    //}

    #endregion

    #region SemaphoreSlim

    private static void Main(string[] args)
    {
        var semaphoreSlim = new SemaphoreSlim(3);
        for (int i = 0; i < 10; i++)
        {
            var name = $"Thread{i}";
            var second = TimeSpan.FromSeconds(2 + 2 * i);
            new Thread(() =>
            {
                Console.WriteLine($"{name} waits for access");

                semaphoreSlim.Wait(second);

                Console.WriteLine($"{name} is working");
                Thread.Sleep(second);
                Console.WriteLine($"{name} completed");

                semaphoreSlim.Release();

            }).Start();


        }

    }

    #endregion

}