using Microsoft.EntityFrameworkCore;
namespace WebStudy
{
    public class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options)
        : base(options) { }

        public DbSet<Todo> todos => Set<Todo>();
    }
}
