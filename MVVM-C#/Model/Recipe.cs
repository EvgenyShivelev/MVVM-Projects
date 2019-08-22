using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVM.Model
{
    public class Recipe : INotifyPropertyChanged
    {
        private string name;
        private string text;
        private string createDate;

        [Key]
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged("text");
            }
        }
        public string CreateDate
        {
            get { return createDate; }
            set
            {
                createDate = value;
                OnPropertyChanged("CreateDate");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public string RecipeInfo { get { return $"{Name} ({CreateDate}) "; } }

        public int SortByName(Recipe recipe)
        {
            return string.Compare(Name, recipe.name);
        }

    }
}
