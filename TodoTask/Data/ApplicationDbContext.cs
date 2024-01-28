using Microsoft.EntityFrameworkCore;
using TodoTask.Models;

namespace TodoTask.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op) { }
        public DbSet<TodoList> Todos { get; set; }
    }
}
