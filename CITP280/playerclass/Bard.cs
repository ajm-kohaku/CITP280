using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CITP280.util;

namespace CITP280.playerclass
{
    public class Bard : BaseClass
    {
        public override string className => "Bard";

        public override BaseAttackScale baseAttack => BaseAttackScale.THREE_QUARTER;

        public override SavesScale fortitudeScale => SavesScale.POOR;

        public override SavesScale reflexScale => SavesScale.GOOD;

        public override SavesScale willScale => SavesScale.GOOD;

        public override int skillRanksPerLevel => 6;

        public override int dieType => 8;

        public override List<string> GetClassAbilitiesTableList()
        {
            throw new NotImplementedException();
        }

        public override List<string> getClassSkills()
        {
            List<string> skills = new List<string>();
            skills.Add("Acrobatics");
            skills.Add("Appraise");
            skills.Add("Bluff");
            skills.Add("Climb");
            skills.Add("Craft");
            skills.Add("Diplomacy");
            skills.Add("Disguise");
            skills.Add("Escape Artist");
            skills.Add("Intimidate");
            skills.Add("Knowledge (Arcana)");
            skills.Add("Knowledge (Dungeoneering)");
            skills.Add("Knowledge (Engineering)");
            skills.Add("Knowledge (Geography)");
            skills.Add("Knowledge (History)");
            skills.Add("Knowledge (Local)");
            skills.Add("Knowledge (Nature)");
            skills.Add("Knowledge (Nobility)");
            skills.Add("Knowledge (Planes)");
            skills.Add("Knowledge (Religion)");
            skills.Add("Linguistics");
            skills.Add("Perception");
            skills.Add("Profession");
            skills.Add("Ride");
            skills.Add("Sense Motive");
            skills.Add("Sleight of Hand");
            skills.Add("Spellcraft");
            skills.Add("Stealth");
            skills.Add("Use Magical Device");

            skills.Add("Handle Animal");
            skills.Add("Survival");
            skills.Add("Swim");
            return skills;
        }
    }
}
