
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Production;

namespace Vfi.Client.Module.Production.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetAllProducts();
        IEnumerable<ProductDomainModel> ConvertProductToModels(IEnumerable<Product> products);
        Product GetProductById(int productId);
        Product GetProductByCode(string productCode);
        IEnumerable<Product> GetProductsByMaterial(int materialId);
        IEnumerable<Product> GetProductsByCustomer(int customerId);
        bool CheckProductCodeByOwn(int productId, string productCode);

        string CreateProduct(Product product);
        string UpdateProduct(Product product);
    }
}
