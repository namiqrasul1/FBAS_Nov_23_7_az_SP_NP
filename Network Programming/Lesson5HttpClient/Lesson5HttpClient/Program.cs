using System.Net;
using System.Text.Json;

class WebHost
{
    private short _port;
    private HttpListener _listener;

    public WebHost(short port)
    {
        _port = port;
    }

    public void Run()
    {
        _listener = new HttpListener();
        _listener.Prefixes.Add($"http://localhost:{_port}/");

        _listener.Start();

        while (true)
        {
            var context = _listener.GetContext();

            _ = Task.Run(() => { RequestHandle(context); });
        }
    }

    private void RequestHandle(HttpListenerContext context)
    {
        var str = context.Request.RawUrl; // /asdasd/home

        Console.WriteLine(context.Request.HttpMethod);
        Console.WriteLine(context.Request.QueryString);

        // users // HttpMethod == Get
        // users  HttpMethod == POST
        // users  HttpMethod == Delete


        var path = string.Empty;
        if (!string.IsNullOrWhiteSpace(str) && str.EndsWith(".jpg"))
            path = @$"C:\Users\namiqrasullu\Desktop\FBAS_Nov_23_7_az_SP_NP\Network Programming\Lesson5HttpClient\Lesson5HttpClient\Images\{str.Split('/').Last()}";
        else
            path = @$"C:\Users\namiqrasullu\Desktop\FBAS_Nov_23_7_az_SP_NP\Network Programming\Lesson5HttpClient\Lesson5HttpClient\Views\{str?.Split('/').Last()}.html";



        var response = context.Response;
        var stream = response.OutputStream;

        try
        {
            response.ContentType = Path.GetExtension(path) == ".jpg" ? "image/jpg" : "text/html";
            var src = File.ReadAllBytes(path);
            stream.Write(src);
        }
        catch
        {
            var src = File.ReadAllBytes(@$"C:\Users\namiqrasullu\Desktop\FBAS_Nov_23_7_az_SP_NP\Network Programming\Lesson5HttpClient\Lesson5HttpClient\Views\Error.html");
            stream.Write(src);
        }
        finally
        {
            stream.Close();
        }
    }
}


class Program
{
    private static void Main(string[] args)
    {
        new WebHost(27001).Run();
    }
}
























//using HttpClient client = new();

//var response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");

//var result = await response.Content.ReadAsStringAsync();

//var result = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
//var result = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts/15");
////var stream = await client.GetStreamAsync("https://jsonplaceholder.typicode.com/posts");

//Console.WriteLine(result);

//var post = new { id = 1, userId = 1, title = "asdhaskjd", body = "akjhsdhjkasdhjas" };

//var content = new StringContent(JsonSerializer.Serialize(post));

//var response = await client.PostAsync("https://jsonplaceholder.typicode.com/posts", content);

//if (response.IsSuccessStatusCode)
//{
//    Console.WriteLine("Post Added");

//    Console.WriteLine(((int)response.StatusCode));
//}

//var response = await client.PutAsync("https://jsonplaceholder.typicode.com/posts", content);
//Console.WriteLine(response.StatusCode);
//if (response.IsSuccessStatusCode)
//{
//    Console.WriteLine(response.StatusCode);
//}

//var response = await client.DeleteAsync("https://jsonplaceholder.typicode.com/posts/5");

//Console.WriteLine(response.StatusCode);

