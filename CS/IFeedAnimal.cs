using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Zoo_Management.CS
{
    public interface IFeedAnimal
    {
        DateTime LastFeedTime { get; set; }

        //void Feed(object sender, RoutedEventArgs e); 
    }

}
