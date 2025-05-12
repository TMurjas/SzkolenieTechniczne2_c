﻿using System;
using System.Collections.Generic;
using System.Text;
using Zadania1Liskov.Logic.Abstract;

namespace Zadania1Liskov
{
    public class TemporaryEmployee : Employee
    {
        private const decimal PREMIA = 0.5M;
        public TemporaryEmployee()
        {
        }

        public TemporaryEmployee(int id,string firstName, string lastName) : base(id,firstName,lastName)
        {
        }

        public override decimal CalcucateBonus(decimal salary)
        {
            return salary * PREMIA;
        }
    }
}
