using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaskTracker.Data.Entities;

namespace TaskTracker.Data;
public class TaskTrackerDbContext(DbContextOptions<TaskTrackerDbContext> options) : IdentityDbContext<UserEntity, RoleEntity, int>(options)
{
    public DbSet<TaskEntity> Tasks { get; set; }
    public DbSet<UserEntity> Users { get; set; }
}
