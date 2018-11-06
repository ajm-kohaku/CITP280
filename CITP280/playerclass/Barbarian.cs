using CITP280.util;

namespace CITP280.playerclass
{
    public class Barbarian : BaseClass
    {
        public override string ClassName => "Barbarian";

        public override BaseAttackScale BaseAttack => BaseAttackScale.FULL;

        public override SavesScale FortitudeScale => SavesScale.GOOD;

        public override SavesScale ReflexScale => SavesScale.POOR;

        public override SavesScale WillScale => SavesScale.POOR;

        public override int SkillRanksPerLevel => 4;

        public override int DieType => 12;
    }
}
