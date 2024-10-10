using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Data.Entities.Enums;
using TaskStatus = TaskTracker.Data.Entities.Enums.TaskStatus;

namespace TaskTracker.Data.Entities;
public class TaskEntity
{
    public int Id { get; set; }
    [Required]
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskStatus Status { get; set; }
    public TaskPriority Priority { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsDeleted { get; set; }
    public int UserId { get; set; }
    public UserEntity? User { get; set; }
}
