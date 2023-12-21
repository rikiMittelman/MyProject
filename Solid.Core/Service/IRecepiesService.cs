using project_Riki_Mittelman.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Service
{
    public interface IRecepiesService
    {
        List<AviableProduct> GetAll(string? text = "");
        AviableProduct Get(int id);
        void Delete(int id);
        void Put(int id, AviableProduct product);
        void Update(int id,AviableProduct product);
    }
}
