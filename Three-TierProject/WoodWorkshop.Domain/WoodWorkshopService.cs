using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                var map = cfg.CreateMap< WoodFurnitureModel, WoodFurniture>();
            });

            _mapper = new Mapper(mapperConfig);
        }

        public void CreateFurnitureRequest(WoodFurnitureModel model)
        {
            // Проверка ести ли свободное  окно, 
            // чтобы записать на мойку эту машину

            var woodFurniture = _mapper.Map<WoodFurniture>(model);

            _woodWorkshopRepository.Create(woodFurniture);

        }
    }
}
