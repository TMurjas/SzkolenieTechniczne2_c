using System;
using System.Collections.Generic;
using System.Text;
using Zadania1Liskov.Logic.Abstract;

namespace Zadania1Liskov
{
    public interface IBonus
    {
        decimal CalcucateBonus(decimal salary);
    }
}
