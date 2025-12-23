namespace TodoList.Domain
{
    public class TodoDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = "";
        public bool Done { get; set; } = false;
    }
}
