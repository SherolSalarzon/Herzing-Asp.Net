// Sherol Salarzon

using Assignment3Project.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace Assignment3Project.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
