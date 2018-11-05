using CITP280.playerclass;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CITP280
{
    public partial class Form1 : Form
    {
        //create list list of playable classes
        private List<IPlayableClass> playableClasses;

        //generated code
        public Form1() => InitializeComponent();

        //instantiate the list of playable classes.
        internal List<IPlayableClass> PlayableClasses {
            get {
                playableClasses = new List<IPlayableClass>
                {
                    new Barbarian()
                };
                //playableClasses.Add(new Bard());
                //playableClasses.Add(new Cleric());
                //playableClasses.Add(new Fighter());
                //playableClasses.Add(new Monk());
                //playableClasses.Add(new Sorcerer());
                return playableClasses;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //put list of playable classes into the class names drop down.
            foreach (IPlayableClass playable in PlayableClasses)
            {
                cbClassNames.Items.Add(playable.ClassName);
            }
            //default the dropdown to the first item in the list so that there's something to display on the screen.
            cbClassNames.SelectedIndex = 0;
        }

        //when a class name is selected, update the page with info on the class
        private void ClassNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            //find the Playable Class by name
            IPlayableClass playableClass = playableClasses.Find(pc => pc.ClassName.Contains(cbClassNames.GetItemText(item: cbClassNames.SelectedItem)));
            //use information about the class to load it into the DataGridView to display statistics on the class by level.
            LoadClassTable(playableClass);


            //display the type of dice used to determine health of the character
            lbHitDieType.Text = "d" + playableClass.DieType;
            //display the number of of skill points the player should spend each level
            lbSkillsPerLevel.Text = playableClass.SkillRanksPerLevel + " + INT";
            //display comma delimited list of skills the player can use.
            lbClassSkillsList.Text = string.Join(", ", playableClass.GetClassSkills());

        }

        //builds DataGridView data source
        private void LoadClassTable(IPlayableClass playableClass)
        {
            dgClassTableView.DataSource = playableClass.ClassDatatableView();
            dgClassTableView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            int levelIndex = dgClassTableView.Columns["Level"].Index;
            dgClassTableView.Columns[levelIndex].Width = 50;
            int babIndex = dgClassTableView.Columns["Base Attack Bonus"].Index;
            dgClassTableView.Columns[babIndex].Width = 135;
            int fortIndex = dgClassTableView.Columns["Fort Save"].Index;
            dgClassTableView.Columns[fortIndex].Width = 50;
            int refIndex = dgClassTableView.Columns["Ref Save"].Index;
            dgClassTableView.Columns[refIndex].Width = 50;
            int willIndex = dgClassTableView.Columns["Will Save"].Index;
            dgClassTableView.Columns[willIndex].Width = 50;
            int specialIndex = dgClassTableView.Columns["Special"].Index;
            dgClassTableView.Columns[specialIndex].Width = 200;
        }

    }
}
