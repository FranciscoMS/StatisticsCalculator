using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StatisticsCalculator.Data.Models
{
    public class Document
    {
        [Key]
        [Column(Order = 1)]
        public Guid DocumentID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Content { get; set; }
        public virtual User User{ get; set; }
    }
}
