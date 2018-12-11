using CITP280.data;
using CITP280.util;
using System.Collections.Generic;
using System.Windows.Forms;

using static CITP280.util.TextBoxValidator;

namespace CITP280
{
    partial class CharacterSheetForm
    {
        private CharacterSheetData convertFormToCharacterSheet()
        {
            //create character sheet data object to generate a file
            CharacterSheetData characterSheet = new CharacterSheetData();
            characterSheet.DamageTaken = ConvertToInt(DamageTakenTextBox);

            CharacterClassData class1Record = new CharacterClassData()
            {
                PlayerClassName = cbClassNames1.GetItemText(item: cbClassNames1.SelectedItem),
                MaxHealth = ConvertToInt(lblClass1HealthFromLevel),
                PlayerClassLevel = ConvertToInt(tbClass1Level),
                FavoredClassSkillCount = ConvertToInt(tbClass1FavoredClassSkills),
                FavoredClassHealthCount = ConvertToInt(tbClass1FavoredClassHitPoints),
                FavoredClassOtherCount = ConvertToInt(tbClass1FavoredClassOther)
            };

            CharacterClassData class2Record = new CharacterClassData()
            {
                PlayerClassName = cbClassNames2.GetItemText(item: cbClassNames2.SelectedItem),
                MaxHealth = ConvertToInt(lblClass2HealthFromLevel),
                PlayerClassLevel = ConvertToInt(tbClass2Level),
                FavoredClassSkillCount = ConvertToInt(tbClass2FavoredClassSkills),
                FavoredClassHealthCount = ConvertToInt(tbClass2FavoredClassHitPoints),
                FavoredClassOtherCount = ConvertToInt(tbClass2FavoredClassOther)
            };

            characterSheet.ClassRecordList = new List<CharacterClassData>()
            {
                class1Record,
                class2Record
            };


            characterSheet.Strength = new AttributeData()
            {
                AbilityName = CoreAttributes.STRENGTH,
                BaseScore = ConvertToInt(StrengthScoreControl.CstmTxt_BaseAbilityScoreText),
                EnhancementScore = ConvertToInt(StrengthScoreControl.CstmTxt_EnhancementScoreText),
                InherentScore = ConvertToInt(StrengthScoreControl.CstmTxt_InherentScoreText),
                TempScore = ConvertToInt(StrengthScoreControl.CstmTxt_TempScoreText),
                PenaltyScore = ConvertToInt(StrengthScoreControl.CstmTxt_PenaltyScoreText)
            };

            characterSheet.Dexterity = new AttributeData()
            {
                AbilityName = CoreAttributes.DEXTERITY,
                BaseScore = ConvertToInt(DexterityScoreControl.CstmTxt_BaseAbilityScoreText),
                EnhancementScore = ConvertToInt(DexterityScoreControl.CstmTxt_EnhancementScoreText),
                InherentScore = ConvertToInt(DexterityScoreControl.CstmTxt_InherentScoreText),
                TempScore = ConvertToInt(DexterityScoreControl.CstmTxt_TempScoreText),
                PenaltyScore = ConvertToInt(DexterityScoreControl.CstmTxt_PenaltyScoreText)
            };

            characterSheet.Constitution = new AttributeData()
            {
                AbilityName = CoreAttributes.CONSTITUTION,
                BaseScore = ConvertToInt(ConstitutionScoreControl.CstmTxt_BaseAbilityScoreText),
                EnhancementScore = ConvertToInt(ConstitutionScoreControl.CstmTxt_EnhancementScoreText),
                InherentScore = ConvertToInt(ConstitutionScoreControl.CstmTxt_InherentScoreText),
                TempScore = ConvertToInt(ConstitutionScoreControl.CstmTxt_TempScoreText),
                PenaltyScore = ConvertToInt(ConstitutionScoreControl.CstmTxt_PenaltyScoreText)
            };

            characterSheet.Intelligence = new AttributeData()
            {
                AbilityName = CoreAttributes.INTELLIGENCE,
                BaseScore = ConvertToInt(IntelligenceScoreControl.CstmTxt_BaseAbilityScoreText),
                EnhancementScore = ConvertToInt(IntelligenceScoreControl.CstmTxt_EnhancementScoreText),
                InherentScore = ConvertToInt(IntelligenceScoreControl.CstmTxt_InherentScoreText),
                TempScore = ConvertToInt(IntelligenceScoreControl.CstmTxt_TempScoreText),
                PenaltyScore = ConvertToInt(IntelligenceScoreControl.CstmTxt_PenaltyScoreText)
            };

            characterSheet.Wisdom = new AttributeData()
            {
                AbilityName = CoreAttributes.WISDOM,
                BaseScore = ConvertToInt(WisdomScoreControl.CstmTxt_BaseAbilityScoreText),
                EnhancementScore = ConvertToInt(WisdomScoreControl.CstmTxt_EnhancementScoreText),
                InherentScore = ConvertToInt(WisdomScoreControl.CstmTxt_InherentScoreText),
                TempScore = ConvertToInt(WisdomScoreControl.CstmTxt_TempScoreText),
                PenaltyScore = ConvertToInt(WisdomScoreControl.CstmTxt_PenaltyScoreText)
            };

            characterSheet.Charisma = new AttributeData()
            {
                AbilityName = CoreAttributes.CHARISMA,
                BaseScore = ConvertToInt(CharismaScoreControl.CstmTxt_BaseAbilityScoreText),
                EnhancementScore = ConvertToInt(CharismaScoreControl.CstmTxt_EnhancementScoreText),
                InherentScore = ConvertToInt(CharismaScoreControl.CstmTxt_InherentScoreText),
                TempScore = ConvertToInt(CharismaScoreControl.CstmTxt_TempScoreText),
                PenaltyScore = ConvertToInt(CharismaScoreControl.CstmTxt_PenaltyScoreText)
            };
            return characterSheet;
        }

