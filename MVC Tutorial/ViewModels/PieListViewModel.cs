using MVC.Models;
using System.Collections.Generic;

namespace MVC.ViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }  
        public string CurrentCategory { get; set; } 
    }
}
