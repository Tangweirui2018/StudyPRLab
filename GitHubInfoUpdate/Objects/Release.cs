using System.Text.Json.Serialization;

namespace ConsoleAppTEST;

public class Release
{
    [JsonPropertyName("html_url")]
    public string? HtmlUrl { get; set; }
    [JsonPropertyName("tag_name")]
    public string? TagName { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("prerelease")]
    public bool Prerelease { get; set; }
    [JsonPropertyName("created_at")]
    public DateTime CreateTime { get; set; }
    [JsonPropertyName("published_at")]
    public DateTime PublishTime { get; set; }
    [JsonPropertyName("body")]
    public string? Body { get; set; }
    [JsonPropertyName("assets")]
    public List<Assets>? Assets { get; set; }
}