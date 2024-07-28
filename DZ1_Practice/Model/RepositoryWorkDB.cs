
using DZ1_Practice.Data;

namespace DZ1_Practice.Model;

internal class RepositoryWorkDB : IRepositoryWork
{
    public void CameToWork(Employee employee)
    {
        using var context = new WorkerContext();
        var workerJornal = new WorkerJornal()
        {
            DateCameWork = DateTime.Now,
            EmployeeId = employee.Id
        };
        context.WorkerJornals.Add(workerJornal);
        context.SaveChanges();
    }

    public void EscFromWork(Employee employee)
    {
        using var context = new WorkerContext();
        var workerJornal = context.WorkerJornals.Where(x => x.EmployeeId == employee.Id && x.DateEscWork == null).First();
        workerJornal.DateEscWork = DateTime.Now;
        context.SaveChanges();
    }
}
