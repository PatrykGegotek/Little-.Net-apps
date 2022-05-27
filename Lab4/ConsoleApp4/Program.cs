using ConsoleApp4.Data;
using ConsoleApp4.Data.Models;

namespace ConsoleApp4;

class Program
{
    static void Main(String[] args)
    {
        var dbContext = new SoftUniContext();
        using(dbContext)
        {
            var employees = from emp in dbContext.Employees select emp;
            foreach (var emp in employees)
            {
                Console.WriteLine(emp.FirstName);
            }
        }
    }
}