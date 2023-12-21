using project_Riki_Mittelman.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class RecepiesRepository
    {
        private readonly DataContext _context;
        public RecepiesRepository(DataContext context)
        {
            _context = context;
        }
        public List<AviableProduct> GetAvailableProducts()
        {
            return _context.recepies.ToList();
        }
    }
}
