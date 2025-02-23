using CardActionsService.Domain.Models;

namespace CardActionsService.Domain.Interfaces
{
    public interface IActionRepository
    {
        Task<IEnumerable<string>> GetAllowedActions(CardDetails card);
    }
}
