using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class Ticket
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public int creatorID { get; set; }
}