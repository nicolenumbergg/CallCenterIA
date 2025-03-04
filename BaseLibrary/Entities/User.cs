using System.ComponentModel.DataAnnotations;

namespace BaseLibrary.Entities;

public class User
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string? Username { get; set; }
    
    [DataType(DataType.Password)]
    [Required]
    public string? Password { get; set; }
}