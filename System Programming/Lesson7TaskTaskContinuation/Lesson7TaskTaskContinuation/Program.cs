using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using static System.Threading.Thread;

//internal class Program
//{

//    #region Creating Task
//    //private static void TaskMethod(string name)
//    //{
//    //    Console.WriteLine($"{name} is running. Id: {CurrentThread.ManagedThreadId} IsThreadPoolThread: {CurrentThread.IsThreadPoolThread}");
//    //}

//    //private static void Main(string[] args)
//    //{
//    //    var task = new Task(() => TaskMethod("Task"));
//    //    task.Start();

//    //    new Task(() => TaskMethod("Task 1"), TaskCreationOptions.LongRunning).Start();

//    //    var task2 = Task.Run(() => TaskMethod("Task 2"));

//    //    var task3 = Task.Factory.StartNew(() => TaskMethod("Task 3"));
//    //    var task4 = Task.Factory.StartNew(() => TaskMethod("Task 4"), TaskCreationOptions.LongRunning);


//    //    Console.ReadKey();
//    //}

//    #endregion

//    #region Working

//    //private static int SomeMethod(int n)
//    //{
//    //    Console.WriteLine($"Task Id: {CurrentThread.ManagedThreadId} IsThreadPoolThread: {CurrentThread.IsThreadPoolThread}");
//    //    Thread.Sleep(4000);

//    //    return n * 2;
//    //}

//    //private static void SomeMethod1()
//    //{
//    //    Console.WriteLine($"Task Id: {CurrentThread.ManagedThreadId} IsThreadPoolThread: {CurrentThread.IsThreadPoolThread}");
//    //    Thread.Sleep(4000);
//    //}

//    //private static void Main(string[] args)
//    //{
//    //    //Console.WriteLine($"Main Id: {CurrentThread.ManagedThreadId} IsThreadPoolThread: {CurrentThread.IsThreadPoolThread}");

//    //    ////var task = new Task<int>(() => SomeMethod(4));
//    //    ////task.Start();

//    //    ////Console.WriteLine(task.Result);

//    //    //var task = new Task<int>(() => SomeMethod(4));
//    //    //task.RunSynchronously();

//    //    //Console.WriteLine(task.Result);

//    //    var task = new Task(SomeMethod1);
//    //    task.Start();

//    //    task.Wait();

//    //    Console.WriteLine("Task ishini qurtardi");

//    //    Console.ReadKey();

//    //}

//    #endregion

//    #region Continuation

//    //private static int TaskMethod(string name, int n)
//    //{
//    //    Console.WriteLine($"{name} is running. Id: {CurrentThread.ManagedThreadId} IsThreadPoolThread: {CurrentThread.IsThreadPoolThread}");

//    //    Thread.Sleep(TimeSpan.FromSeconds(n));

//    //    Console.WriteLine($"{name} completed");

//    //    return n * 2;
//    //}

//    //private static int TaskMethod1(string name, int n)
//    //{
//    //    Console.WriteLine($"{name} is running. Id: {CurrentThread.ManagedThreadId} IsThreadPoolThread: {CurrentThread.IsThreadPoolThread}");

//    //    throw new Exception();

//    //    Thread.Sleep(TimeSpan.FromSeconds(n));

//    //    Console.WriteLine($"{name} completed");

//    //    return n * 2;
//    //}

//    //private static void Main(string[] args)
//    //{
//    //    //var task = new Task<int>(() => { return TaskMethod("Task", 5); }, TaskCreationOptions.LongRunning);

//    //    //task.Start();
//    //    //task.ContinueWith(t =>
//    //    //{
//    //    //    Console.WriteLine($"Id: {CurrentThread.ManagedThreadId} IsThreadPoolThread: {CurrentThread.IsThreadPoolThread}");
//    //    //    Console.WriteLine(t.Result);
//    //    //});



//    //    //var task = new Task<int>(() => { return TaskMethod("Task", 5); }, TaskCreationOptions.LongRunning);

