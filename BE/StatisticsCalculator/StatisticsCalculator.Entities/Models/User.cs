using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatisticsCalculator.Data.Models
{
    public class User
    {
        [Key]
        [Column(Order = 1)]
        public Guid UserID { get; set; }
        [Required]
        [MaxLength(15)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(8)]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
