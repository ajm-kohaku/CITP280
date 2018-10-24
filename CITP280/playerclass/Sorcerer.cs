using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CITP280.util;

namespace CITP280.playerclass
{
    public class Sorcerer : BaseClass
    {
        public override string className => "Sorcerer";

        public override BaseAttackScale baseAttack => BaseAttackScale.HALF;

        public override SavesScale fortitudeScale => SavesScale.POOR;

        public override SavesScale reflexScale => SavesScale.POOR;

        public override SavesScale willScale => SavesScale.GOOD;

        public override int skillRanksPerLevel => 2;

        public override int dieType => 6;

        public override List<string> GetClassAbilitiesTableList()
        {
            throw new NotImplementedException();
        }

        public override List<string> getClassSkills()
        {
            List<string> skills = new List<string>();
            skills.Add("Appraise");
            skills.Add("Bluff");
            skills.Add("Craft");
            skills.Add("Fly");
            skills.Add("Intimidate");
            skills.Add("Knowledge (Arcana)");
            skills.Add("Profession");
            skills.Add("Spellcraft");
            skills.Add("Use Magical Device");
            return skills;
        }
    }
}
