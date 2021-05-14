using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Shop.Controllers
{
    public class CarsController : Controller {

        private readonly IAllCars _allcars;
        private readonly ICarsCategory _allcategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCategory)
        {
            _allcars = iAllCars;
            _allcategories = iCarsCategory;

        }
        public ViewResult List() {
            ViewBag.Title = "Все авто";
            CarsListViewModel obj = new CarsListViewModel();
            obj.allCars = _allcars.Cars;
            obj.currentCategory = "Auto";

            return View(obj);
        }

    }
}
