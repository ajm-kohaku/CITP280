﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CITP280.util;

namespace CITP280.playerclass
{
    class Fighter : BaseClass
    {
        public override string ClassName => "Fighter";

        public override BaseAttackScale BaseAttack => BaseAttackScale.FULL;

        public override SavesScale FortitudeScale => SavesScale.GOOD;

        public override SavesScale ReflexScale => SavesScale.POOR;

        public override SavesScale WillScale => SavesScale.POOR;

        public override int SkillRanksPerLevel => 2;

        public override int DieType => 10;

    
    }
}
