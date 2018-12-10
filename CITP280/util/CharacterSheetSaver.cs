using CITP280.data;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Windows.Forms;

namespace CITP280.util
{
    class CharacterSheetSaver
    {
        private Object saveLock = new Object();
        private string characterSheetFullPath;
        private CharacterSheetData characterSheet;
        private SaveFileDialog saveFileDialog;

        public CharacterSheetSaver(string characterSheetFullPath, CharacterSheetData characterSheet)
        {
            this.characterSheetFullPath = characterSheetFullPath;
            this.characterSheet = characterSheet;
        }

        public CharacterSheetSaver(SaveFileDialog saveFileDialog, CharacterSheetData characterSheet)
        {
            this.saveFileDialog = saveFileDialog;
            this.characterSheet = characterSheet;
        }

        public void SaveCharacterSheet()
        {
            lock (saveLock)
            {
                // serialize JSON to a string and then write string to a file
                File.WriteAllText(characterSheetFullPath, JsonConvert.SerializeObject(characterSheet, Formatting.Indented));
            }
        }

        public void SaveJson()
        {
            lock (saveLock)
            {
                saveFileDialog.Filter = "Json files (*.json)|*.json";
                saveFileDialog.FilterIndex = 2;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (Stream stream = File.Open(saveFileDialog.FileName, FileMode.Create))
                    using (StreamWriter sw = new StreamWriter(stream))
                    {
                        sw.Write(JsonConvert.SerializeObject(characterSheet, Formatting.Indented));
                    }
                }
            }

        }

        public string LoadCharacterSheet(String filePath)
        {
            lock (saveLock)
            {
                return File.ReadAllText(filePath);
            }
        }

    }
}
