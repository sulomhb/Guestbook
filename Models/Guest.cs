using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

namespace assignment_3.Models;

public class Guest
{
    public Guest() {}

    public Guest(int id, string name, string title, string message)
    {
        Id = id;
        Name = name;
        Title = title;
        Message = message;
    }
    
    [Key]
    [Required]
    [DisplayName("Id")]
    public int? Id { get; set; }
    
    [Required]
    [DisplayName("Name")]
    public string? Name { get; set; } = string.Empty;

    [Required]
    [MinLength(5)]
    [MaxLength(50)]
    [DisplayName("Title")]
    public string? Title { get; set; } = string.Empty;

    [Required]
    [MinLength(20)]
    [MaxLength(200)]
    [DisplayName("Message")]
    public string? Message { get; set; } = string.Empty;
    
}