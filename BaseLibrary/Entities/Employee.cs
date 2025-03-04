using System.ComponentModel.DataAnnotations;

namespace BaseLibrary.Entities;

public class Employee
{
    [Key]
    public int Id { get; set; }
    
}