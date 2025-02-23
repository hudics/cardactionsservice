

using CardActionsService.Data;
using CardActionsService.Domain.Interfaces;
using CardActionsService.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

namespace CardActionsService.Infrastructure.Repositories
{
    public class ActionRepository : IActionRepository
    {
        private readonly AppDbContext _context;

        public ActionRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<string>> GetAllowedActions(CardDetails card)
        {
           return await _context.CardActions
            .Where(ca => ca.CardType == card.CardType && ca.CardStatus == card.CardStatus)
            .Where(ca => !ca.RequiresPin || card.IsPinSet)
            .Select(ca => ca.Action.ActionName)
            .ToListAsync();
        }
    }
}
