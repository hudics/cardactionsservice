using CardActionsService.Domain.Models;

namespace CardActionsService.Domain.Interfaces.Services
{
    public interface ICardService
    {
        Task<IEnumerable<string>> GetAllowedActions(CardDetails card);
        Task<CardDetails?> GetCardDetails(string userId, string cardNumber);
    }
}