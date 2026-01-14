using System.ComponentModel.DataAnnotations;

namespace A_Visit_To_Georgia.Models;

public class MenuItem
{
    public int Id { get; set; }

    [Required]
    public string Namn { get; set; }

    public string Beskrivning { get; set; }
    
    [Required]
    public decimal Pris { get; set; }
    
    public string Kategori { get; set; }
}

