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
        String className { get; }
        ClassTypes classType { get; }
        BaseAttackScale baseAttack { get; }
        SavesScale fortitudeScale { get; }
        SavesScale reflexScale { get; }
        SavesScale willScale { get; }
        int skillRanksPerLevel { get; }
        int dieType { get; }
        int maxLevel { get; }

        List<string> getClassSkills();
        DataTable ClassDatatableView();
    }
}
