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

namespace Zoo_Management.Controls
{
    /// <summary>
    /// Interaction logic for Animal.xaml
    /// </summary>
    public partial class Animal : UserControl
    {
      
        public Animal(string Name, string Family, int Amount, double Weight, double AmountOfFood, string TypeOfFood)
        {
            InitializeComponent();
            this.Name.Text = Name;
            this.Family.Text = Family;
            this.Amount.Text = Amount.ToString();
            this.Weight.Text = Weight.ToString();
            this.AmountOfFood.Text = AmountOfFood.ToString();
            this.TypeOfFood.Text = TypeOfFood;
            
        }
    }
}
