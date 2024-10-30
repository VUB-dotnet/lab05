namespace RepairShop.Models;

public class Ticket {
    public int Id { get; set; }
    public string? Subject { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public bool Completed { get; set; }
}
