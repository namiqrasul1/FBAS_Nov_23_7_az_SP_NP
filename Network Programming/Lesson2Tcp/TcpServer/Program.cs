using System.Net;
using System.Net.Sockets;
using System.Text;
using TcpServer.Helper;

//Console.WriteLine("TcpListener");

//var ip = IPAddress.Parse("10.1.18.1");
//var port = 27001;
//var ep = new IPEndPoint(ip, port);

//var listener = new TcpListener(ep);

//try
//{
//    listener.Start();

//    while (true)
//    {
//        var client = listener.AcceptTcpClient();

//        _ = Task.Run(() =>
//        {
//            Console.WriteLine($"{client.Client.RemoteEndPoint} is connected");

//            var networkStream = client.GetStream();
//            var sr = new StreamReader(networkStream);

//            while (true)
//            {
//                var msg = sr.ReadLine();
//                Console.WriteLine($"{client.Client.RemoteEndPoint}: {msg}");
//            }

//        });
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//using var adapter = new FileStreamWriteAdapter("txt.txt");
//adapter.Write("hakuna matata");
//adapter.Write(42);



using var fs = new FileStream("txt.txt", FileMode.OpenOrCreate, FileAccess.Write);
var bytes = Encoding.UTF8.GetBytes("hakuna");

fs.Write(bytes, 0, bytes.Length);
fs.Flush();

Console.ReadKey();


