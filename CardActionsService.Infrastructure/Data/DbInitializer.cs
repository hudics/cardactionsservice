using CardActionsService.Data;
using CardActionsService.Domain.Models;
using CardActionsService.Infrastructure.Entities;

namespace CardActionsService.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context) 
        {
            if (!context.Actions.Any())
            {
                var actions = new List<AllowedAction>
                {
                    new AllowedAction { ActionName = "ACTION1" },
                    new AllowedAction { ActionName = "ACTION2" },
                    new AllowedAction { ActionName = "ACTION3" },
                    new AllowedAction { ActionName = "ACTION4" },
                    new AllowedAction { ActionName = "ACTION5" },
                    new AllowedAction { ActionName = "ACTION6" },
                    new AllowedAction { ActionName = "ACTION7" },
                    new AllowedAction { ActionName = "ACTION8" },
                    new AllowedAction { ActionName = "ACTION9" },
                    new AllowedAction { ActionName = "ACTION10" },
                    new AllowedAction { ActionName = "ACTION11" },
                    new AllowedAction { ActionName = "ACTION12" },
                    new AllowedAction { ActionName = "ACTION13" },
                };

                context.Actions.AddRange(actions);
                context.SaveChanges();
            }

            if (!context.CardActions.Any())
            {
                var actionMap = context.Actions.ToDictionary(a => a.ActionName, a => a.Id);

                var cardActions = new List<CardAction>
                {
                    //ACTION 1

                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION1"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION1"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION1"] },

                    //ACTION 2

                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION2"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION2"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION2"] },
                    
                    //ACTION 3

                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION3"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION3"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION3"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Restricted, ActionId = actionMap["ACTION3"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Blocked, ActionId = actionMap["ACTION3"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Expired, ActionId = actionMap["ACTION3"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Closed, ActionId = actionMap["ACTION3"] },

                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION3"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION3"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION3"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Restricted, ActionId = actionMap["ACTION3"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Blocked, ActionId = actionMap["ACTION3"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Expired, ActionId = actionMap["ACTION3"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Closed, ActionId = actionMap["ACTION3"] },

                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION3"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION3"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION3"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Restricted, ActionId = actionMap["ACTION3"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Blocked, ActionId = actionMap["ACTION3"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Expired, ActionId = actionMap["ACTION3"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Closed, ActionId = actionMap["ACTION3"] },

                    //ACTION 4

                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION4"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION4"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION4"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Restricted, ActionId = actionMap["ACTION4"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Blocked, ActionId = actionMap["ACTION4"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Expired, ActionId = actionMap["ACTION4"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Closed, ActionId = actionMap["ACTION4"] },

                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION4"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION4"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION4"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Restricted, ActionId = actionMap["ACTION4"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Blocked, ActionId = actionMap["ACTION4"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Expired, ActionId = actionMap["ACTION4"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Closed, ActionId = actionMap["ACTION4"] },

                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION4"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION4"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION4"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Restricted, ActionId = actionMap["ACTION4"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Blocked, ActionId = actionMap["ACTION4"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Expired, ActionId = actionMap["ACTION4"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Closed, ActionId = actionMap["ACTION4"] },

                    //ACTION 5

                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION5"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION5"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION5"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Restricted, ActionId = actionMap["ACTION5"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Blocked, ActionId = actionMap["ACTION5"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Expired, ActionId = actionMap["ACTION5"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Closed, ActionId = actionMap["ACTION5"] },

                    //ACTION 6

                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION6"], RequiresPin = true },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION6"], RequiresPin = true },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION6"], RequiresPin = true },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Blocked, ActionId = actionMap["ACTION6"], RequiresPin = true },

                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION6"], RequiresPin = true },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION6"], RequiresPin = true },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION6"], RequiresPin = true },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Blocked, ActionId = actionMap["ACTION6"], RequiresPin = true },

                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION6"], RequiresPin = true },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION6"], RequiresPin = true },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION6"], RequiresPin = true },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Blocked, ActionId = actionMap["ACTION6"], RequiresPin = true },

                    //ACTION 7

                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION7"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION7"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION7"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Blocked, ActionId = actionMap["ACTION7"], RequiresPin = true },

                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION7"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION7"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION7"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Blocked, ActionId = actionMap["ACTION7"], RequiresPin = true },

                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION7"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION7"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION7"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Blocked, ActionId = actionMap["ACTION7"], RequiresPin = true },

                    //ACTION 8

                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION8"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION8"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION8"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Blocked, ActionId = actionMap["ACTION8"] },

                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION8"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION8"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION8"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Blocked, ActionId = actionMap["ACTION8"] },

                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION8"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION8"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION8"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Blocked, ActionId = actionMap["ACTION8"] },

                    //ACTION 9

                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION9"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION9"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION9"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Blocked, ActionId = actionMap["ACTION9"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Expired, ActionId = actionMap["ACTION9"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Closed, ActionId = actionMap["ACTION9"] },

                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION9"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION9"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION9"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Blocked, ActionId = actionMap["ACTION9"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Expired, ActionId = actionMap["ACTION9"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Closed, ActionId = actionMap["ACTION9"] },

                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION9"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION9"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION9"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Blocked, ActionId = actionMap["ACTION9"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Expired, ActionId = actionMap["ACTION9"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Closed, ActionId = actionMap["ACTION9"] },

                    //ACTION 10

                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION10"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION10"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION10"] },

                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION10"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION10"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION10"] },

                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION10"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION10"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION10"] },

                    //ACTION 11

                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION11"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION11"] },

                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION11"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION11"] },

                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION11"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION11"] },

                    //ACTION 12

                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION12"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION12"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION12"] },

                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION12"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION12"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION12"] },

                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION12"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION12"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION12"] },

                    //ACTION 13

                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION13"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION13"] },
                    new CardAction { CardType = CardType.Prepaid, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION13"] },

                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION13"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION13"] },
                    new CardAction { CardType = CardType.Debit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION13"] },

                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Ordered, ActionId = actionMap["ACTION13"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Inactive, ActionId = actionMap["ACTION13"] },
                    new CardAction { CardType = CardType.Credit, CardStatus = CardStatus.Active, ActionId = actionMap["ACTION13"] },
                };

                context.CardActions.AddRange(cardActions);
                context.SaveChanges();
            }
        }
    }
}
