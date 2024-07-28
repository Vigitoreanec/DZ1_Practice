
using DZ1_Practice.Model;

namespace DZ1_Practice.Data;

public class WorkerJornal
{
    public int Id { get; set; }
    public int EmployeeId {  get; set; }
    public DateTime DateCameWork { get; set; }
    public DateTime? DateEscWork { get; set; }
}
