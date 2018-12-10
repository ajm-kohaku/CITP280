using CITP280.data;
using CITP280.playerclass;
using CITP280.util;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

using static CITP280.util.TextBoxValidator;


namespace CITP280
{
    public partial class CharacterSheetForm : Form
    {
        //create list list of playable classes
        private List<CoreClass> playableClasses;

        //gets the directory the program is being executed from
        private string exeDirectory = Path.GetDirectoryName(new Uri(Assembly.GetEntryAssembly().CodeBase).AbsolutePath);
        //provides file name for the character sheet
        private string characterSheetFileName = "character-sheet.txt";
        //holds the fully qualified path to the character sheet file.
        private string characterSheetFullPath;
        public CharacterSheetForm()
        {
            InitializeComponent();

            //the below subscribes to the AbilityScoreChanged event for each ability score
            this.StrengthScoreControl.AbilityScoreChanged += new AbilityScoreCalculationControl.AbilityScoreChangedEventHandler(this.Strength_AbilityScoreChanged);
            this.DexterityScoreControl.AbilityScoreChanged += new AbilityScoreCalculationControl.AbilityScoreChangedEventHandler(this.Dexterity_AbilityScoreChanged);
            this.ConstitutionScoreControl.AbilityScoreChanged += new AbilityScoreCalculationControl.AbilityScoreChangedEventHandler(this.Constitution_AbilityScoreChanged);
            this.IntelligenceScoreControl.AbilityScoreChanged += new AbilityScoreCalculationControl.AbilityScoreChangedEventHandler(this.Intelligence_AbilityScoreChanged);
            this.WisdomScoreControl.AbilityScoreChanged += new AbilityScoreCalculationControl.AbilityScoreChangedEventHandler(this.Wisdom_AbilityScoreChanged);
            this.CharismaScoreControl.AbilityScoreChanged += new AbilityScoreCalculationControl.AbilityScoreChangedEventHandler(this.Charisma_AbilityScoreChanged);

            playableClasses = new List<CoreClass>()
            {
                new Barbarian(),
                new Bard(),
                new Cleric(),
                new Fighter(),
                new Monk(),
                new Paladin(),
                new Sorcerer(),
                new Wizard()
            };

            //index 0 should be blank
            cbClassNames1.Items.Add("");
            cbClassNames2.Items.Add("");

            //create list of playable classes
            foreach (CoreClass baseClass in playableClasses)
            {
                cbClassNames1.Items.Add(baseClass.ClassName);
            }

            //create list of playable classes for the second set
            foreach (CoreClass baseClass in playableClasses)
            {
                cbClassNames2.Items.Add(baseClass.ClassName);
            }
            characterSheetFullPath = Path.Combine(exeDirectory, characterSheetFileName);
        }


        /// <summary>
        /// Listens for the index to change on the class names dropdown in the class recorder section.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClassNames1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClassNames1.SelectedIndex == 0)
            {

                tbClass1Level.Text = null;
                lblClass1Bab.Text = null;
                lblClass1Fort.Text = null;
                lblClass1Ref.Text = null;
                lblClass1Will.Text = null;
                lblClass1Skills.Text = null;
                lblClass1HitDice.Text = null;
                lblClass1HealthFromLevel.Text = null;
                
            } else
            {
                if (String.IsNullOrEmpty(tbClass1Level.Text))
                {
                    tbClass1Level.Text = "1";
                }
                ChangeClass1StatisticsOnLevelChange();
            }
        }

        // when the class level changes, update the class recorder statistics for that class
        private void Class1Level_TextChanged(object sender, EventArgs e)
        {
            ChangeClass1StatisticsOnLevelChange();
        }

