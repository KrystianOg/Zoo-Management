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

namespace Zoo_Management.Controls.Panels
{
    /// <summary>
    /// Interaction logic for AnimalsPanel.xaml
    /// </summary>
    public partial class AnimalsPanel : UserControl
    {
        public AnimalsPanel()
        {
            InitializeComponent();


            for(int i = 0; i < 40; i++)
            {
                //AddAnimal(new Animal("aaaaaa", "meat 4E", "4D", "elephant", "elephanty", "something about elephants", 3456.2, 203.5));
                AddAnimal(new Animal());
            }
        }

        public void AddAnimal(Animal animal)
        {
            AnimalsStackPanel.Children.Add(animal);
        }
    }
}