        private void PopulateFormFromJson(CharacterSheetData characterSheet)
        {
            DamageTakenTextBox.Text = characterSheet.DamageTaken.ToString();

            CharacterClassData class1Record = characterSheet.ClassRecordList[0];
            cbClassNames1.SelectedIndex = cbClassNames1.FindStringExact(class1Record.PlayerClassName);
            lblClass1HealthFromLevel.Text = class1Record.MaxHealth.ToString();
            tbClass1Level.Text = class1Record.PlayerClassLevel.ToString();
            tbClass1FavoredClassSkills.Text = class1Record.FavoredClassSkillCount.ToString();
            tbClass1FavoredClassHitPoints.Text = class1Record.FavoredClassHealthCount.ToString();
            tbClass1FavoredClassOther.Text = class1Record.FavoredClassOtherCount.ToString();

            CharacterClassData class2Record = characterSheet.ClassRecordList[1];
            cbClassNames2.SelectedIndex = cbClassNames2.FindStringExact(class2Record.PlayerClassName);
            lblClass1HealthFromLevel.Text = class2Record.MaxHealth.ToString();
            tbClass2Level.Text = class2Record.PlayerClassLevel.ToString();
            tbClass2FavoredClassSkills.Text = class2Record.FavoredClassSkillCount.ToString();
            tbClass2FavoredClassHitPoints.Text = class2Record.FavoredClassHealthCount.ToString();
            tbClass2FavoredClassOther.Text = class2Record.FavoredClassOtherCount.ToString();

            AttributeData strength = characterSheet.Strength;
            StrengthScoreControl.CstmTxt_BaseAbilityScoreText = strength.BaseScore.ToString();
            StrengthScoreControl.CstmTxt_EnhancementScoreText = strength.EnhancementScore.ToString();
            StrengthScoreControl.CstmTxt_InherentScoreText = strength.InherentScore.ToString();
            StrengthScoreControl.CstmTxt_TempScoreText = strength.TempScore.ToString();
            StrengthScoreControl.CstmTxt_PenaltyScoreText = strength.PenaltyScore.ToString();

            AttributeData dexterity = characterSheet.Dexterity;
            DexterityScoreControl.CstmTxt_BaseAbilityScoreText = dexterity.BaseScore.ToString();
            DexterityScoreControl.CstmTxt_EnhancementScoreText = dexterity.EnhancementScore.ToString();
            DexterityScoreControl.CstmTxt_InherentScoreText = dexterity.InherentScore.ToString();
            DexterityScoreControl.CstmTxt_TempScoreText = dexterity.TempScore.ToString();
            DexterityScoreControl.CstmTxt_PenaltyScoreText = dexterity.PenaltyScore.ToString();

            AttributeData constitution = characterSheet.Constitution;
            ConstitutionScoreControl.CstmTxt_BaseAbilityScoreText = constitution.BaseScore.ToString();
            ConstitutionScoreControl.CstmTxt_EnhancementScoreText = constitution.EnhancementScore.ToString();
            ConstitutionScoreControl.CstmTxt_InherentScoreText = constitution.InherentScore.ToString();
            ConstitutionScoreControl.CstmTxt_TempScoreText = constitution.TempScore.ToString();
            ConstitutionScoreControl.CstmTxt_PenaltyScoreText = constitution.PenaltyScore.ToString();

            AttributeData intelligence = characterSheet.Intelligence;
            IntelligenceScoreControl.CstmTxt_BaseAbilityScoreText = intelligence.BaseScore.ToString();
            IntelligenceScoreControl.CstmTxt_EnhancementScoreText = intelligence.EnhancementScore.ToString();
            IntelligenceScoreControl.CstmTxt_InherentScoreText = intelligence.InherentScore.ToString();
            IntelligenceScoreControl.CstmTxt_TempScoreText = intelligence.TempScore.ToString();
            IntelligenceScoreControl.CstmTxt_PenaltyScoreText = intelligence.PenaltyScore.ToString();

            AttributeData wisdom = characterSheet.Wisdom;
            WisdomScoreControl.CstmTxt_BaseAbilityScoreText = wisdom.BaseScore.ToString();
            WisdomScoreControl.CstmTxt_EnhancementScoreText = wisdom.EnhancementScore.ToString();
            WisdomScoreControl.CstmTxt_InherentScoreText = wisdom.InherentScore.ToString();
            WisdomScoreControl.CstmTxt_TempScoreText = wisdom.TempScore.ToString();
            WisdomScoreControl.CstmTxt_PenaltyScoreText = wisdom.PenaltyScore.ToString();

            AttributeData charisma = characterSheet.Charisma;
            CharismaScoreControl.CstmTxt_BaseAbilityScoreText = charisma.BaseScore.ToString();
            CharismaScoreControl.CstmTxt_EnhancementScoreText = charisma.EnhancementScore.ToString();
            CharismaScoreControl.CstmTxt_InherentScoreText = charisma.InherentScore.ToString();
            CharismaScoreControl.CstmTxt_TempScoreText = charisma.TempScore.ToString();
            CharismaScoreControl.CstmTxt_PenaltyScoreText = charisma.PenaltyScore.ToString();

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

                if (control is AbilityScoreCalculationControl)
                {
                    ((AbilityScoreCalculationControl)control).ClearControl();
                }
            }

            tbCurrentHealth.Text = " / ";
        }
    }
}
