using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TaskTracker.Data.Entities;
public class RoleEntity : IdentityRole<int>
{
    public List<UserEntity> Users { get; set; } = [];
}
