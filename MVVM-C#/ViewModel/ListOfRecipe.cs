using Microsoft.EntityFrameworkCore;
using MVVM.AdditionalAPI;
using MVVM.Model;
using MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static MVVM.DataBase.AppContext;

namespace MVVM.ViewModel
{
    public class ListOfRecipe: INotifyPropertyChanged
    {
        ObservableCollection<Recipe> recipes;
        Recipe currentRecipe;
    
        public ICommand addRecipe { get; private set; }
        public ICommand editRecipe { get; private set; }
        public ICommand deleteRecipe { get; private set; }

        public ICommand sortByName { get; private set; }
        public ICommand sortByDate { get; private set; }

        public ObservableCollection<Recipe> Recipe
        {
            get { return recipes; }
            private set
            {
                recipes = value;
                OnPropertyChanged("Recipe");

            }
        }

        public Recipe CurrectRecipe
        {
            get { return currentRecipe; }
            set
            {
                currentRecipe = value;
                OnPropertyChanged("CurrectRecipe");
            }
        }


        bool IsRecipeSelected(object obj) => (obj as Recipe) != null;


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public ListOfRecipe()
        {   
            deleteRecipe = new Command(deleteRiceapAction, IsRecipeSelected);
            addRecipe = new Command(AddRecipeAction);
            editRecipe = new Command(editRecipeAction, IsRecipeSelected);
            sortByName = new Command(_sortByName);
            Update();
        }
        void _sortByName(object obj)
        {
            var recipeList = Recipe.ToList();

            for (int j = 0; j <= recipeList.Count - 2; j++)
            {
                for (int i = 0; i <= recipeList.Count - 2; i++)
                {

                    if (recipeList[i].SortByName(recipeList[i + 1]) == 1 || recipeList[i].SortByName(recipeList[i + 1]) == 0)
                        swapInList(recipeList, i, i + 1);
                }
            }
            Recipe = new ObservableCollection<Recipe>(recipeList);
        }

    
        void swapInList<T>(List<T> list, int index1, int index2)
        {
            T tmp = list[index1];
            list[index1] = list[index2];
            list[index2] = tmp;
        }


        void AddRecipeAction(object obj)
        {
            var newRecipe = new Recipe();
            if (new RecipeCardN(newRecipe, true).ShowDialog() == true)
            {
                Update();
            }
        }

        void editRecipeAction(object obj)
        {
            if (new RecipeCardN(CurrectRecipe, false).ShowDialog() == true)
                Update();
        }


        void deleteRiceapAction(object obj)
        {
            using (var app = new ApplicationContext())
            {
                var _curriceap = obj as Recipe;
                app.Recipes.Remove(app.Recipes.Find(_curriceap.Name));
                app.SaveChanges();
                Update();
            }

        }

        public void Update()
        {

            using (var db = new ApplicationContext())
            {
                db.Recipes.Load();
                Recipe = new ObservableCollection<Recipe>(db.Recipes.Local.ToList());
            }
        }
    }
}
