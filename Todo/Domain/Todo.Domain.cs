namespace TodoList.Domain
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public bool Done { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        protected Todo() {}

        public Todo(string title)
        {
            Title = title;
            Code = GenerateCode();
        }

        private static string GenerateCode()
        {
            return Guid.NewGuid().ToString("N")[..13];
        }
    }
}
