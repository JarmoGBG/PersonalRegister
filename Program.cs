using PersonalRegister;
using System;

public class PersonalRegisterClass
{
    static void Main(string[] args)
    {
        var register = new Register();
        bool go = true;

        do
        {
            
            Console.WriteLine("\nPress 1 to add new employee");
            Console.WriteLine("Press 2 to show all employees");
            Console.WriteLine("Press 3 to exit");

            var inputString = Console.ReadLine();
            int input = int.TryParse(inputString, out input) ? input : 0;

            switch (input)
            {
                case 0:
                    break;

                case 1:
                    Console.WriteLine("\nEnter name:");
                    string name = Console.ReadLine() ?? "";

                    Console.WriteLine("Enter salary:");
                    string salaryString = Console.ReadLine() ?? "";
                    int salary = int.TryParse(salaryString, out salary) ? salary : 0;

                    register.AddEmployee(name, salary);

                    break;

                case 2:
                    register.PrintEmployees();
                    break;
                case 3:
                    go = false;
                    break;
            }
        } while (go);
    }
}
