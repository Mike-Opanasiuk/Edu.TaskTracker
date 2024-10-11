using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TaskTracker.Data.Entities;
public class UserEntity : IdentityUser<int>
{
    [StringLength(100)]
    public required string FirstName { get; set; }
    [StringLength(100)]
    public required string LastName { get; set; }
    public DateTime RegisterDate { get; set; }
    public IList<TaskEntity> Tasks { get; set; } = [];
}
