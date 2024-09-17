internal class Program
{
    private static void SomeMethod()
    {
        Console.WriteLine(Thread.CurrentThread.Name);
        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

        for (int i = 0; i < 1000; i++)
        {
            Console.WriteLine('y');
            //Thread.Sleep(100);
        }
        Console.WriteLine();
    }

    private static void SomeMethod1()
    {
        var thread = Thread.CurrentThread;
        Console.WriteLine($"{thread.Name} {thread.ManagedThreadId}");

        Console.WriteLine("Thread Started");
        Thread.Sleep(10000);
        Console.WriteLine("Thread Finished");
    }

    private static void SomeParametrizedMethod(object? state)
    {
        // is || as || cast
        //if(state is Program)
        //{
        //}
        Console.WriteLine(state);
    }

    private static void Foo(int i)
    {
        Console.WriteLine(i);
    }

    static class Counter
    {
        public static int count = 0;
    }

    private static void Download(string soucrePath, string destDir)
    {

    }


    private static void Main(string[] args)
    {
        #region Thread Example

        //var thread = new Thread(SomeMethod);
        ////thread.Priority = ThreadPriority.Highest;
        //thread.Name = "Ikinci Thread";

        //Thread.CurrentThread.Name = "Main Thread";
        //Console.WriteLine(Thread.CurrentThread.Name);
        //Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

        //thread.Start();

        //for (int i = 0; i < 1000; i++)
        //{
        //    Console.WriteLine('x');
        //    //Thread.Sleep(100);
        //}
        //Console.WriteLine();

        #endregion

        #region Foreground vs Background Thread

        //var th = new Thread(SomeMethod1);
        //th.IsBackground = true;

        //th.Start();
        //Console.ReadKey();

        #endregion

        #region ParametrizedThreadStart

        //SomeParametrizedMethod(new Program());

        //var th = new Thread(SomeParametrizedMethod);
        //th.Start("hakuna matata");

        //var th = new Thread(() =>
        //{
        //    // hemin thread'in main funksiyasi
        //    Foo(42);
        //});
        //th.Start();

        #endregion



        //for (int i = 0; i < 10; i++)
        //{
        //    int t = i;
        //    var th = new Thread(() => { Console.WriteLine(t); });
        //    th.Start();
        //}


        //var str = "Muro";
        //var th = new Thread(() => { Console.WriteLine(str); });
        //str = "Humo";
        //var th1 = new Thread(() => { Console.WriteLine(str); });

        //th.Start();
        //th1.Start();



        //Thread thread = new(() => { Console.WriteLine("Salam");  Thread.Sleep(2000); });
        //thread.Start();

        //thread.Join();

        //Console.WriteLine("Sagol");




    }
}