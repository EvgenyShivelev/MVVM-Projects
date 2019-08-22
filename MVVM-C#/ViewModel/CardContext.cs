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
using System.Windows;
using System.Windows.Input;
using static MVVM.AdditionalAPI.TextEditor;
using static MVVM.DataBase.AppContext;

namespace MVVM.ViewModel
{
    public abstract class CardContext : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        protected ApplicationContext db;
        Recipe recipe;
        protected ObservableCollection<StepData> convertedText;
        protected Window rootWindow;

        public bool isEnabled { get; set; } = true;

        public ICommand AddNewStep { get; private set; }
        public ICommand DeleteStep { get; private set; }
        public ICommand EndEdit { get; private set; }
        public ICommand StartRec { get; private set; }
        public ICommand StopRec { get; private set; }

        public ObservableCollection<StepData> Text
        {
            get { return convertedText; }
            set
            {
                convertedText = value;
                OnPropertyChanged("Text");
            }
        }

        public Recipe CurrectRecipe
        {
            get { return recipe; }
            set
            {
                recipe = value;
                OnPropertyChanged("CurrectRecipe");
            }
        }
    

        public CardContext(Window win, Recipe recipe)
        {
            db = new ApplicationContext();
            CurrectRecipe = recipe;
            Text = new ObservableCollection<StepData>(ConvertTextIntoSteps(recipe.Text));
            rootWindow = win;
            AddNewStep = new Command(addNewStep);
            EndEdit = new Command(end, isMayEnd);
        }

        void addNewStep(object obj)
        {
            InputForm dialog = new InputForm();
            if (dialog.ShowDialog() == true)
            {
                CurrectRecipe.Text += $"{Text.Count + 1} {dialog.Inputed};";
                Text.Add(new StepData(Text.Count + 1, dialog.Inputed));
            }
            OnPropertyChanged("Text");
                        
        }

        protected virtual bool isMayEnd(object obj) => ((string)obj) != "";
        protected abstract void end(object obj);

    }
}
