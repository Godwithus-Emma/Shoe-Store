using System.Collections.Generic;

namespace MVC.Models
{
    public interface IPieRespository
    {
        IEnumerable<Pie> AllPies { get; }
        IEnumerable<Pie> PiesOfTheWeek { get; }
        Pie GetPieById (int pieid);    
        
    }
}
