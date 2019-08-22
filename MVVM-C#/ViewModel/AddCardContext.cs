using MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM.ViewModel
{
    class AddCardContext : CardContext
    {
        public AddCardContext(Window win, Recipe recipe) : base(win, recipe) { }

        protected override void end(object obj)
        {
            if (CurrectRecipe.Name != "")
            {

                var someRecipe = db.Recipes.Find(CurrectRecipe.Name);
                //если не найдён рецепт с таким именем
                if (someRecipe == null)
                {
                    //если поля не заполненны
                    if (CurrectRecipe.Name == "" || CurrectRecipe.Text == "" || CurrectRecipe.Text == null)
                        MessageBox.Show("Не все поля заполенны");
                    else
                    {
                        CurrectRecipe.CreateDate = DateTime.Now.ToString().Split(' ')[0];
                        db.Recipes.Add(CurrectRecipe);
                        db.SaveChanges();
                        db.Dispose();
                        rootWindow.DialogResult = true;
                        rootWindow.Close();
                    }
                }
                else
                    MessageBox.Show("Такой рецепт уже существует");
            }
            else
                MessageBox.Show("Имя не может быть пустым");
        }
    }
}
