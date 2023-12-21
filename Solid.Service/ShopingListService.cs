using project_Riki_Mittelman.Entities;
using Solid.Core.Repositories;
using Solid.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class ShopingListService : IShopingListService
    {
        private readonly IShopingListService _ShopingList;

        public ShopingListService(IShopingListService ShopingList)
        {
            _ShopingList = ShopingList;
        }
        public void Delete(int id)
        {
            _ShopingList?.GetAll().Remove(_ShopingList.GetAll()?.Find(c => c.Id == id));
        }

        public ShopingList Get(int id)
        {
            return _ShopingList.GetAll().Find(c => c.Id == id);
        }

        public List<ShopingList> GetAll(string? text = "")
        {
            return _ShopingList.GetAll().Where(u => u.Name.Contains(text)).ToList();
        }

        public void Put(int id, ShopingList product)
        {
            _ShopingList.GetAll().Find(c => c.Id == id).Id = product.Id;
            _ShopingList.GetAll().Find(c => c.Id == id).Name = product.Name;
        }

        public void Update(int id, ShopingList product)
        {
            _ShopingList?.GetAll().Add(product);
        }
    }
}
