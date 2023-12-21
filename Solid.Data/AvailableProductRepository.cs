using project_Riki_Mittelman.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class AvailableProductRepository
    {
        private readonly DataContext _context;
        public AvailableProductRepository(DataContext context)
        {
            _context = context;
        }
        public List<AvaibleProducts> GetAvailableProducts()
        {
            return _context.avaibleProducts.ToList();
        }
    }
}
