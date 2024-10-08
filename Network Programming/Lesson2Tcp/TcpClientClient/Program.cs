using System.Net;
using System.Net.Sockets;

Console.WriteLine("TcpClient");

var client = new TcpClient();

var ep = new IPEndPoint(IPAddress.Parse("10.1.18.1"), 27001);

try
{
    client.Connect(ep);
    if (client.Connected)
    {
        var networkStream = client.GetStream();
        var sw = new StreamWriter(networkStream)
        {
            AutoFlush = true
        };

        while (true)
        {
            var msg = Console.ReadLine()!;
            sw.WriteLine(msg);
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}