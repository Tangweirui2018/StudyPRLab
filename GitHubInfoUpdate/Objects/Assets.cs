using System.Text.Json.Serialization;

namespace ConsoleAppTEST;

public class Assets
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("state")]
    public string? State { get; set; }
    [JsonPropertyName("size")]
    public int Size { get; set; }
    [JsonPropertyName("download_count")]
    public int DownloadCount { get; set; }
    [JsonPropertyName("created_at")]
    public DateTime CreateTime { get; set; }
    [JsonPropertyName("updated_at")]
    public DateTime UpdatedTime { get; set; }
}