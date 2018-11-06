using CITP280.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITP280.playerclass
{
    /// <summary>
    ///     interface for all playable classes.
    ///     
    /// </summary>
    public interface IPlayableClass
    {
        String ClassName { get; }
        ClassTypes ClassType { get; }
        BaseAttackScale BaseAttack { get; }
        SavesScale FortitudeScale { get; }
        SavesScale ReflexScale { get; }
        SavesScale WillScale { get; }
        int SkillRanksPerLevel { get; }
        int DieType { get; }
        int MaxLevel { get; }
    }
}
