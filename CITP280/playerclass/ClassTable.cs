using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITP280.playerclass
{
    /// <summary>
    ///     container for displaying class statistics by level. this will be dynamic in phase 2 
    /// </summary>
    class ClassTable
    {
        public int level { get; set; }
        public string baseAttackBonus { get; set; }
        public string fortitudeSaveBonus { get; set; }
        public string reflexSaveBonus { get; set; }
        public string willSaveBonus { get; set; }
    }
}
