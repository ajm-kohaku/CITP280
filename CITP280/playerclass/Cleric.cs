using CITP280.util;

namespace CITP280.playerclass
{
    public class Cleric : CoreClass
    {
        public override string ClassName => "Cleric";

        public override int SkillRanksPerLevel => 2;

        public override int DieType => 8;

        public override SavesScale FortitudeScale => SavesScale.GOOD;

        public override SavesScale ReflexScale => SavesScale.POOR;

        public override SavesScale WillScale => SavesScale.GOOD;

        public override BaseAttackScale BaseAttack => BaseAttackScale.THREE_QUARTER;

     
    }
}
