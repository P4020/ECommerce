using System.ComponentModel.DataAnnotations;
namespace Ecommerce.Models;
public class Carrello
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public string? Descrizione { get; set; }
    public string? Immagine { get; set; }
    [DataType(DataType.Date)]
    public DateTime DataRilascio { get; set; }
    public string? genere { get; set; }
    public decimal Prezzo { get; set; }
}