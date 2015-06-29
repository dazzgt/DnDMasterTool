using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using DnDMasterTool.Models;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;

namespace DnDMasterTool
{
    public class MasterToolViewModel
    {
        public MasterToolViewModel()
        {
            Heroes = new ObservableCollection<Hero>();
            GameName = DateTime.Now.ToShortDateString();
        }

        #region Properties

        public ObservableCollection<Hero> Heroes { get; set; }
        public int SelectedHero { get; set; }
        public string GameName { get; set; }

        #endregion

        #region Methods

        public void PrintHero()
        {
            if (SelectedHero != -1 && Heroes.Count - 1 >= SelectedHero)
            {
                CreateCharList(SelectedHero);
            }
            else
                MessageBox.Show("Выберите героя");
        }
        public void PrintAllHero()
        {
            
        }

        protected void PrintHeroByIndex(int index)
        {
            
        }
        protected void CreateCharList(int index)
        {
            Object oMissing = System.Reflection.Missing.Value;
            Object oTemplatePath = Directory.GetCurrentDirectory()+"\\resources\\HeroTemplate.dotx";

            Application wordApp = new Application();
            Document wordDoc = new Document();

            wordDoc = wordApp.Documents.Add(ref oTemplatePath, ref oMissing, ref oMissing, ref oMissing);

            foreach (Field myMergeField in wordDoc.Fields)
            {

                Range rngFieldCode = myMergeField.Code;
                String fieldText = rngFieldCode.Text;

                if (fieldText.StartsWith(" MERGEFIELD"))
                {

                    Int32 endMerge = fieldText.IndexOf("\\");
                    Int32 fieldNameLength = fieldText.Length - endMerge;
                    String fieldName = fieldText.Substring(11, endMerge - 11);

                    fieldName = fieldName.Trim();
                    string value = GetValue(index, fieldName);
                    if (!string.IsNullOrEmpty(value))
                    {
                        myMergeField.Select();
                        wordApp.Selection.TypeText(value);
                    }
                }
            }
            if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\" + GameName))
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\" + GameName);
            wordDoc.SaveAs(Directory.GetCurrentDirectory() + "\\" + GameName + "\\" + Heroes[index].Name+".doc");
        }

        private string GetValue(int index, string fieldName)
        {
            switch (fieldName)
            {
                case "Name":
                    return Heroes[index].Name;
                case "Str":
                    return Heroes[index].Str.ToString();
                case "Dex":
                    return Heroes[index].Dex.ToString();
                case "Con":
                    return Heroes[index].Con.ToString();
                case "Int":
                    return Heroes[index].Int.ToString();
                case "Wis":
                    return Heroes[index].Wis.ToString();
                case "Cha":
                    return Heroes[index].Cha.ToString();
                case "StrMod":
                    return Heroes[index].StrMod.ToString();
                case "DexMod":
                    return Heroes[index].DexMod.ToString();
                case "ConMod":
                    return Heroes[index].ConMod.ToString();
                case "IntMod":
                    return Heroes[index].IntMod.ToString();
                case "WisMod":
                    return Heroes[index].WisMod.ToString();
                case "ChaMod":
                    return Heroes[index].ChaMod.ToString();
                default:
                    return null;
            }
        }

        #endregion

        public void DeleteHero()
        {
            Heroes.RemoveAt(SelectedHero);
        }
    }
}
