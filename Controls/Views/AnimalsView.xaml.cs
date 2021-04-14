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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zoo_Management.Controls.Views
{
    /// <summary>
    /// Interaction logic for AnimalsView.xaml
    /// </summary>
    public partial class AnimalsView : UserControl
    {
        public AnimalsView()
        {
            InitializeComponent();
            
            for (int i = 0; i < 50; i++)
            {
                Animal animal = new Animal("Elephant", "Elephanty", 3, 5000, 500, "trawa");
                Animals.Children.Add(animal);
            }
        }

        
    }
}
