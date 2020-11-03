using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodWorkshop.Data.Models;

namespace WoodWorkshop.Data.Repositories
{
    public class WoodWorkshopRepository
    {
        private List<WoodFurniture> WoodFurnitures { get; set; }

        public WoodWorkshopRepository()
        {
            WoodFurnitures = new List<WoodFurniture>();
        }

        public void Create(WoodFurniture model)
        {
            WoodFurnitures.Add(model);
        }

        public WoodFurniture GetItemById(int id)
        {
            return WoodFurnitures.First(x => x.Id == id); //  .ToArray()[id];
        }

        public List<WoodFurniture> GetItemsWithSameName(string name)
        {
            return WoodFurnitures.Where(x=>x.FullName == name).ToList();
        }
    }
}
