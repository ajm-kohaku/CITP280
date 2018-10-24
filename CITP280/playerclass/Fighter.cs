using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CITP280.util;

namespace CITP280.playerclass
{
    class Fighter : BaseClass
    {
        public override string className => "Fighter";

        public override BaseAttackScale baseAttack => BaseAttackScale.FULL;

        public override SavesScale fortitudeScale => SavesScale.GOOD;

        public override SavesScale reflexScale => SavesScale.POOR;

        public override SavesScale willScale => SavesScale.POOR;

        public override int skillRanksPerLevel => 2;

        public override int dieType => 10;

        public override List<string> GetClassAbilitiesTableList()
        {
            throw new NotImplementedException();
        }

        public override List<string> getClassSkills()
        {
            List<string> skills = new List<string>();
            skills.Add("Climb");
            skills.Add("Craft");
            skills.Add("Handle Animal");
            skills.Add("Intimidate");
            skills.Add("Knowledge (Dungeoneering)");
            skills.Add("Knowledge (Engineering)");
            skills.Add("Profession");
            skills.Add("Ride");
            skills.Add("Survival");
            skills.Add("Swim");
            return skills;
        }
    }
}
