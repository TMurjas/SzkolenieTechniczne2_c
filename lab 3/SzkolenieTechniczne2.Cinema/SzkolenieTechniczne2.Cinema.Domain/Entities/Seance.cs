using System.ComponentModel.DataAnnotations.Schema;
using SzkolenieTechniczne2.Cinema.Common.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SzkolenieTechniczne2.Cinema.Domain.Entities;

[Table("Seances", Schema = "Cinema")]
public class Seance: BaseEntity
{
    protected Seance() { }
    public Seance(int id, DateTime time, int seatsAvailable)
    {
        Id = id;
        Date = time;
        SeatsAvailable = seatsAvailable;
    }

    public int Id { get; protected set; }
    public DateTime Date { get;protected set; }
    public long MovieId {  get; protected set; }
    public Movie Movie { get; protected set; }

    public int SeatsAvailable { get; protected set; }
    public virtual ICollection<Ticket> Tickets { get; protected set; } = new HashSet<Ticket>();

    public List<Ticket> GetTicketByEmail(string email)
        => Tickets.Where(x=> x.Email == email)
            .OrderBy(x=>x.CreatedByUserId)
            .ToList();
    

    public List<Ticket> GetAllSeanceTickets()
       => Tickets.ToList();
   

    public void Add(Ticket ticket) 
       =>  Tickets.Add(ticket);
   

}
