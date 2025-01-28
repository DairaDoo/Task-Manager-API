using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagerAPI.Models;

public class TaskModel
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // creado para que el id, se autoincremente.
    public int Id { get; set; } // primary key
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool isCompleted { get; set; } = false;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}