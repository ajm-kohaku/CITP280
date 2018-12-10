using CITP280.util;

namespace CITP280.playerclass
{
    public class Sorcerer : CoreClass
    {
        public override string ClassName => "Sorcerer";

        public override BaseAttackScale BaseAttack => BaseAttackScale.HALF;

        public override SavesScale FortitudeScale => SavesScale.POOR;

        public override SavesScale ReflexScale => SavesScale.POOR;

        public override SavesScale WillScale => SavesScale.GOOD;

        public override int SkillRanksPerLevel => 2;

        public override int DieType => 6;
        
    }
}
