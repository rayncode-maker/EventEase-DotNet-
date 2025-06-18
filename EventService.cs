public class EventService
{
    private List<Event> _events = new()
    {
        new Event { Id = 1, Title = "Tech Conference", Description = "Learn about .NET & Blazor", Date = DateTime.Now.AddDays(7) },
        new Event { Id = 2, Title = "Music Festival", Description = "Annual summer fest", Date = DateTime.Now.AddDays(14) }
    };

    public async Task<List<Event>> GetEventsAsync() => await Task.FromResult(_events);
    
    public async Task AddEventAsync(Event newEvent)
    {
        newEvent.Id = _events.Max(e => e.Id) + 1;
        _events.Add(newEvent);
        await Task.CompletedTask;
    }
}
