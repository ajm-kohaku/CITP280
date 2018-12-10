using CITP280.util;

namespace CITP280.playerclass
{
    class Paladin : CoreClass
    {
        public override string ClassName => "Paladin";

        public override BaseAttackScale BaseAttack => BaseAttackScale.FULL;

        public override SavesScale FortitudeScale => SavesScale.GOOD;

        public override SavesScale ReflexScale => SavesScale.POOR;

        public override SavesScale WillScale => SavesScale.GOOD;

        public override int SkillRanksPerLevel => 2;

        public override int DieType => 10;
    }
}
