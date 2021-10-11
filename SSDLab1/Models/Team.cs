using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SSDLab1.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [Required, Display(Name = "Team Name")]
        public string TeamName { get; set; }

        [Required]
        public string Email { get; set; }

        [Display(Name = "Date Established")]
        public string? EstablishedDate { get; set; }
    }
}
