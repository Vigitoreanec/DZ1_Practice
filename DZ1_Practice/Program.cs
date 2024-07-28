// See https://aka.ms/new-console-template for more information
using DZ1_Practice.Control;
using DZ1_Practice.Data;
using DZ1_Practice.Model;
using Microsoft.Extensions.DependencyInjection;

Console.WriteLine("Console ADD Employee");

//var services = new ServiceCollection();
//services.AddSingleton<IRepositoryWork, RepositoryWorkConsole>();
//services.AddSingleton<Worker>();

//using var serviceProvider = services.BuildServiceProvider();



//var employee = new Employee()
//{
//    FirstName = "Sergey",
//    LastName = "Suchev",
//    DateOfBirth = new DateTime(1986, 3, 18),
//    JobTitle = "Programmer",
//    Age = 21,
//    Email = "Cskdj@Gmain.ru"
//};
// 1
//var worker = new Worker(new RepositoryWork());
//worker.CameToWork(employee);
//Thread.Sleep(3000);
//Console.WriteLine("+++++++++======------");
//worker.EscToWork(employee);

//2 
//var worker = serviceProvider.GetRequiredService<Worker>();
//worker.CameToWork(employee);
//Thread.Sleep(2000);
//Console.WriteLine("---------------");
//worker.EscToWork(employee);

//3 
var services = new ServiceCollection();
services.AddSingleton<IRepositoryWork, RepositoryWorkDB>();
services.AddSingleton<Worker>();

using var context = new WorkerContext();
var employee = context.Employees.Where(x => x.Id == 1).First();

using var serviceProvider = services.BuildServiceProvider();
var worker = serviceProvider.GetRequiredService<Worker>();

//3.1
//worker.CameToWork(employee);
//Thread.Sleep(3000);
//Console.WriteLine("---------------");
//worker.EscToWork(employee);
//3.2
//worker.CameToWork(employee);
//3.3
worker.CameToWork(employee);
Thread.Sleep(3000);
Console.WriteLine("---------------");
worker.EscToWork(employee);