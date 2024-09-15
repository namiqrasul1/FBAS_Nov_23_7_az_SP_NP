using System.Diagnostics;

//void foo()
//{
//    while (true)
//    {
//        Console.WriteLine("Salam");
//    }
//}

//void boo()
//{
//    while (true)
//    {
//        Console.WriteLine("Sagol");
//    }
//}

//Thread thread = new(foo);
//thread.Start();
////foo();
//boo();


//Process.Start("mspaint");
//Process.Start("notepad");
//Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe");

//var processes = Process.GetProcesses();

//foreach (var process in processes)
//{
//    Console.WriteLine($"{process.ProcessName}");
//}


//Process.Start("mspaint");
//Process.Start("mspaint");
//Process.Start("mspaint");
//Process.Start("mspaint");
//Process.Start("mspaint");
//Process.Start("mspaint");
//Process.Start("mspaint");
//Process.Start("mspaint");
//Process.Start("mspaint");
//Process.Start("mspaint");
//Process.Start("mspaint");
//Process.Start("mspaint");
//Process.Start("mspaint");
//Process.Start("mspaint");
//Process.Start("mspaint");
//Process.Start("mspaint");
//Process.Start("mspaint");
//Process.Start("mspaint");
//Process.Start("mspaint");

//var paints = Process.GetProcessesByName("mspaint");

//foreach (var p in paints)
//{
//    p.Kill();
//}

var pr = Process.Start("mspaint");

Console.ReadKey();

pr.Kill();