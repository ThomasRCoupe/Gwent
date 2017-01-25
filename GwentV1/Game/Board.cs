using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GwentV1.Cards;

namespace GwentV1.Game
{
    class Board
    {
        private List<UnitCard> closeCombatRow;
        private List<UnitCard> rangedCombatRow;
        private List<UnitCard> siegeCombatRow;

        public void AddToCloseCombatRow(UnitCard card)
        {
            if(card.PlayableCombatRows.Contains(Cards.CombatRowType.CLOSE_COMBAT))
            {

            }
        }

        public void AddToRangedCombatRow(UnitCard card)
        {
            if (card.PlayableCombatRows.Contains(Cards.CombatRowType.RANGED_COMBAT))
            {

            }
        }

        public void AddToSiegeCombatRow(UnitCard card)
        {
            if (card.PlayableCombatRows.Contains(Cards.CombatRowType.SIEGE_COMBAT))
            {

            }
        }
    }
}
