
using CardActionsService.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CardActionsService.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CardController : ControllerBase
    {        

        private readonly ILogger<CardController> _logger;
        private readonly ICardService _cardService;

        public CardController(ILogger<CardController> logger, ICardService cardService)
        {
            _logger = logger;
            _cardService = cardService;
        }

        [HttpGet("{userId}/{cardNumber}")]
        public async Task<IActionResult> GetAllowedActions(string userId, string cardNumber)
        {
            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(cardNumber))
                return BadRequest(new { Message = "Invalid input" });
            
            try
            {
                var cardDetails = await _cardService.GetCardDetails(userId, cardNumber);
                if (cardDetails is null)
                    return NotFound(new { Message = "Card not found" });

                var allowedActions = await _cardService.GetAllowedActions(cardDetails);
                return Ok(new { cardDetails.CardNumber, AllowedActions = allowedActions });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while getting allowed actions");
                return StatusCode((int)HttpStatusCode.InternalServerError, new { Message = "An error occurred while getting allowed actions" });

            }
        }
    }
}
