namespace ToDoWebApp.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Task { get; set; }
        // public string? Description { get; set; }
        public bool IsCompleted { get; set; }
    }
    
}