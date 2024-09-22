void copyFile(string source, string destination)
{

    if (File.Exists(source))
    {
        if (!Path.Exists(destination) && !Path.HasExtension(destination))
            Directory.CreateDirectory(destination);
        try
        {
            using (var sourceStream = new FileStream(source, FileMode.Open, FileAccess.Read))
            {
                if (!Path.HasExtension(destination))
                    destination = $@"{destination}\{Path.GetFileNameWithoutExtension(source)}Copy{Path.GetExtension(source)}";

                if (Path.GetExtension(source) == Path.GetExtension(destination))
                {
                    using (var destinationStream = new FileStream(destination, FileMode.OpenOrCreate, FileAccess.Write))
                    {
                        var len = 2000;
                        var bytes = new byte[len];
                        var totalBytes = 0;
                        do
                        {
                            len = sourceStream.Read(bytes, 0, len);
                            destinationStream.Write(bytes, 0, len);
                            totalBytes += len;
                            //Console.WriteLine(totalBytes);
                            Thread.Sleep(10);

                        } while (0 < len);
                    }
                    Console.WriteLine("File copied");
                }
                else
                {
                    Console.WriteLine("Choose correct file");
                    // ex.Message log
                    Console.WriteLine("Press any key for continue");
                    Console.ReadKey();
                }

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Something went wrong");
            // ex.Message log
            Console.WriteLine("Press any key for continue");
            Console.ReadKey();
            

        }

    }
    else
    {
        Console.WriteLine("File not found");
        Console.WriteLine("Press any key for continue");
        Console.ReadKey();
    }

}

while (true)
{
    Console.Write("Source Path: ");
    var source = Console.ReadLine()!; // C:\Users\namiqrasullu\Desktop\homework.png
    Console.Write("Destination Path: ");
    var destination = Console.ReadLine()!; // C:\Users\namiqrasullu\Desktop\Kamil

    //Console.WriteLine($@"{destination}\{Path.GetFileNameWithoutExtension(source)}Copy{Path.GetExtension(source)}");    
    //Console.WriteLine($@"{destination}\{Path.GetFileName(source)}");

    //copyFile(source, destination); // single thread

    var thread = new Thread(() => { copyFile(source, destination); });
    thread.Start();

    //thread.Join();
}