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

using Zoo_Management.CS;

namespace Zoo_Management.Controls
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class Animal : UserControl, IFeedAnimal
    {
        public DateTime LastFeedTime { get ; set ; }

        private string AnimalID;
        private string FoodID;
        private string Description;

        public Animal()
        {
            InitializeComponent();
        }

        public Animal(string animalID,string foodID, string sectorID,string name, string family,string description,double weight,double foodAmount)
        {
            AnimalID = animalID;
            FoodID = foodID;
            Description = description;

            Name.Text = name;
            Family.Text = family;
            SectorID.Text = sectorID;
            Weight.Text = weight.ToString();
            FoodAmount.Text = foodAmount.ToString();
        }

        void IFeedAnimal.Feed()
        {

        }

        private void Feed(object sender,RoutedEventArgs e)
        {

        }

        private void Edit(object sender,RoutedEventArgs e)
        {

        }
    }
}
