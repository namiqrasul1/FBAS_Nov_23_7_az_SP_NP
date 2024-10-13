using System.Net;
using System.Net.Sockets;

var ip = IPAddress.Parse("10.1.18.1");
var port = 27001;
var ep = new IPEndPoint(ip, port);

var listener = new TcpListener(ep);

try
{
    listener.Start();

    while (true)
    {
        var client = listener.AcceptTcpClient();

        _ = Task.Run(() =>
        {
            var networkStream = client.GetStream();
            var remoteEp = client.Client.RemoteEndPoint as IPEndPoint; // 10.1.18.3:1234
            var directoryPath = Path.Combine(Environment.CurrentDirectory, remoteEp!.Address.ToString());

            // "bin\10.1.18.3"
            if(!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);


            var path = Path.Combine(directoryPath, $"{DateTime.Now:dd.MM.yyyy.HH.mm.ss}.png"); 

            using (var fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                int len = 0;
                var bytes = new byte[1024];

                while ((len = networkStream.Read(bytes, 0, bytes.Length)) > 0)
                {
                    fs.Write(bytes, 0, len);
                }
            };

            Console.WriteLine("File recieved");
            client.Close();
        });
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


// "C:\Users\namiqrasullu\Desktop\Kamil"
//var directoryPath = Path.Combine(Environment.CurrentDirectory, "10.1.18.1:56465"!);