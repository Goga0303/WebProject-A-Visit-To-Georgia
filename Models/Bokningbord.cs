using System;
using System.ComponentModel.DataAnnotations;

namespace A_Visit_To_Georgia.Models
{
    public class Bokningbord
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Namn { get; set; } = string.Empty;

        [Required, DataType(DataType.Date)]
        public DateTime Datum { get; set; } = DateTime.Today;

        [Required, DataType(DataType.Time)]
        public TimeSpan Tid { get; set; } = new TimeSpan(18, 0, 0);

        [Range(1, 20)]
        public int AntalPersoner { get; set; } = 2;

        [StringLength(500)]
        public string? Kommentar { get; set; }
    }
}