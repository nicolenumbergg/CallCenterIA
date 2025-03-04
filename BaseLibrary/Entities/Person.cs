using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BaseLibrary.Entities;

public class Person
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MinLength(5)]
    [MaxLength(50)]
    public string? Fullname { get; set; }
    
    [Required]
    [MinLength(8)]
    [MaxLength(8)]
    public string? CI { get; set; }
    
    [Required]
    [MinLength(5)]
    [MaxLength(80)]
    public string? Address { get; set; }
    
    [Required]
    [MinLength(5)]
    [MaxLength(20)]
    public string? City { get; set; }
    
    [Required]
    [DataType(DataType.EmailAddress)]
    public string? Email { get; set; }
    
    [Required]
    [DataType(DataType.PhoneNumber)]
    public string? Phone { get; set; }
    
    [JsonIgnore]
    public List<Employee> Employees { get; set; }
}