using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodWorkshop.Enums;

namespace WoodWorkshop.Models.ViewModels
{
    class WoodFurnitureViewModel
    {
        public class CarWashViewModel
        {
            public int Id { get; set; }
            public string PhoneNumber { get; set; }
            public string FullName { get; set; }
            public FurnitureTypes FurnitureType { get; set; }
            public string Color { get; set; }
            public string WoodType { get; set; }
        }
    }
}
