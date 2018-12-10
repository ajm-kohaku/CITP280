using CITP280.util;

namespace CITP280.playerclass
{
    class Monk : CoreClass
    {
        public override string ClassName => "Monk";
        public override int SkillRanksPerLevel => 4;

        public override int DieType => 8;

        public override SavesScale FortitudeScale => SavesScale.GOOD;

        public override SavesScale ReflexScale => SavesScale.GOOD;

        public override SavesScale WillScale => SavesScale.GOOD;

        public override BaseAttackScale BaseAttack => BaseAttackScale.THREE_QUARTER;


    }
}
