using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AutoMapper;
using WoodWorkshop.Data.Models;
using WoodWorkshop.Data.Repositories;
using WoodWorkshop.Domain.Models;

namespace WoodWorkshop.Domain
{
    public class WoodWorkshopService
    {
        private readonly WoodWorkshopRepository _woodWorkshopRepository;
        private readonly IMapper _mapper;

        public WoodWorkshopService()
        {
            _woodWorkshopRepository = new WoodWorkshopRepository();


            var mapperConfig = new MapperConfiguration(cfg =>
            {
                var map = cfg.CreateMap< WoodFurnitureModel, WoodFurniture>().ReverseMap();
            });

            _mapper = new Mapper(mapperConfig);
        }

        public void CreateFurnitureRequest(WoodFurnitureModel model)
        {

            List<string> NumbersBlackList = _woodWorkshopRepository.GetBlackList();

            if (NumbersBlackList.Any(phone => phone.Equals(model.PhoneNumber)))
                throw new System.Exception("This phone number in blacklist");

            var woodFurniture = _mapper.Map<WoodFurniture>(model);

            _woodWorkshopRepository.Create(woodFurniture);

        }

        public WoodFurnitureModel GetItemById(int id)
        {
            var woodFurniture = _woodWorkshopRepository.GetItemById(id); 

            return _mapper.Map<WoodFurnitureModel>(woodFurniture);
        }
    }
}
