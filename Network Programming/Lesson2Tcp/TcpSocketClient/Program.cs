using System.Net.Sockets;
using System.Net;
using System.Text;

using var listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

var ip = IPAddress.Parse("10.1.18.1");
var port = 27001;
var ep = new IPEndPoint(ip, port);

try
{
    listener.Connect(ep);
    if (listener.Connected)
    {
        _ = Task.Run(() =>
        {
            var bytes = new byte[1024];
            var len = 0;
            var msg = string.Empty;

            while ((len = listener.Receive(bytes)) > 0)
            {
                msg = Encoding.UTF8.GetString(bytes, 0, len);
                Console.WriteLine(msg);
            }
        });

        while (true)
        {
            var msg = "salam";
            var bytes = Encoding.UTF8.GetBytes(msg!); // check your msg
            listener.Send(bytes);
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}