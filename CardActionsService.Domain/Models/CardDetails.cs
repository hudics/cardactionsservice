using CardActionsService.Domain.Enums;

namespace CardActionsService.Domain.Models
{
    public record CardDetails(string CardNumber, CardType CardType, CardStatus CardStatus, bool IsPinSet);
}
