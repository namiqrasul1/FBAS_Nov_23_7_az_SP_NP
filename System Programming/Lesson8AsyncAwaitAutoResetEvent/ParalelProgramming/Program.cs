using Bogus;
using Lesson8ParallelPlinq.Fakers;

var students = InitalizeStudents.GenerateStudents(2000);

//foreach (var student in students)
//{
//    student.Group = "FBAS";
//    await Task.Delay(10);
//}

//Console.WriteLine("end");


//Task t = new(async () =>
//{
//    for (int i = 0; i < students.Count / 2; i++)
//    {
//        students[i].Group = "FBAS";
//        await Task.Delay(10);
//    }
//});

//Task t1 = new(async () =>
//{
//    for (int i = students.Count / 2; i < students.Count; i++)
//    {
//        students[i].Group = "FBAS";
//        await Task.Delay(10);
//    }
//});

//t.Start();
//t1.Start();

//await Task.WhenAll(t, t1); 

//Console.WriteLine("end");
//Console.ReadKey();


//Parallel.For(0, students.Count, async i =>
//{
//    await Console.Out.WriteLineAsync($"{Thread.CurrentThread.ManagedThreadId}");
//    students[i].Group = "FBAS";
//    await Task.Delay(10);
//});


//Parallel.ForEach(students, async s =>
//{

//    await Console.Out.WriteLineAsync($"{Thread.CurrentThread.ManagedThreadId}");
//    s.Group = "FBAS";
//    await Task.Delay(10);

//});


Parallel.Invoke(
    () => { Console.WriteLine("Hakuna 1"); },
    () => { Console.WriteLine("Hakuna 2"); },
    () => { Console.WriteLine("Hakuna 3"); },
    () => { Console.WriteLine("Hakuna 4"); },
    () => { Console.WriteLine("Hakuna 5"); },
    () => { Console.WriteLine("Hakuna 6"); }
    );

Console.WriteLine("end");