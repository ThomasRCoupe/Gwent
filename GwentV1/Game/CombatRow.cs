using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GwentV1.Game
{
    class CombatRow
    {
        private List<Cards.UnitCard> row;
        private Cards.CombatRowType combatRow;
        private int rowTotal = 0;

        public CombatRow(Cards.CombatRowType combatRow)
        {
            this.combatRow = combatRow;
        }

        public void AddToRow(Cards.UnitCard card)
        {
            if(card.PlayableCombatRows.Contains(this.combatRow))
            {
                row.Add(card);
            }
        }
    }
}
