using Microsoft.EntityFrameworkCore;
using Test.Web.Data;

namespace Test.Web
{
    public class AppDbCtx : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }
        
        public AppDbCtx(DbContextOptions<AppDbCtx> options) : base(options)  
        {   
        }
    }
}