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
    public partial class Animal : UserControl
    {
        bool Editable;
        public DateTime LastFeedTime { get ; set ; }

        private string AnimalID;
        private string AnimalTypeID;
        private string FoodID;
        private string Description;

        public Animal()
        {
            InitializeComponent();
        }

        public Animal(string animalID,string foodID, string sectorID,string name, string family,string description,double weight,double foodAmount)
        {
            InitializeComponent();
            AnimalID = animalID;
            FoodID = foodID;
            Description = description;

            Name.Text = name;
            Family.Text = family;
            SectorID.Text = sectorID;
            Weight.Text = weight.ToString();
            FoodAmount.Text = foodAmount.ToString();
        }

        private void Edit(object sender,RoutedEventArgs e)
        {
            Editable = !Editable;
            Console.WriteLine($"Is editable: {Editable}");

            //open edit window 
        }

        private void Feed(object sender,RoutedEventArgs e)
        {
            if (LastFeedTime < DateTime.Now.AddHours(6))
            {
                LastFeedTime = DateTime.Now;
            } else
            {
                Console.WriteLine($"Animal '{Name.Text}' with ID '{AnimalID}' recently fed.");
            }

            //set that animal was feed in db
        }

        private void Delete(object sender,RoutedEventArgs e)
        {
            //delete object and then reload animals list
        }
    }
}
