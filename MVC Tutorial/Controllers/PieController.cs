using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using MVC.ViewModels;

namespace MVC.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRespository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRespository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            PieListViewModel pieListViewModel = new PieListViewModel
            {
                Pies = _pieRepository.AllPies,
                CurrentCategory = " Cheese Cakes"
            };
            return View(pieListViewModel);
        }
    }
}
