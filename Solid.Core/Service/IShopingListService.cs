using project_Riki_Mittelman.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Service
{
    public interface IShopingListService
    {
        List<ShopingList> GetAll(string? text = "");
        ShopingList Get(int id);
        void Delete(int id);
        void Put(int id, ShopingList product);
        void Update(int id, ShopingList product);
    }
}
