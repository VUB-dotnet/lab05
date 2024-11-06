namespace RepairShop.Services;

public interface ITicketsService
{
    Task<List<Ticket>> GetTicketsAsync();
    Task<List<Ticket>> GetCompletedTicketsAsync();
    Task<List<Ticket>> GetActiveTicketsAsync();
    Task<Ticket> GetTicketByIdAsync(int? id);
    Task<TicketCounter> GetTicketCounterAsync();
}