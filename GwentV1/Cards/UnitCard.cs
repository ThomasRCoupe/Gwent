using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GwentV1.Cards.Abilities;

namespace GwentV1.Cards
{
    public class UnitCard : Card
    {
        private int unitStrength;
        private HashSet<CombatRowType> playableCombatRows;
        private Ability unitAbility;

        public int UnitStrength
        {
            get
            {
                return unitStrength;
            }
        }

        public HashSet<CombatRowType> PlayableCombatRows
        {
            get
            {
                return playableCombatRows;
            }
        }

        public Ability UnitAbility {
            get
            {
                return unitAbility;
            }
        }
    }

    public enum CombatRowType
    {
        CLOSE_COMBAT, RANGED_COMBAT, SIEGE_COMBAT
    }

    

}
