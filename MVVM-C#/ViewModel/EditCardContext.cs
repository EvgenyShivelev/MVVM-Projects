using MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static MVVM.AdditionalAPI.TextEditor;

namespace MVVM.ViewModel
{
    class EditCardContext: CardContext
    {
        public EditCardContext(Window win, Recipe recipe) : base(win, recipe) { isEnabled = false; 
        }

        protected override void end(object obj)
        {
            if (CurrectRecipe.Name != "")
            {
                var recipe = db.Recipes.Find(CurrectRecipe.Name);
                recipe.Text = recipe.Text = ConvertStepsIntoText(Text.ToList());
                db.SaveChanges();
                db.Dispose();
                rootWindow.DialogResult = true;
                rootWindow.Close();
            }
        }
    }
}
