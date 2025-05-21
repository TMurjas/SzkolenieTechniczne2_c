﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Sockets;
using SzkolenieTechniczne2.Cinema.Common.Entities;

namespace SzkolenieTechniczne2.Cinema.Domain.Entities
{
    [Table("Seances", Schema = "Cinema")]
    public class Seance : BaseEntity
    {
        protected Seance()
        {
        }

        public Seance(DateTime date, long movieId)
        {
            Date = date;
            MovieId = movieId;
        }

        public DateTime Date { get; protected set; }


        public long MovieId { get; protected set; }
        public Movie Movie { get; protected set; }

        public virtual ICollection<Ticket> Tickets { get; protected set; } = new HashSet<Ticket>();

        public List<Ticket> GetTicketByEmail(string email)
        {
            return Tickets.Where(x => x.Email == email)
                .OrderBy(x => x.CreatedOn)
            .ToList();
        }

        public List<Ticket> GetAllSeanceTicket()
        {
            return Tickets == null ? new List<Ticket>()
                : Tickets.ToList();
        }

        public void Add(Ticket ticket)
        {
            Tickets.Add(ticket);
        }
    }
}
