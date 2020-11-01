using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodWorkshop.Models.PostModels;
using WoodWorkshop.Enums;

namespace WoodWorkshop.Controllers
{
    public class WoodFurnitureController
    {
        public void CreateWoodFurnitureRequest(CreateWoodFurniturePostModel model)
        {
            if (string.IsNullOrWhiteSpace(model.FullName))
                throw new System.Exception("Invalid FullName");
            if (model.PhoneNumber.Length != 13)
                throw new System.Exception("Invalid Phone Number");
            if((model.FurnitureType<0)||(model.FurnitureType > FurnitureTypes.Bench))
                throw new System.Exception("Invalid Furniture Type");
        }

    }
}
