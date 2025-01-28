namespace TaskManagerAPI.Models;

public class TaskModel
{
    public int Id { get; set; } // primary key
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool isCompleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}