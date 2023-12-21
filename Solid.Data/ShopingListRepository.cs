using project_Riki_Mittelman.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class ShopingListRepository
    {
        private readonly DataContext _context;
        public ShopingListRepository(DataContext context)
        {
            _context = context;
        }
        public List<ShopingList> GetAvailableProducts()
        {
            return _context.shopingLists.ToList();
        }
    }
}
