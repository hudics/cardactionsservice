using System.ComponentModel.DataAnnotations;

namespace CardActionsService.Infrastructure.Entities
{
    public class AllowedAction
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string ActionName { get; set; } = string.Empty;
    }
}
