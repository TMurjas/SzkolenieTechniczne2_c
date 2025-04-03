using System;
using System.Collections.Generic;
using System.Text;
using Zadania1Liskov.Logic.Abstract;

namespace Zadania1Liskov
{
	public interface IEmployee
	{
		int Id { get; set; }

		string FirstName { get; set; }
		string LastName { get; set; }

		decimal GetMinimalSalory();
	}
}