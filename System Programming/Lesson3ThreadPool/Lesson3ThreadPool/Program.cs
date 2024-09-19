
// eger bunu run etmek isteyirsense, onda get .net framework app yarat ora yaz bu kodu. sonra onu run et. netice gor. 
//internal class Program
//{
//    private delegate void SomeDelegate();

//    private static void DoSomething()
//    {
//        Console.WriteLine($"Id: {Thread.CurrentThread.ManagedThreadId} IsBackground: {Thread.CurrentThread.IsBackground} IsThreadPoolThread:{Thread.CurrentThread.IsThreadPoolThread}");
//    }

//    static void Main(string[] args)
//    {
//        SomeDelegate del = DoSomething;

//        var result = del.BeginInvoke(null, null);

//        del.EndInvoke(result);

//        Console.WriteLine("salam");
//        Console.ReadKey();
//    }
//}



internal class Program
{
    #region ThreadPool

    //private static void DoSomething(object? state)
    //{
    //    Console.WriteLine($"Id: {Thread.CurrentThread.ManagedThreadId} IsBackground: {Thread.CurrentThread.IsBackground} IsThreadPoolThread:{Thread.CurrentThread.IsThreadPoolThread}");
    //}

    //private static void Main(string[] args)
    //{
    //    //ThreadPool.QueueUserWorkItem(DoSomething, "salam");
    //    //ThreadPool.QueueUserWorkItem(o => { DoSomething(null); });
    //    ThreadPool.QueueUserWorkItem(delegate(object? state) { });

    //    Console.ReadKey();
    //}

    #endregion

    #region Thread vs ThreadPool

    //private static void Main(string[] args)
    //{
    //    //for(int i = 0; i < 500; i++)
    //    //{
    //    //    var thread = new Thread(() =>
    //    //    {
    //    //        Console.Write($"{Thread.CurrentThread.ManagedThreadId} ");
    //    //    });
    //    //    thread.Start();
    //    //}


    //    //for (int i = 0; i < 500; i++)
    //    //{
    //    //    ThreadPool.QueueUserWorkItem(o =>
    //    //    {
    //    //        Console.Write($"{Thread.CurrentThread.ManagedThreadId} ");
    //    //    });
    //    //}
    //    //Console.ReadKey();
    //}

    #endregion

    #region CancelationToken

    private static void Download(CancellationToken token)
    {
        Console.WriteLine("Downloading...");
        for (int i = 5; 0 < i; i--)
        {
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine($"Downloading. Please wait {i} second(s)");

            //if (token.IsCancellationRequested) { }
            try
            {
                token.ThrowIfCancellationRequested();

            }
            catch (Exception)
            {
                throw;
            }
        }
        Console.Clear();
        Console.WriteLine($"Downloading completed successfuly");

    }

    static void Main(string[] args)
    {
        //using var cts = new CancellationTokenSource();


        //_ = ThreadPool.QueueUserWorkItem(o =>
        //{ // bize verilen thread main funksiyasi bu funksiyadir
        //    try
        //    {
        //        Download(cts.Token);
        //    }
        //    catch (OperationCanceledException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //});


        //Console.ReadKey();

        //cts.Cancel();

        //Console.ReadKey();


        //int a = 42;  // 101010          // 101010
        //int b = 23;                     // 010111
        //int result = a ^ b;             // 111101

        //Console.WriteLine(a & b);
        //Console.WriteLine(a | b);
        //Console.WriteLine(a ^ b);
        //Console.WriteLine(result ^ b);

        var path = Console.ReadLine();

        var key = Console.ReadLine();


        // encrypt in another thread;
        // after that
        Console.WriteLine("File Encrypted Successfuly");


    }

    #endregion
}