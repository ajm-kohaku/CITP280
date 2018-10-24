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
        public override string className => "Cleric";

        public override int skillRanksPerLevel => 2;

        public override int dieType => 8;

        public override SavesScale fortitudeScale => SavesScale.GOOD;

        public override SavesScale reflexScale => SavesScale.POOR;

        public override SavesScale willScale => SavesScale.GOOD;

        public override BaseAttackScale baseAttack => BaseAttackScale.THREE_QUARTER;

        public override List<string> GetClassAbilitiesTableList()
        {
            throw new NotImplementedException();
        }

        public override List<string> getClassSkills()
        {
            List<string> skills = new List<string>();
            skills.Add("Appraise");
            skills.Add("Craft");
            skills.Add("Diplomacy");
            skills.Add("Heal");
            skills.Add("Knowledge (Arcana)");
            skills.Add("Knowledge (History)");
            skills.Add("Knowledge (Nobility)");
            skills.Add("Knowledge (Planes)");
            skills.Add("Knowledge (Religion)");
            skills.Add("Linguistics");
            skills.Add("Profession");
            skills.Add("Sense Motive");
            skills.Add("Spellcraft");
            return skills;
        }

    }
}
