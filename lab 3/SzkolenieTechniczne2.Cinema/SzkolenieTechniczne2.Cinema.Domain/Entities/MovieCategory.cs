using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SzkolenieTechniczne2.Cinema.Common.Entities;

namespace SzkolenieTechniczne2.Cinema.Domain.Entities
{
    public class MovieCategory : BaseEntity
    {



        [Required]
        [MaxLength(100)]
        public String Name { get; protected set; }

        public virtual ICollection<Movie> Movies { get; protected set; } = new List<Movie>();

        public MovieCategory(String name) { Name = name; }

   

     
        


    }
}
