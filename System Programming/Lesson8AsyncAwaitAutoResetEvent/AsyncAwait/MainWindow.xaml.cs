using AsyncAwait.Data;
using AsyncAwait.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text.Json;
using System.Windows;

namespace AsyncAwait
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public ObservableCollection<Post> Items { get; set; }
        public ObservableCollection<Book> Items { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Items = [];
            DataContext = this;

            //DoSomething();
        }

        //public async void DoSomething()
        //{
        //    List<string> list = await GetStrings();

        //    foreach (string item in list)
        //    {
        //        Items.Add(item);
        //        await Task.Delay(200);
        //    }
        //}

        //private async Task<List<string>> GetStrings()
        //{
        //    return ["aasdas", "asdasdasd", "aasdas", "asdasdasd", "aasdas", "asdasdasd", "aasdas", "asdasdasd", "aasdas", "asdasdasd", "aasdas", "asdasdasd"];
        //}



        #region First Example

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    Thread th = new(() =>
        //    {
        //        Thread.Sleep(10000);
        //        Dispatcher.Invoke(() => { lbl.Content = "Hakuna Matata"; });
        //    });
        //    th.Start();
        //}

        //private async Task<string> DoSomethingAsync()
        //{
        //    //await Task.Delay(3000);
        //    //return "hakuna matata";


        //    HttpClient client = new();
        //    var result = await client.GetStringAsync("http://www.google.com");

        //    return result;

        //}

        //private async void Button_Click_1(object sender, RoutedEventArgs e)
        //{
        //    var result = await DoSomethingAsync();
        //    lbl.Content = await DoSomethingAsync();
        //}

        #endregion

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            using var context = new AppDbContext();
            var books = context.Books.AsParallel().ToList();

            foreach (var book in books)
            {
                Items.Add(book);
            }


            //var client = new HttpClient();

            //var result = await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts");

            //var posts = JsonSerializer.Deserialize<List<Post>>(result);

            //foreach (var item in posts)
            //{
            //    Items.Add(item);
            //}
        }
    }
}