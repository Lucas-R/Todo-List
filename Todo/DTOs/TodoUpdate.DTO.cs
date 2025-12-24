using System.Text.Json.Serialization;

namespace TodoList.DTOs
{
    public class TodoUpdateDTO
    {
        [JsonPropertyName("title")]
        public string Title { get; set; } = string.Empty;

        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }
}