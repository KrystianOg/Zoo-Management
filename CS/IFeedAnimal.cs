using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Management.CS
{
    public interface IFeedAnimal
    {
        DateTime LastFeedTime { get; set; }

        void Feed(); 
    }

}
