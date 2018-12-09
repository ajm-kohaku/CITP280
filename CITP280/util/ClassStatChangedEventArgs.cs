using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITP280.util
{
    class ClassStatChangedEventArgs : EventArgs
    {
        public Int32 ConstitutionMod { get; set; }
        public Int32 IntelligenceMod { get; set; }
    }
}
