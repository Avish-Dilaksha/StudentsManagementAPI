using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace StudentsManagementAPI.Data
{
    public class StudentsManagementAPIContext : IdentityDbContext<IdentityUser>
    {
        public StudentsManagementAPIContext (DbContextOptions<StudentsManagementAPIContext> options)
            : base(options)
        {
        }

        public DbSet<StudentsManagementAPI.Models.Mentor> Mentor { get; set; } = default!;
        public DbSet<StudentsManagementAPI.Models.Student> Student { get; set; } = default!;
    }
}
