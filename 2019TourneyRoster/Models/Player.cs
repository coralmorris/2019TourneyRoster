using System;
using System.ComponentModel.DataAnnotations;

namespace _2019TourneyRoster.Models
{
    public class Player
    {

        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [MaxLength(3)]
        [Display(Name="Shirt Size")]
        public string ShirtSize { get; set; }
        public int TeamID { get; set; }
    }
}
