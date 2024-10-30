namespace RepairShop.Models;

public record TicketCounter
{
    public required int ActiveCount { get; init; }
    public required int CompletedCount { get; init; }
    public int TotalCount { get=> ActiveCount + CompletedCount; }
};