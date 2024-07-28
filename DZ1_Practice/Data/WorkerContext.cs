
using DZ1_Practice.Model;
using Microsoft.EntityFrameworkCore;

namespace DZ1_Practice.Data;

public class WorkerContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<WorkerJornal> WorkerJornals { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=MSI;Initial Catalog=MyWorkerService;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;");
    }
}