        private void cbClassNames2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClassNames2.SelectedIndex == 0)
            {

                tbClass2Level.Text = null;
                lblClass2Bab.Text = null;
                lblClass2Fort.Text = null;
                lblClass2Ref.Text = null;
                lblClass2Will.Text = null;
                lblClass2Skills.Text = null;
                lblClass2HitDice.Text = null;
                lblClass2HealthFromLevel.Text = null;

            }
            else
            {
                if (String.IsNullOrEmpty(tbClass2Level.Text))
                {
                    tbClass2Level.Text = "1";
                }
                ChangeClass2StatisticsOnLevelChange();
            }
        }

        private void tbClass2Level_TextChanged(object sender, EventArgs e)
        {
            ChangeClass2StatisticsOnLevelChange();

        }

        
        public void ChangeClass1StatisticsOnLevelChange()
        {
            IPlayableClass playableClass = playableClasses.Find(pc => pc.ClassName.Contains(cbClassNames1.GetItemText(item: cbClassNames1.SelectedItem)));
            Int32.TryParse(tbClass1Level.Text, out int level);
            Int32.TryParse(IntelligenceScoreControl.CstmTxt_AbilityModText, out int intMod);
            Int32.TryParse(ConstitutionScoreControl.CstmTxt_AbilityModText, out int conMod);

            lblClass1Bab.Text = ScaleCalculations.GetBaseAttack(level, playableClass.BaseAttack).ToString();
            lblClass1Fort.Text = ScaleCalculations.GetSave(level, playableClass.FortitudeScale).ToString();
            lblClass1Ref.Text = ScaleCalculations.GetSave(level, playableClass.ReflexScale).ToString();
            lblClass1Will.Text = ScaleCalculations.GetSave(level, playableClass.WillScale).ToString();
            lblClass1Skills.Text = (playableClass.SkillRanksPerLevel + intMod).ToString();
            lblClass1HitDice.Text = playableClass.DieType.ToString();
            UpdateClass1HealthFromLevel();
        }

        public void ChangeClass2StatisticsOnLevelChange()
        {
            IPlayableClass playableClass = playableClasses.Find(pc => pc.ClassName.Contains(cbClassNames2.GetItemText(item: cbClassNames2.SelectedItem)));
            Int32.TryParse(tbClass2Level.Text, out int level);
            Int32.TryParse(IntelligenceScoreControl.CstmTxt_AbilityModText, out int intMod);
            Int32.TryParse(ConstitutionScoreControl.CstmTxt_AbilityModText, out int conMod);

            lblClass2Bab.Text = ScaleCalculations.GetBaseAttack(level, playableClass.BaseAttack).ToString();
            lblClass2Fort.Text = ScaleCalculations.GetSave(level, playableClass.FortitudeScale).ToString();
            lblClass2Ref.Text = ScaleCalculations.GetSave(level, playableClass.ReflexScale).ToString();
            lblClass2Will.Text = ScaleCalculations.GetSave(level, playableClass.WillScale).ToString();
            lblClass2Skills.Text = (playableClass.SkillRanksPerLevel + intMod).ToString();
            lblClass2HitDice.Text = playableClass.DieType.ToString();
            UpdateClass2HealthFromLevel();
        }

        //calculates the maximum number of hit points possible for selected class and class level
        private void UpdateClass1HealthFromLevel()
        {
            IPlayableClass playableClass = playableClasses.Find(pc => pc.ClassName.Contains(cbClassNames1.GetItemText(item: cbClassNames1.SelectedItem)));
            Int32.TryParse(tbClass1Level.Text, out int level);
            Int32.TryParse(ConstitutionScoreControl.CstmTxt_AbilityModText, out int conMod);
            lblClass1HealthFromLevel.Text = ((level * playableClass.DieType) + (level * conMod)).ToString();
        }

        private void UpdateClass2HealthFromLevel()
        {
            IPlayableClass playableClass = playableClasses.Find(pc => pc.ClassName.Contains(cbClassNames2.GetItemText(item: cbClassNames2.SelectedItem)));
            Int32.TryParse(tbClass2Level.Text, out int level);
            Int32.TryParse(ConstitutionScoreControl.CstmTxt_AbilityModText, out int conMod);
            lblClass2HealthFromLevel.Text = ((level * playableClass.DieType) + (level * conMod)).ToString();
        }

        /// <summary>
        /// The followng Event listeners that update the Ability Modifier text box when the Ability total is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Strength_AbilityScoreChanged(object sender, AbilityScoreChangedEventArgs e)
        {
            StrengthScoreControl.CstmTxt_AbilityModText = e.ModifierString;
        }

        private void Dexterity_AbilityScoreChanged(object sender, AbilityScoreChangedEventArgs e)
        {
            DexterityScoreControl.CstmTxt_AbilityModText = e.ModifierString;
        }

        private void Constitution_AbilityScoreChanged(object sender, AbilityScoreChangedEventArgs e)
        {
            ConstitutionScoreControl.CstmTxt_AbilityModText = e.ModifierString;
            //updates class health. todo://revamp this to make better use of events
            if (tbClass1Level.Text != null)
            {
                UpdateClass1HealthFromLevel();
            }

            if (tbClass2Level.Text != null)
            {
                UpdateClass2HealthFromLevel();
            }
        }

        private void Intelligence_AbilityScoreChanged(object sender, AbilityScoreChangedEventArgs e)
        {
            IntelligenceScoreControl.CstmTxt_AbilityModText = e.ModifierString;
            if (!String.IsNullOrEmpty(tbClass1Level.Text))
            {
                IPlayableClass playableClass = playableClasses.Find(pc => pc.ClassName.Contains(cbClassNames1.GetItemText(item: cbClassNames1.SelectedItem)));
                lblClass1Skills.Text = (playableClass.SkillRanksPerLevel + e.Modifier).ToString();
            }
            if (!String.IsNullOrEmpty(tbClass2Level.Text))
            {
                IPlayableClass playableClass = playableClasses.Find(pc => pc.ClassName.Contains(cbClassNames2.GetItemText(item: cbClassNames2.SelectedItem)));
                lblClass2Skills.Text = (playableClass.SkillRanksPerLevel + e.Modifier).ToString();
            }
        }

        private void Wisdom_AbilityScoreChanged(object sender, AbilityScoreChangedEventArgs e)
        {
            WisdomScoreControl.CstmTxt_AbilityModText = e.ModifierString;
        }

        private void Charisma_AbilityScoreChanged(object sender, AbilityScoreChangedEventArgs e)
        {
            CharismaScoreControl.CstmTxt_AbilityModText = e.ModifierString;
        }

        private void UpdateCurrentHealth(object sender, EventArgs e)
        {
            Int32.TryParse(lblClass1HealthFromLevel.Text, out int class1);
            Int32.TryParse(lblClass2HealthFromLevel.Text, out int class2);
            Int32.TryParse(DamageTakenTextBox.Text, out int damageTaken);
            int totalHealth = class1 + class2;
            int currentHealth = totalHealth - damageTaken;
            tbCurrentHealth.Text = currentHealth + " / " + totalHealth;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                String data = sr.ReadToEnd();
                PopulateFormFromJson(JsonConvert.DeserializeObject<CharacterSheetData>(data));
                sr.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CharacterSheetSaver(saveFileDialog1, convertFormToCharacterSheet()).SaveJson();
        }

        private void tbClass1Level_Validated(object sender, EventArgs e)
        {
            ResetTextBoxFormat(tbClass1Level);
        }

        private void tbClass1Level_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateIntegerTextBox(tbClass1Level);
        }

        private void tbClass2Level_Validated(object sender, EventArgs e)
        {
            ResetTextBoxFormat(tbClass2Level);
        }

        private void tbClass2Level_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateIntegerTextBox(tbClass2Level);
        }

        private void DamageTakenTextBox_Validated(object sender, EventArgs e)
        {
            ResetTextBoxFormat(DamageTakenTextBox);
        }

        private void DamageTakenTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateIntegerTextBox(DamageTakenTextBox);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to clear the form? \n Unsaved data will be lost!","Confirm Clear", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                ClearForm();
            }
        }
    }
}
