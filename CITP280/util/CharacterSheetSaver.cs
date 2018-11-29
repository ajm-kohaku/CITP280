using CITP280.data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CITP280.util
{
    class CharacterSheetSaver
    {
        private Object saveLock = new Object();
        private string characterSheetFullPath;
        private CharacterSheetData characterSheet;

        public CharacterSheetSaver(string characterSheetFullPath, CharacterSheetData characterSheet)
        {
            this.characterSheetFullPath = characterSheetFullPath;
            this.characterSheet = characterSheet;
        }

        public void SaveCharacterSheet()
        {
            lock(saveLock)
            {
                // serialize JSON to a string and then write string to a file
                File.WriteAllText(characterSheetFullPath, JsonConvert.SerializeObject(characterSheet, Formatting.Indented));
            }
        }

        public string LoadCharacterSheet(String filePath)
        {
            lock(saveLock)
            {
              return  File.ReadAllText(filePath);
            }
        }
    
    }
}
