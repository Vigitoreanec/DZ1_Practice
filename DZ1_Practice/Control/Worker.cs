
using DZ1_Practice.Model;

namespace DZ1_Practice.Control;

public class Worker
{
    private readonly IRepositoryWork _repositoryWork;
    public Worker(IRepositoryWork repositoryWork)
    {
        _repositoryWork = repositoryWork;
    }
    public void CameToWork(Employee employee)
    {
        _repositoryWork.CameToWork(employee);
    }
    public void EscToWork(Employee employee)
    {
        _repositoryWork.EscFromWork(employee);
    }
}
