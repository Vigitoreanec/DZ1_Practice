
using DZ1_Practice.Data;

namespace DZ1_Practice.Model;

public class Employee
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required DateTime DateOfBirth { get; set; }
    public required string JobTitle { get; set; }
    public required int Age { get; set; }   
    public required string Email { get; set; }
    public ICollection<WorkerJornal>? WorkerJornal { get; set; }
}
