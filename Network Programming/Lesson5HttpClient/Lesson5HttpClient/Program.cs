using System.Text.Json;

using HttpClient client = new();

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

var response = await client.DeleteAsync("https://jsonplaceholder.typicode.com/posts/5");

Console.WriteLine(response.StatusCode);