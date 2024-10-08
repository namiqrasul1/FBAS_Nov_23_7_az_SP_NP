﻿using System.Text.Json.Serialization;

namespace AsyncAwait.Models;

public class Post
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("body")]
    public string Body { get; set; }

    [JsonPropertyName("userId")]
    public int UserId { get; set; }

    public override string ToString()
    {
        return Title; 
    }
}
