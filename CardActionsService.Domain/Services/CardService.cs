using CardActionsService.Domain.Interfaces;
using CardActionsService.Domain.Interfaces.Services;
using CardActionsService.Domain.Models;

namespace CardActionsService.Domain.Services
{
    public class CardService : ICardService
    {        

        private readonly Dictionary<string, Dictionary<string, CardDetails>> _userCards = CreateSampleUserCards();
        private readonly IActionRepository _actionRepository;

        public CardService(IActionRepository actionRepository)
        {
            _actionRepository = actionRepository;
        }
       
        public async Task<CardDetails?> GetCardDetails(string userId, string cardNumber)
        {
            // Double check, as the controller should have already validated the input.
            if (userId is null || cardNumber is null)
            {
                return null;
            }

            // Optional: Validate the userId and cardNumber format. Trim, check length, etc.

            // At this point, we would typically make an HTTP call to an external service
            // to fetch the data. For this example we use generated sample data.
            await Task.Delay(1000);
            if (!_userCards.TryGetValue(userId, out var cards)
            || !cards.TryGetValue(cardNumber, out var cardDetails))
            {
                return null;
            }
            return cardDetails;
        }

        public async Task<IEnumerable<string>> GetAllowedActions(CardDetails card)
        {
            // We check if card is null because methods can be used in different places,
            // so they must be error-resistant and provide proper validation.
            if (card == null)
            {
                throw new ArgumentNullException(nameof(card), "Card details cannot be null");
            }

            try
            {
                return await _actionRepository.GetAllowedActions(card);
            }
            catch (Exception ex)
            {   
                throw new Exception("An error occurred while accessing allowed actions from the database.", ex);
            }            
        }

        private static Dictionary<string, Dictionary<string, CardDetails>> CreateSampleUserCards()
        {
            var userCards = new Dictionary<string, Dictionary<string, CardDetails>>();
            for (var i = 1; i <= 3; i++)
            {
                var cards = new Dictionary<string, CardDetails>();
                var cardIndex = 1;
                foreach (CardType cardType in Enum.GetValues(typeof(CardType)))
                {
                    foreach (CardStatus cardStatus in Enum.GetValues(typeof(CardStatus)))
                    {
                        var cardNumber = $"Card{i}{cardIndex}";
                        cards.Add(cardNumber,
                        new CardDetails(
                        CardNumber: cardNumber,
                        CardType: cardType,
                        CardStatus: cardStatus,
                        IsPinSet: cardIndex % 2 == 0));
                        cardIndex++;
                    }
                }
                var userId = $"User{i}";
                userCards.Add(userId, cards);
            }
            return userCards;
        }
    }
}
