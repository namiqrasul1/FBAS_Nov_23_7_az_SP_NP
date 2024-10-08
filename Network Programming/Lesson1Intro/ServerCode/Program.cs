using System.Net;
using System.Net.Sockets;
using System.Text;

Console.WriteLine("Server");

using var listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

var ipAddress = IPAddress.Parse("10.1.18.1"); // ipconfig in terminal
var port = 27001; // netstat -a

var endPoint = new IPEndPoint(ipAddress, port);

try
{
    listener.Bind(endPoint);
    listener.Listen();


    while (true)
    {
        var client = listener.Accept();
        Console.WriteLine($"{client.RemoteEndPoint} is connected");

        _ = Task.Run(() =>
        {
            var bytes = new byte[1024];
            var len = 0;
            var msg = string.Empty;

            while (true)
            {
                len = client.Receive(bytes);
                msg = Encoding.UTF8.GetString(bytes, 0, len);

                if (msg.Equals("exit", StringComparison.CurrentCultureIgnoreCase))
                {
                    client.Shutdown(SocketShutdown.Send);
                    client.Close();
                    break;
                }

                Console.WriteLine(msg);
            }
        });

    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}