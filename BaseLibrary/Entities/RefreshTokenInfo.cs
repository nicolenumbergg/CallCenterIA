using System.ComponentModel.DataAnnotations;

namespace BaseLibrary.Entities;

public class RefreshTokenInfo
{
    [Key]
    public int Id { get; set; }
    public string? Token { get; set; }
    public int UserId { get; set; }
}