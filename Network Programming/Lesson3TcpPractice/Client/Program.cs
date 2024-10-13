using System.Net;
using System.Net.Sockets;


var ip = IPAddress.Parse("10.1.18.1");
var port = 27001;

var ep = new IPEndPoint(ip, port);

var client = new TcpClient();
Console.ReadKey();
try
{
    client.Connect(ep);
    if (client.Connected)
    {
        var path = @"C:\Users\namiqrasullu\Desktop\homeworkImap.png"; // screnshot

        using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            var buffer = new byte[1024];
            var len = 0;
            var networkStream = client.GetStream();

            while((len = fs.Read(buffer, 0,buffer.Length)) > 0)
            {
                networkStream.Write(buffer, 0, len);
            }

            networkStream.Close();
            client.Close();
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}