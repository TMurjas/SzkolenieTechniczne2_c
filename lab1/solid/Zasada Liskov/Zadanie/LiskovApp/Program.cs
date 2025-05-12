using System;
using Zadania1Liskov;
using Zadania1Liskov.Logic.Abstract;

namespace LiskovApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee temporaryEmployee = new TemporaryEmployee(1,"Lukasz","Piechocki");
            Employee contractEmployee = new ContractEmployee(2, "Patryk", "Kiełb");

            Console.WriteLine(string.Format("Pracownik {0} Bonus {1}",
                temporaryEmployee.ToString(),temporaryEmployee.CalcucateBonus(1000).ToString()));


            Console.WriteLine(string.Format("Pracownik {0} Bonus {1}",
                contractEmployee.ToString(), contractEmployee.CalcucateBonus(1000).ToString()));
            Console.ReadKey();
        }
    }
}
