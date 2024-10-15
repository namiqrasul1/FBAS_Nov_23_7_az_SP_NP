using System.Net;
using System.Net.Sockets;
using System.Text;

var endPoint = new IPEndPoint(IPAddress.Parse("10.1.18.1"), 27001);

var server = new UdpClient(endPoint);

Console.WriteLine("Server is running");
var remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);

while (true)
{
    var fileNameBytes = server.Receive(ref remoteEndPoint);
    var fileLengthBytes = server.Receive(ref remoteEndPoint);
    var fileName = Encoding.UTF8.GetString(fileNameBytes);
    int fileLength = int.Parse(Encoding.UTF8.GetString(fileLengthBytes));

    var path = $"{DateTime.Now:HH.mm.ss}{Path.GetExtension(fileName)}";

    using (var stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
    {
        var totalRecievedBytes = 0;
        while (true)
        {
            var fileBytes = server.Receive(ref remoteEndPoint);
            stream.Write(fileBytes);
            totalRecievedBytes += fileBytes.Length;
            server.Send(null, remoteEndPoint);
            if (fileLength == totalRecievedBytes)
                break;
        }
    }
  
    Console.WriteLine("File Downloaded");
}
