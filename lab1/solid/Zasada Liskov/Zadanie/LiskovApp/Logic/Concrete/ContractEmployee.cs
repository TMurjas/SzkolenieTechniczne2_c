using System;
using System.Collections.Generic;
using System.Text;
using Zadania1Liskov.Logic.Abstract;

namespace Zadania1Liskov
{
   public class ContractEmployee  : Employee
    {
        public ContractEmployee()
        {
        }

        public ContractEmployee(int id, string firstName, string lastName) : base(id, firstName, lastName)
        {
        }
        public override decimal CalcucateBonus(decimal salary)
        {
            throw new NotImplementedException();
        }
    }
}
