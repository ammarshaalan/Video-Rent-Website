using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using vidlko.Models;

namespace vidlko.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public DateTime? Birthdate { get; set; }

    //    [Min18YearsIfAMember]
        public int MembershipTypeId { get; set; }
        public MembershipTypeDto MembershipType { get; set; }
    }
}