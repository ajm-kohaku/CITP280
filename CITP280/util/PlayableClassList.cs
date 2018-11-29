using CITP280.playerclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CITP280.util
{
    
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"> accepts generic class of type BaseClass</typeparam>
    public class PlayableClassList<T> where T: BaseClass
    {
        public string ClassName(T playableClass)
        {
            return playableClass.ClassName;
        }

        /// <summary>
        /// Adds player class to the combobox
        /// </summary>
        /// <param name="comboBox">dropdown list the displays the class list</param>
        /// <param name="playerClass">values that feed the list</param>
        public void Add(ComboBox comboBox, T playerClass)
        {
            comboBox.Items.Add(playerClass.ClassName);
        }
       
    }
}
