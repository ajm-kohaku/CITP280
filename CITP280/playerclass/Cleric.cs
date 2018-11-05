using CITP280.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITP280.playerclass
{
    public class Cleric : BaseClass
    {
        public override string ClassName => "Cleric";

        public override int SkillRanksPerLevel => 2;

        public override int DieType => 8;

        public override SavesScale FortitudeScale => SavesScale.GOOD;

        public override SavesScale ReflexScale => SavesScale.POOR;

        public override SavesScale WillScale => SavesScale.GOOD;

        public override BaseAttackScale BaseAttack => BaseAttackScale.THREE_QUARTER;

        public override List<string> GetClassAbilitiesTableList()
        {
            throw new NotImplementedException();
        }

        public override List<string> GetClassSkills()
        {
            List<string> skills = new List<string>
            {
                "Appraise",
                "Craft",
                "Diplomacy",
                "Heal",
                "Knowledge (Arcana)",
                "Knowledge (History)",
                "Knowledge (Nobility)",
                "Knowledge (Planes)",
                "Knowledge (Religion)",
                "Linguistics",
                "Profession",
                "Sense Motive",
                "Spellcraft"
            };
            return skills;
        }

    }
}
