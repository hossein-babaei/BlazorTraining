using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BlazorTraining.Domain.Models
{
    [Index(nameof(RowId), IsUnique = true)]
    public class Server
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(32)]
        public string Name { get; set; }

        [Required]
        [StringLength(32)]
        public string Region { get; set; }

        [Required]
        public bool ActiveStatus { get; set; } = false;

        [Required]
        [StringLength(36)]
        public string RowId { get; set; } = Guid.NewGuid().ToString();
    }
}
