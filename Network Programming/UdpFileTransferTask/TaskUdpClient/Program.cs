using System.Net;
using System.Net.Sockets;
using System.Text;

var endPoint = new IPEndPoint(IPAddress.Parse("10.1.18.1"), 27001);
var rep = new IPEndPoint(IPAddress.Any, 0);
var client = new UdpClient();

var path = @"C:\Users\namiqrasullu\Desktop\homework.png";

FileInfo file = new FileInfo(path);
var fileNameBytes = Encoding.UTF8.GetBytes(file.Name);
client.Send(fileNameBytes, fileNameBytes.Length, endPoint);
var fileLengthBytes = Encoding.UTF8.GetBytes(file.Length.ToString());
client.Send(fileLengthBytes, fileLengthBytes.Length, endPoint);

using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
{
    var bytes = new byte[5000];
    var len = 0;
    while((len = fs.Read(bytes, 0, bytes.Length)) > 0)
    {
        client.Send(bytes,len, endPoint);
        client.Receive(ref rep);
    }
}

Console.WriteLine("File sent");
Console.ReadKey();