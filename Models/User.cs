using System.ComponentModel.DataAnnotations;
namespace Ecommerce.Models;
public class User
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Cognome { get; set; }
    [DataType(DataType.Date)]
    public DateTime DataNascita { get; set; }
    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
}