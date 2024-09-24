//internal class Program
//{
//    private static int _count = 0;
//    private static object _lock = new();
//    private static void Increment()
//    {
//        lock (_lock)
//        {
//            _count = 0;

//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine($"{Thread.CurrentThread.Name}: {++_count}");
//            }
//        }
//    }

//    private static void Main(string[] args)
//    {
//        for (int i = 0; i < 5; i++)
//        {
//            Thread thread = new(Increment);
//            thread.Name = $"Thread{i}";
//            thread.Start();
//        }
//    }
//}


//class Singleton
//{
//    private static Singleton _instance;

//    private Singleton() {}
//    private static object obj = new();
//    public static Singleton GetInstance()
//    {
//        lock (obj)
//        {
//            if (_instance is null)
//                _instance = new Singleton();
//            return _instance;
//        }
//    }
//}


//static class Counter
//{
//    public static int count = 0;
//}

//class Program
//{
//    private static void Increment()
//    {
//        // problem
//        //for (int i = 0; i < 1_000_000; i++)
//        //{
//        //    Counter.count++;
//        //}

//        // Monitor
//        //for (int i = 0; i < 1_000_000; i++)
//        //{
//        //    try
//        //    {
//        //        Monitor.Enter(_sync);

//        //        Counter.count++;
//        //    }
//        //    finally
//        //    {
//        //        Monitor.Exit(_sync);
//        //    }
//        //}

//        // Interlocked
//        //for (int i = 0; i < 1_000_000; i++)
//        //{
//        //    //Interlocked.Add(ref Counter.count, 2);
//        //    Interlocked.Increment(ref Counter.count);
//        //}

//        // lock
//        for (int i = 0; i < 1_000_000; i++)
//        {
//            lock (_sync)
//            {
//                Counter.count++;
//            }
//        }
//    }

//    private static object _sync = new object();

//    private static void Main(string[] args)
//    {
//        //Thread[] threads = new Thread[5];

//        //for (int i = 0; i < 5; i++)
//        //{
//        //    threads[i] = new Thread(Increment);
//        //}

//        //for (int i = 0; i < 5; i++)
//        //{
//        //    threads[i].Start();
//        //}

//        //for (int i = 0; i < 5; i++)
//        //{
//        //    threads[i].Join();
//        //}

//        //Console.WriteLine(Counter.count);

//    }
//}


using Bogus;
using Lesson5CriticalSectionMonitorLock.Models;
using System.Text.Json;

void generateUsers(int count)
{
    for (int i = 0; i < count; i++)
    {
        Faker<User> faker = new();

        var users = faker.RuleFor(u => u.Name, f => f.Person.FirstName)
            .RuleFor(u => u.Surname, f => f.Person.LastName)
            .RuleFor(u => u.Email, f => f.Internet.Email())
            .RuleFor(u => u.DateOfBirth, f => f.Person.DateOfBirth)
            .Generate(50);


        var json = JsonSerializer.Serialize(users);
        File.WriteAllText($"users{i + 1}.json", json);
    }
}


generateUsers(5);