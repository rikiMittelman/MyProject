using project_Riki_Mittelman.Entities;
using Solid.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class RecepiesService : IRecepiesService
    {
        private readonly IRecepiesService _Recepies;

        public RecepiesService(IRecepiesService Recepies)
        {
            _Recepies = Recepies;
        }
        public void Delete(int id)
        {
            _Recepies?.GetAll().Remove(_Recepies.GetAll()?.Find(c => c.Id == id));
        }

        public AviableProduct Get(int id)
        {
            return _Recepies.GetAll().Find(c => c.Id == id);
        }

        public List<AviableProduct> GetAll(string? text = "")
        {
            return _Recepies.GetAll().Where(u => u.Name.Contains(text)).ToList();
        }

        public void Put(int id, AviableProduct product)
        {
            _Recepies.GetAll().Find(c => c.Id == id).Id = product.Id;
            _Recepies.GetAll().Find(c => c.Id == id).Name = product.Name;
        }

        public void Update(int id, AviableProduct product)
        {
            _Recepies?.GetAll().Add(product);
        }
    }
}
