using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTicketN.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilepictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
