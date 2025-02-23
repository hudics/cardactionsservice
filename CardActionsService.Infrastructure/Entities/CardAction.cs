using CardActionsService.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardActionsService.Infrastructure.Entities
{
    public class CardAction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public CardType CardType { get; set; }

        [Required]
        public CardStatus CardStatus { get; set; }

        [Required]
        public int ActionId { get; set; }

        [ForeignKey(nameof(ActionId))]
        public AllowedAction Action { get; set; } = null!;

        [Required]
        public bool RequiresPin { get; set; } = false;
    }
}
