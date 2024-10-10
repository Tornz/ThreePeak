using Microsoft.AspNetCore.Mvc;
using ThreePeaks.Models;
using OfficeOpenXml;
using ThreePeaks.Interfaces;


namespace ThreePeaks.Controllers
{
    public class StoreController : Controller
    {       
        //private static List<StoreModel> _store = new();   
        private readonly IStoreRepository _repository;

        

        public StoreController(IStoreRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View(_repository.GetStoreList());
        }

        [HttpPost]
        public IActionResult Upload(IFormFile excelFile)
        {
            _repository.ImportData(excelFile);
            return View(_repository.GetStoreList());
        }
       
    }
}