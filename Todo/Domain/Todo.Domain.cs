namespace TodoList.Domain
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public bool Done { get; set; }
        public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; private set; }

        protected Todo() {}

        public Todo(string title)
        {
            Title = title;
            Code = GenerateCode();
        }

        public void Update(string? title, bool? done)
        {
            if (title is not null)
                Title = title;

            if (done.HasValue)
                Done = done.Value;

            UpdatedAt = DateTime.UtcNow;
        }

        private static string GenerateCode()
        {
            return Guid.NewGuid().ToString("N")[..13];
        }
    }
}
