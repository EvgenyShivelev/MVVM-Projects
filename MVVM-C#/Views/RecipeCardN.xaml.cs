using MVVM.Model;
using MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MVVM.Views
{
    /// <summary>
    /// Логика взаимодействия для RecipeCardN.xaml
    /// </summary>
    public partial class RecipeCardN : Window
    {
        public RecipeCardN(Recipe recipe, bool isNew)
        {

            InitializeComponent();
            DataContext = (isNew == true) ? new AddCardContext(this, recipe) as CardContext : new EditCardContext(this, recipe);
        }
    }
}
