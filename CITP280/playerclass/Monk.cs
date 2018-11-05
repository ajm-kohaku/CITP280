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
        public override string ClassName => "Monk";
        public override int SkillRanksPerLevel => 4;

        public override int DieType => 8;

        public override SavesScale FortitudeScale => SavesScale.GOOD;

        public override SavesScale ReflexScale => SavesScale.GOOD;

        public override SavesScale WillScale => SavesScale.GOOD;

        public override BaseAttackScale BaseAttack => BaseAttackScale.THREE_QUARTER;

        public override List<string> GetClassAbilitiesTableList()
        {
            throw new NotImplementedException();
        }

        public override List<string> GetClassSkills()
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
