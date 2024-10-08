using System.Net;
using System.Net.Sockets;
using System.Text;

using var listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

var sockets = new List<Socket>();

var ip = IPAddress.Parse("10.1.18.1");
var port = 27001;
var ep = new IPEndPoint(ip, port);

try
{
    listener.Bind(ep);
    listener.Listen();

    Console.WriteLine($"Listener: {listener.LocalEndPoint}");

    while (true)
    {
        var client = listener.Accept();
        sockets.Add(client);

        Console.WriteLine($"Client: {client.RemoteEndPoint}");

        _ = Task.Run(() =>
        {
            var bytes = new byte[1024];
            var msg = string.Empty; // ""
            var len = 0;

            while (true)
            {
                len = client.Receive(bytes);
                msg = Encoding.UTF8.GetString(bytes, 0, len);

                if (msg.Equals("exit", StringComparison.CurrentCultureIgnoreCase))
                {
                    client.Shutdown(SocketShutdown.Send);
                    break;
                }

                foreach (var socket in sockets)
                {
                    if (socket.Connected && client != socket)
                    {
                        var bytesMsg = Encoding.UTF8.GetBytes(msg);
                        socket.Send(bytesMsg);
                    }
                }

                Console.WriteLine($"{client.RemoteEndPoint}: {msg}");
            }
        });

    }
}
catch (Exception ex)
{
    // logging
    Console.WriteLine(ex.Message);

}