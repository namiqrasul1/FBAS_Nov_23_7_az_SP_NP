using System.Net;
using System.Net.Sockets;
using System.Text;

//using var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

//var ipAddress = IPAddress.Parse("142.250.187.142");
//var port = 80; 

//var endPoint = new IPEndPoint(ipAddress, port);

//try
//{
//    socket.Connect(endPoint);
//    if (socket.Connected)
//    {
//        var str = "GET\r\n\r\n";
//        var bytes = Encoding.UTF8.GetBytes(str);

//        socket.Send(bytes);

//        var len = 0;
//        var buffer = new byte[1024];
//        do
//        {
//            len = socket.Receive(buffer);
//            var response = Encoding.UTF8.GetString(buffer);

//            Console.WriteLine(response);
//            Thread.Sleep(100);
//        } while (0 < len);
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

using var client = new HttpClient();

//var result = await client.GetStringAsync("http://google.com");
var result = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts");


Console.WriteLine(result);