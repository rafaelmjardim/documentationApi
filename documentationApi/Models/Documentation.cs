namespace documentationApi.Models
{
    public class Documentation
    {
        public int id { get; set; }
        public string title { get; set; } = string.Empty;
        public string patch { get; set; } = string.Empty;
        public string content { get; set; } = string.Empty;

    }
}
