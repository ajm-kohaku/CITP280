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
        public override string ClassName => "Bard";

        public override BaseAttackScale BaseAttack => BaseAttackScale.THREE_QUARTER;

        public override SavesScale FortitudeScale => SavesScale.POOR;

        public override SavesScale ReflexScale => SavesScale.GOOD;

        public override SavesScale WillScale => SavesScale.GOOD;

        public override int SkillRanksPerLevel => 6;

        public override int DieType => 8;

    }
}
