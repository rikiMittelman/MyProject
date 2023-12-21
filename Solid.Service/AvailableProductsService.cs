using project_Riki_Mittelman.Entities;
using Solid.Core.Service;

namespace Solid.Service
{
    public class AvailableProductsService : IAvailableProductsService
    {
        private readonly IAvailableProductsService _AvailableProductService;

        public AvailableProductsService(IAvailableProductsService AvailableProduct)
        {
            _AvailableProductService = AvailableProduct;
        }

        public void Delete(int id)
        {
            _AvailableProductService?.GetAll().Remove(_AvailableProductService.GetAll()?.Find(c => c.Id == id));
        }

        public AvaibleProducts Get(int id)
        {
            return _AvailableProductService.GetAll().Find(c=>c.Id==id);
        }

        public List<AvaibleProducts> GetAll(string? text = "")
        {
            return _AvailableProductService.GetAll().Where(u=>u.Name.Contains(text)).ToList();
        }

        public void Put(int id, AvaibleProducts product)
        {
            _AvailableProductService.GetAll().Find(c=>c.Id==id).Id=product.Id;
            _AvailableProductService.GetAll().Find(c=>c.Id==id).Name=product.Name;
        }

        public void Update(int id, AvaibleProducts product)
        {
            _AvailableProductService?.GetAll().Add(product);
        }
    }
}