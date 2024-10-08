using System.Text;

namespace TcpServer.Helper;

internal class FileStreamWriteAdapter : IDisposable
{
    private readonly Stream _stream;

    public FileStreamWriteAdapter(Stream stream)
    {
        _stream = stream;
    }

    public FileStreamWriteAdapter(string path, FileMode fileMode, FileAccess fileAccess)
    {
        _stream = new FileStream(path, fileMode, fileAccess);
    }

    public FileStreamWriteAdapter(string path)
    {
        _stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
    }

    public void Write(string str)
    {
        var bytes = Encoding.UTF8.GetBytes(str);
        _stream.Write(bytes, 0, bytes.Length);
    }

    public void Write(int value)
    {
        var bytes = Encoding.UTF8.GetBytes(value.ToString());
        _stream.Write(bytes, 0, bytes.Length);
    }

    public void Dispose()
    {
        _stream.Dispose();
    }
}
