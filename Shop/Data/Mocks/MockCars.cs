using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Mocks
{
    public class MockCars : IAllCars
    {
      
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get {
                return new List<Car>
                {
                    new Car {
                        Name = "Ducati",
                        Desc = "MONSTEEER",
                        Img = "https://avto-russia.ru/moto/ducati/photo/ducati_xdiavel_1.jpg",
                        Price = 20000,
                        IsAvailable = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        Name = "Tesla S Model",
                        Desc = "So quite car for the quite people",
                        Img = "https://podrobnosti.ua/media/pictures/2018/12/4/thumbs/740x415/foto-teslacom_rect_684c4bdd24823513a1ec02153e268499.jpg",
                        Price = 60000,
                        IsAvailable = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Mercedes-Benz Brabus G 63 AMG B63-620",
                        Desc = "The best car gor the gangsats",
                        Img = "https://ag-spots-2018.o.auroraobjects.eu/2018/05/02/mercedes-benz-brabus-g-63-amg-b63-620-c411602052018012858_1.jpg",
                        Price = 60000,
                        IsAvailable = true,
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        Name = "Tesla Model X",
                        Desc = "Cyberpank car",
                        Img = "https://3dnews.ru/assets/external/illustrations/2019/04/24/986408/sm.MX.750.jpg",
                        Price = 60000,
                        IsAvailable = true,
                        Category = _categoryCars.AllCategories.Last()
                    }
                };
            }
        }

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
