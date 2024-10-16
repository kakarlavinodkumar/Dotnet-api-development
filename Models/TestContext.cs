using Microsoft.EntityFrameworkCore;
using TestApi.Models;

namespace TodoApi.Models;

public class TestContext : DbContext
{
    public TestContext(DbContextOptions<TodoContext> options) : base(options)
    {
    }
    public DbSet<TestItem> TestItems {get; set; } = null!;
}