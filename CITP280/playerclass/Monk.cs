using CITP280.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITP280.playerclass
{
    class Monk : BaseClass
    {
        public override string className => "Monk";
        public override int skillRanksPerLevel => 4;

        public override int dieType => 8;

        public override SavesScale fortitudeScale => SavesScale.GOOD;

        public override SavesScale reflexScale => SavesScale.GOOD;

        public override SavesScale willScale => SavesScale.GOOD;

        public override BaseAttackScale baseAttack => BaseAttackScale.THREE_QUARTER;

        public override List<string> GetClassAbilitiesTableList()
        {
            throw new NotImplementedException();
        }

        public override List<string> getClassSkills()
        {
            List<string> skills = new List<string>();
            skills.Add("Acrobatics");
            skills.Add("Climb");
            skills.Add("Craft");
            skills.Add("Escape Artist");
            skills.Add("Intimidate");
            skills.Add("Knowledge (History)");
            skills.Add("Knowledge (Religion)");
            skills.Add("Perception");
            skills.Add("Perform");
            skills.Add("Profession");
            skills.Add("Ride");
            skills.Add("Sense Motive");
            skills.Add("Stealth");
            skills.Add("Swim");
            return skills;
        }
    }
}
