using System;
using WoodWorkshop.Models.PostModels;
using WoodWorkshop.Domain;
using WoodWorkshop.Data.Enums;
using AutoMapper;
using WoodWorkshop.Domain.Models;

namespace WoodWorkshop.Controllers
{
    public class WoodFurnitureController
    {
        private readonly WoodWorkshopService _woodWorkshopService;
        private readonly IMapper _mapper;

        public WoodFurnitureController()
        {
            _woodWorkshopService = new WoodWorkshopService();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                var map = cfg.CreateMap<CreateWoodFurniturePostModel, WoodFurnitureModel>();
            });

            var mapper = new Mapper(mapperConfig);
        }

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
