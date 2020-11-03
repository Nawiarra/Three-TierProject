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

        public List<string> GetBlackList()
        {
            List<string> numbersBlackList = new List<string>();

            FileStream file = new FileStream("blacklist.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            while (!reader.EndOfStream)
            {
                numbersBlackList.Add(reader.ReadLine());
            }

            return numbersBlackList;
        }
    }
}
