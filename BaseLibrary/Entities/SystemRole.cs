using System.ComponentModel.DataAnnotations;

namespace BaseLibrary.Entities;

public class SystemRole
{
    
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    
}