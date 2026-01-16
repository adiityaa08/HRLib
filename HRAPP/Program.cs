using HRLib;
using System.Text;
namespace HRAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConfirmEmployee confirmEmployee;
            try
            {
                confirmEmployee = new ConfirmEmployee();
                Console.WriteLine(confirmEmployee);
                Console.WriteLine($"Salary: {confirmEmployee.CalculateSalary()}");
            }
            catch(BasicTooLowException ex)
            {
                Console.WriteLine(ex.Message); 
            }
            Console.WriteLine("--------------------------");
            try
            {
                ConfirmEmployee confirmEmployee1 = new ConfirmEmployee("Aditya", "Pune", 500, "Senior Engineer");
                Console.WriteLine(confirmEmployee1);
                Console.WriteLine($"Salary: {confirmEmployee1.CalculateSalary()}");
            }
            catch (BasicTooLowException ex)
            {
                Console.WriteLine(ex.Message);
            }
           

            Trainee trainee = new Trainee();
            Console.WriteLine(trainee);
            Console.WriteLine($"salary :{trainee.CalculateSalary()}");

            Console.WriteLine("--------------------------");

            Trainee trainee1 = new Trainee("Aditya", "delhi", 5, 20);
            Console.WriteLine(trainee1);
            Console.WriteLine($"salary :{trainee1.CalculateSalary()}");
        }
    }
}
