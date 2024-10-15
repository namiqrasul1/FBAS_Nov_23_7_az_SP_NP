using System.Net;
using System.Net.Sockets;
using System.Text;

Console.WriteLine("Server");
var endPoint = new IPEndPoint(IPAddress.Parse("10.1.18.1"), 27001);
var server = new UdpClient(endPoint);

var remoteEp = new IPEndPoint(IPAddress.Any, 0); // mene mesaj gonderen adam uchun

while (true)
{
    var bytes = server.Receive(ref remoteEp);
    var str = Encoding.UTF8.GetString(bytes);
    Console.WriteLine($"{remoteEp}: {str}");
}


//var path = @"C:\Users\namiqrasullu\Desktop\homeworkImap.png";

//using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
//{
//    using (var ms = new MemoryStream())
//    {
//        var len = 0;
//        var bytes = new byte[1024];
//        while ((len = fs.Read(bytes, 0, bytes.Length)) > 0)
//        {
//            ms.Write(bytes, 0, len);
//        }

//        File.WriteAllBytes("t.png", ms.ToArray());
//    }
//}