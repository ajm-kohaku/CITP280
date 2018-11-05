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
        public override string ClassName => "Sorcerer";

        public override BaseAttackScale BaseAttack => BaseAttackScale.HALF;

        public override SavesScale FortitudeScale => SavesScale.POOR;

        public override SavesScale ReflexScale => SavesScale.POOR;

        public override SavesScale WillScale => SavesScale.GOOD;

        public override int SkillRanksPerLevel => 2;

        public override int DieType => 6;

        public override List<string> GetClassAbilitiesTableList()
        {
            throw new NotImplementedException();
        }

        public override List<string> GetClassSkills()
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
