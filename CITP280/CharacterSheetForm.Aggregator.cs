using CITP280.data;
using CITP280.util;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CITP280
{
    partial class CharacterSheetForm
    {
        private CharacterSheetData convertFormToCharacterSheet()
        {
            //create character sheet data object to generate a file
            CharacterSheetData characterSheet = new CharacterSheetData();
            characterSheet.DamageTaken = DamageTakenTextBox.Text;

            ClassRecordData class1Record = new ClassRecordData()
            {
                PlayerClassName = cbClassNames1.GetItemText(item: cbClassNames1.SelectedItem),
                MaxHealth = lblClass1HealthFromLevel.Text,
                PlayerClassLevel = tbClass1Level.Text,
                FavoredClassSkillCount = tbClass1FavoredClassSkills.Text,
                FavoredClassHealthCount = tbClass1FavoredClassHitPoints.Text,
                FavoredClassOtherCount = tbClass1FavoredClassOther.Text
            };

            ClassRecordData class2Record = new ClassRecordData()
            {
                PlayerClassName = cbClassNames2.GetItemText(item: cbClassNames2.SelectedItem),
                MaxHealth = lblClass2HealthFromLevel.Text,
                PlayerClassLevel = tbClass2Level.Text,
                FavoredClassSkillCount = tbClass2FavoredClassSkills.Text,
                FavoredClassHealthCount = tbClass2FavoredClassHitPoints.Text,
                FavoredClassOtherCount = tbClass2FavoredClassOther.Text
            };

            characterSheet.ClassRecordList = new List<ClassRecordData>()
            {
                class1Record,
                class2Record
            };


            characterSheet.Strength = new AbilityData()
            {
                AbilityName = CoreAttributes.STRENGTH,
                BaseScore = StrengthScoreControl.CstmTxt_BaseAbilityScoreText,
                EnhancementScore = StrengthScoreControl.CstmTxt_EnhancementScoreText,
                InherentScore = StrengthScoreControl.CstmTxt_InherentScoreText,
                TempScore = StrengthScoreControl.CstmTxt_TempScoreText,
                PenaltyScore = StrengthScoreControl.CstmTxt_PenaltyScoreText
            };

            characterSheet.Dexterity = new AbilityData()
            {
                AbilityName = CoreAttributes.DEXTERITY,
                BaseScore = DexterityScoreControl.CstmTxt_BaseAbilityScoreText,
                EnhancementScore = DexterityScoreControl.CstmTxt_EnhancementScoreText,
                InherentScore = DexterityScoreControl.CstmTxt_InherentScoreText,
                TempScore = DexterityScoreControl.CstmTxt_TempScoreText,
                PenaltyScore = DexterityScoreControl.CstmTxt_PenaltyScoreText
            };

            characterSheet.Constitution = new AbilityData()
            {
                AbilityName = CoreAttributes.CONSTITUTION,
                BaseScore = ConstitutionScoreControl.CstmTxt_BaseAbilityScoreText,
                EnhancementScore = ConstitutionScoreControl.CstmTxt_EnhancementScoreText,
                InherentScore = ConstitutionScoreControl.CstmTxt_InherentScoreText,
                TempScore = ConstitutionScoreControl.CstmTxt_TempScoreText,
                PenaltyScore = ConstitutionScoreControl.CstmTxt_PenaltyScoreText
            };

            characterSheet.Intelligence = new AbilityData()
            {
                AbilityName = CoreAttributes.INTELLIGENCE,
                BaseScore = IntelligenceScoreControl.CstmTxt_BaseAbilityScoreText,
                EnhancementScore = IntelligenceScoreControl.CstmTxt_EnhancementScoreText,
                InherentScore = IntelligenceScoreControl.CstmTxt_InherentScoreText,
                TempScore = IntelligenceScoreControl.CstmTxt_TempScoreText,
                PenaltyScore = IntelligenceScoreControl.CstmTxt_PenaltyScoreText
            };

            characterSheet.Wisdom = new AbilityData()
            {
                AbilityName = CoreAttributes.WISDOM,
                BaseScore = WisdomScoreControl.CstmTxt_BaseAbilityScoreText,
                EnhancementScore = WisdomScoreControl.CstmTxt_EnhancementScoreText,
                InherentScore = WisdomScoreControl.CstmTxt_InherentScoreText,
                TempScore = WisdomScoreControl.CstmTxt_TempScoreText,
                PenaltyScore = WisdomScoreControl.CstmTxt_PenaltyScoreText
            };

            characterSheet.Charisma = new AbilityData()
            {
                AbilityName = CoreAttributes.CHARISMA,
                BaseScore = CharismaScoreControl.CstmTxt_BaseAbilityScoreText,
                EnhancementScore = CharismaScoreControl.CstmTxt_EnhancementScoreText,
                InherentScore = CharismaScoreControl.CstmTxt_InherentScoreText,
                TempScore = CharismaScoreControl.CstmTxt_TempScoreText,
                PenaltyScore = CharismaScoreControl.CstmTxt_PenaltyScoreText
            };
            return characterSheet;
        }

        private void PopulateFormFromJson(CharacterSheetData characterSheet)
        {
            DamageTakenTextBox.Text = characterSheet.DamageTaken;

            ClassRecordData class1Record = characterSheet.ClassRecordList[0];
            cbClassNames1.SelectedIndex = cbClassNames1.FindStringExact(class1Record.PlayerClassName);
            lblClass1HealthFromLevel.Text = class1Record.MaxHealth;
            tbClass1Level.Text = class1Record.PlayerClassLevel;
            tbClass1FavoredClassSkills.Text = class1Record.FavoredClassSkillCount;
            tbClass1FavoredClassHitPoints.Text = class1Record.FavoredClassHealthCount;
            tbClass1FavoredClassOther.Text = class1Record.FavoredClassOtherCount;

            ClassRecordData class2Record = characterSheet.ClassRecordList[1];
            cbClassNames2.SelectedIndex = cbClassNames2.FindStringExact(class2Record.PlayerClassName);
            lblClass1HealthFromLevel.Text = class2Record.MaxHealth;
            tbClass2Level.Text = class2Record.PlayerClassLevel;
            tbClass2FavoredClassSkills.Text = class2Record.FavoredClassSkillCount;
            tbClass2FavoredClassHitPoints.Text = class2Record.FavoredClassHealthCount;
            tbClass2FavoredClassOther.Text = class2Record.FavoredClassOtherCount;

            AbilityData strength = characterSheet.Strength;
            StrengthScoreControl.CstmTxt_BaseAbilityScoreText = strength.BaseScore;
            StrengthScoreControl.CstmTxt_EnhancementScoreText = strength.EnhancementScore;
            StrengthScoreControl.CstmTxt_InherentScoreText = strength.InherentScore;
            StrengthScoreControl.CstmTxt_TempScoreText = strength.TempScore;
            StrengthScoreControl.CstmTxt_PenaltyScoreText = strength.PenaltyScore;

            AbilityData dexterity = characterSheet.Dexterity;
            DexterityScoreControl.CstmTxt_BaseAbilityScoreText = dexterity.BaseScore;
            DexterityScoreControl.CstmTxt_EnhancementScoreText = dexterity.EnhancementScore;
            DexterityScoreControl.CstmTxt_InherentScoreText = dexterity.InherentScore;
            DexterityScoreControl.CstmTxt_TempScoreText = dexterity.TempScore;
            DexterityScoreControl.CstmTxt_PenaltyScoreText = dexterity.PenaltyScore;

            AbilityData constitution = characterSheet.Constitution;
            ConstitutionScoreControl.CstmTxt_BaseAbilityScoreText = constitution.BaseScore;
            ConstitutionScoreControl.CstmTxt_EnhancementScoreText = constitution.EnhancementScore;
            ConstitutionScoreControl.CstmTxt_InherentScoreText = constitution.InherentScore;
            ConstitutionScoreControl.CstmTxt_TempScoreText = constitution.TempScore;
            ConstitutionScoreControl.CstmTxt_PenaltyScoreText = constitution.PenaltyScore;

            AbilityData intelligence = characterSheet.Intelligence;
            IntelligenceScoreControl.CstmTxt_BaseAbilityScoreText = intelligence.BaseScore;
            IntelligenceScoreControl.CstmTxt_EnhancementScoreText = intelligence.EnhancementScore;
            IntelligenceScoreControl.CstmTxt_InherentScoreText = intelligence.InherentScore;
            IntelligenceScoreControl.CstmTxt_TempScoreText = intelligence.TempScore;
            IntelligenceScoreControl.CstmTxt_PenaltyScoreText = intelligence.PenaltyScore;

            AbilityData wisdom = characterSheet.Wisdom;
            WisdomScoreControl.CstmTxt_BaseAbilityScoreText = wisdom.BaseScore;
            WisdomScoreControl.CstmTxt_EnhancementScoreText = wisdom.EnhancementScore;
            WisdomScoreControl.CstmTxt_InherentScoreText = wisdom.InherentScore;
            WisdomScoreControl.CstmTxt_TempScoreText = wisdom.TempScore;
            WisdomScoreControl.CstmTxt_PenaltyScoreText = wisdom.PenaltyScore;

            AbilityData charisma = characterSheet.Charisma;
            CharismaScoreControl.CstmTxt_BaseAbilityScoreText = charisma.BaseScore;
            CharismaScoreControl.CstmTxt_EnhancementScoreText = charisma.EnhancementScore;
            CharismaScoreControl.CstmTxt_InherentScoreText = charisma.InherentScore;
            CharismaScoreControl.CstmTxt_TempScoreText = charisma.TempScore;
            CharismaScoreControl.CstmTxt_PenaltyScoreText = charisma.PenaltyScore;

        }

        public void ClearForm()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
            }
        }
    }
}
