namespace RepairShop.Services;

public class TicketsService : ITicketsService {
    private readonly AppDbContext _context;

    public TicketsService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Ticket>> GetTicketsAsync()
    {
        return await _context.Ticket.ToListAsync();
    }

    public async Task<List<Ticket>> GetCompletedTicketsAsync()
    {
        return await _context.Ticket.Where(t => t.Completed).ToListAsync();
    }

    public async Task<List<Ticket>> GetActiveTicketsAsync()
    {
        return await _context.Ticket.Where(t => t.Completed == false).ToListAsync();
    }

    public async Task<Ticket> GetTicketByIdAsync(int? id)
    {
        return await _context.Ticket.FirstOrDefaultAsync(m => m.Id == id);
    }

    public async Task<TicketCounter> GetTicketCounterAsync()
    {
        return new TicketCounter
        {
            ActiveCount = _context.Ticket.Count(t => t.Completed == false),
            CompletedCount = _context.Ticket.Count(t => t.Completed)
        };
    }
}