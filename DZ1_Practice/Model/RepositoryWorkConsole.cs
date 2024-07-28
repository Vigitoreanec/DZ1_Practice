
namespace DZ1_Practice.Model;

public class RepositoryWorkConsole : IRepositoryWork
{
    public void CameToWork(Employee employee)
    {
        var carentDate = DateTime.Now;
        Console.WriteLine($"{employee.FirstName}, {employee.LastName}, возраст - {employee.Age} : должность {employee.JobTitle}\n Пришел на работу в {carentDate}");
    }
    public void EscFromWork(Employee employee)
    {
        var carentDate = DateTime.Now;
        Console.WriteLine($"{employee.FirstName}, {employee.LastName} - Ушел с работы {carentDate}");
    }
}
