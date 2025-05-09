// See https://aka.ms/new-console-template for more information
using GenericRepositoryDemo;

IRepository<Customer> customerRepo = new GenericRepository<Customer>();

var alice = new Customer { Name = "Alice" };
customerRepo.Add(alice);

var bob = new Customer { Name = "Bob" };
customerRepo.Add(bob);

customerRepo.Save();

Console.WriteLine("All customers:");
foreach (var c in customerRepo.GetAll())
{
    Console.WriteLine($"{c.Id}: {c.Name}");
}

Console.WriteLine("Remove Alice and save:");
customerRepo.Remove(alice);
customerRepo.Save();

Console.WriteLine("Remaining customers:");
foreach (var c in customerRepo.GetAll())
{
    Console.WriteLine($"{c.Id}: {c.Name}");
}