//    //    //task.Start();
//    //    //task.ContinueWith(t =>
//    //    //{
//    //    //    Console.WriteLine($"Id: {CurrentThread.ManagedThreadId} IsThreadPoolThread: {CurrentThread.IsThreadPoolThread}");
//    //    //    Console.WriteLine(t.Result);
//    //    //}, TaskContinuationOptions.LongRunning);

//    //    //var task = new Task<int>(() => { return TaskMethod1("Task", 5); }, TaskCreationOptions.LongRunning);

//    //    //task.Start();
//    //    ////task.ContinueWith(t =>
//    //    ////{
//    //    ////    Console.WriteLine($"Id: {CurrentThread.ManagedThreadId} IsThreadPoolThread: {CurrentThread.IsThreadPoolThread}");
//    //    ////    Console.WriteLine(t.Result);
//    //    ////}, TaskContinuationOptions.OnlyOnRanToCompletion);

//    //    //task.ContinueWith(t =>
//    //    //{
//    //    //    Console.WriteLine($"Id: {CurrentThread.ManagedThreadId} IsThreadPoolThread: {CurrentThread.IsThreadPoolThread}");
//    //    //    Console.WriteLine(t.Result);
//    //    //}, TaskContinuationOptions.NotOnCanceled | TaskContinuationOptions.NotOnFaulted);

//    //    //task.ContinueWith(t =>
//    //    //{
//    //    //    Console.WriteLine(CurrentThread.IsThreadPoolThread);
//    //    //    Console.WriteLine("Exception");
//    //    //}, TaskContinuationOptions.LongRunning | TaskContinuationOptions.OnlyOnFaulted);


//    //    //task.ContinueWith(t =>
//    //    //{
//    //    //    Console.WriteLine(CurrentThread.IsThreadPoolThread);
//    //    //    Console.WriteLine("Exception");
//    //    //}, TaskContinuationOptions.OnlyOnFaulted | TaskContinuationOptions.OnlyOnCanceled);
//    //    //// NotOnRanToCompletion | NotOnCanceled | NotOnRanToCompletion | NotOnFaulted
//    //    //Console.ReadKey();

//    //    //Task t = new(() => { TaskMethod("Task", 3); });
//    //    //Task t1 = new(() => { TaskMethod("Task 1", 5); });

//    //    //t.Start();
//    //    //t1.Start();

//    //    ////Task.Factory.ContinueWhenAll([t1, t], tasks =>
//    //    ////{
//    //    ////    Console.WriteLine("Her 2 task ishini bitirdi");
//    //    ////});

//    //    //Task.Factory.ContinueWhenAny([t, t1], completedTask =>
//    //    //{
//    //    //    Console.WriteLine("Ikisnden biri bitdi");
//    //    //});

//    //    //Console.ReadKey();

//    //}

//    #endregion


//    #region Sual

//    static List<string> strings = [];

//    static void AddElementsFromList(string filename)
//    {
//        List<string> list = ["salkal", "sadasdsad", "salkal", "sadasdsad","salkal", "sadasdsad", "salkal", "sadasdsad", "salkal", "sadasdsad", "salkal", "sadasdsad"];

//        foreach (string s in list)
//        {
//            strings.Add(s);
//        }
//    }

//    static void Main(string[] args)
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            ThreadPool.QueueUserWorkItem(o => { AddElementsFromList($"{i}.json"); });
//        }

//        foreach (string item in strings)
//        {
//            Console.WriteLine(item);
//        }
//    }



//    #endregion

//}


//object obj = new();

//lock (obj)
//{

//}

//void func()
//{
//    Console.WriteLine("salam");
//}

//var t = new Thread(func);
//t.Start();

//ThreadPool.QueueUserWorkItem(o => { func(); });

//_ = Task.Run(func);

//Console.ReadKey();

//  Thread.Sleep(2000); => await Task.Delay(2000);

//Task t = new( () => { Thread.Sleep(2000); });
//Task t1 = new(() => { Thread.Sleep(500000); });

//t.Start();
//t1.Start();

//await Task.WhenAny(t, t1);


//Console.WriteLine("asdkjhasjdk");
//Console.ReadKey();