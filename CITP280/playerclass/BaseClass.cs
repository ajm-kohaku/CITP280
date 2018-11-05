using CITP280.util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CITP280.playerclass
{
    //base class for most playable classes. child tables will have distinct features in phase 2.
    public abstract class BaseClass : IPlayableClass
    {
        public ClassTypes ClassType => ClassTypes.BASE;
        public abstract string ClassName { get; }
        public abstract BaseAttackScale BaseAttack { get; }
        public abstract SavesScale FortitudeScale { get; }
        public abstract SavesScale ReflexScale { get; }
        public abstract SavesScale WillScale { get; }
        public abstract int SkillRanksPerLevel { get; }
        public abstract int DieType { get; }
        public int MaxLevel => 20;
        
        public abstract List<string> GetClassSkills();
        public abstract List<string> GetClassAbilitiesTableList();
        
        public DataTable ClassDatatableView()
        {
            //inspiration source https://docs.microsoft.com/en-us/dotnet/framework/data/adonet/dataset-datatable-dataview/adding-data-to-a-datatable
            //create data table to represent class summary table.
            DataTable table = new DataTable();
            ClassDataTableColumns().ForEach(column => table.Columns.Add(column));
            if (GetClassAbilitiesTableList().Count == MaxLevel)
            {
                for (int i = 1; i <= MaxLevel; i++)
                {
                    DataRow classRow = table.NewRow();
                    int bab = ScaleCalculations.GetBaseAttack(i, BaseAttack);
                    classRow[0] = i.ToString(); //level
                    classRow[1] = ScaleCalculations.GetFormattedBaseAttackBonus(bab); // base attack bonus
                    classRow[2] = "+" + ScaleCalculations.GetSave(i, FortitudeScale); // fortitude save
                    classRow[3] = "+" + ScaleCalculations.GetSave(i, ReflexScale); // reflex save
                    classRow[4] = "+" + ScaleCalculations.GetSave(i, WillScale); // will save
                    classRow[5] = GetClassAbilitiesTableList().ElementAt(i - 1) ?? ""; // special ability description for particular level
                    table.Rows.Add(classRow);
                }
            }
            else
            {
                //throw new ArgumentOutOfRangeException("The number of class abilities does not match the number of levels for this class. Please update the class abilities to match");
            }

            return table;
        }

        public virtual List<String> ClassDataTableColumns()
        {
            List<String> columns = new List<String>
            {
                "Level",
                "Base Attack Bonus",
                "Fort Save",
                "Ref Save",
                "Will Save",
                "Special"
            };
            return columns;
        }

        //todo: get rid of this. it's no longer necessary
        public virtual List<List<String>> ClassDataTableRows()
        {
            
            List<List<String>> table = new List<List<String>>();
           
            return table;
        }

    }
}
