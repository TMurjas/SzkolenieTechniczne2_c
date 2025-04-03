using System;
using System.Collections.Generic;
using Zadania1Liskov;
using Zadania1Liskov.Logic.Abstract;

namespace LiskovApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TemporaryEmployee temporaryEmployee = new TemporaryEmployee(1,"Lukasz","Piechocki");
            Employee contractEmployee = new ContractEmployee(2, "Patryk", "Kiełb");

            Console.WriteLine(string.Format("Pracownik {0} Bonus {1}",
                temporaryEmployee.ToString(),temporaryEmployee.CalcucateBonus(1000).ToString()));

            Console.WriteLine(string.Format("Pracownik {0} Bonus {1}",
                contractEmployee.ToString() ));


            List<IEmployee> list = new List<IEmployee>();
            list.Add(contractEmployee);
            list.Add(temporaryEmployee);

            foreach (IEmployee emp in list)
            {
                emp.GetMinimalSalory();
            }

            List<IBonus> bons = new List<IBonus>();
            list.Add(temporaryEmployee);

            foreach (IBonus emp in list)
            {
                emp.CalcucateBonus(1000);
            }




            Console.ReadKey();
        }
    }
}
