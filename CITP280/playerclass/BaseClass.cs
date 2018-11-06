using CITP280.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITP280.playerclass
{
    //base class for most playable classes. child tables will have distinct features in phase 2.
    public abstract class BaseClass : IPlayableClass
    {
        public ClassTypes ClassType => ClassTypes.BASE;
        public abstract string ClassName { get; }
        public abstract BaseAttackScale BaseAttack { get; }
        public abstract SavesScale FortitudeScale { get; }
        public abstract SavesScale ReflexScale { get; }
        public abstract SavesScale WillScale { get; }
        public abstract int SkillRanksPerLevel { get; }
        public abstract int DieType { get; }
        public int MaxLevel => 20;
    }
}
