using project_Riki_Mittelman.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Service
{
    public interface IAvailableProductsService
    {
        List<AvaibleProducts> GetAll(string? text = "");
        AvaibleProducts Get(int id);
        void Delete(int id);
        void Put(int id, AvaibleProducts product);
        void Update(int id,AvaibleProducts product);
    }
  
}
