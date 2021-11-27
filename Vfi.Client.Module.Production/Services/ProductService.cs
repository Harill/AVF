using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using Vfi.Client.Module.Production.Interfaces;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Production;
using Vfi.Server.Core.Repository.Production;

namespace Vfi.Client.Module.Production.Services
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _productRepository;
        [InjectionConstructor]
        public ProductService(IProductRepository productRepository)
        {
            if (productRepository == null) throw new ArgumentNullException("productRepository");
            _productRepository = productRepository;
        }

        #region Product
        public IEnumerable<Product> GetAll()
        {
            try
            {
                return _productRepository.GetAll();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public IEnumerable<Product> GetAllProducts()
        {
            try
            {
                var list = _productRepository.GetAllAsNoTracking();
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public IEnumerable<ProductDomainModel> ConvertProductToModels(IEnumerable<Product> products)
        {
            try
            {
                return products.Select(
                    entity => new ProductDomainModel
                        {
                            ProductId = entity.ProductId,
                            ProductCode = entity.ProductCode,
                            ProductName = entity.ProductName,

                            CustomerId = entity.CustomerId,
                            CustomerCode = entity.Customer != null ? entity.Customer.CustomerCode : "",
                            CustomerName = entity.Customer != null ? entity.Customer.CustomerName : "",

                            MaterialId = entity.MaterialId,
                            MaterialCode = entity.Material != null ? entity.Material.MaterialCode : "",
                            MaterialName = entity.Material != null ? entity.Material.MaterialName : "",

                            DesignNo = entity.DesignNo,
                            Diameter = entity.Diameter ?? 0,
                            Length = entity.Length ?? 0,
                            Weight = entity.Weight ?? 0,

                            Active = entity.Active,
                            ForecastsQuality = entity.ForecastsQuality,
                            ModifiedUser = entity.ModifiedUser,
                            ModifiedDate = entity.ModifiedDate
                        });
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Product GetProductById(int productId)
        {
            try
            {
                return _productRepository.FindAsNoTracking(f => f.ProductId == productId).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public Product GetProductByCode(string productCode)
        {
            try
            {
                return
                    _productRepository.FindAsNoTracking(
                        f => f.ProductCode.Equals(productCode, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public IEnumerable<Product> GetProductsByMaterial(int materialId)
        {
            try
            {
                return _productRepository.FindAsNoTracking(f => f.MaterialId == materialId);
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<Product> GetProductsByCustomer(int customerId)
        {
            try
            {
                return _productRepository.FindAsNoTracking(f => f.CustomerId == customerId);
            }
            catch
            {
                return null;
            }
        }
        public bool CheckProductCodeByOwn(int productId, string productCode)
        {
            try
            {
                var result = _productRepository.Find(
                    f => f.ProductId != productId &&
                    f.ProductCode.Equals(productCode, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                return result != null;
            }
            catch (Exception)
            {
                throw new ArgumentNullException("productCode");
            }
        }

        public string CreateProduct(Product product)
        {
            try
            {
                var targetCreate = GetProductByCode(product.ProductCode);
                if (targetCreate == null)
                {
                    _productRepository.Add(product);
                    return "1";
                }
                return "0";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateProduct(Product product)
        {
            try
            {
                var targetUpdate =
                    _productRepository.Find(f => f.ProductId == product.ProductId).FirstOrDefault();
                if (targetUpdate != null)
                {
                    targetUpdate.CustomerId = product.CustomerId;
                    targetUpdate.MaterialId = product.MaterialId;
                    targetUpdate.ProductCode = product.ProductCode ?? targetUpdate.ProductCode;
                    targetUpdate.ProductName = product.ProductName ?? targetUpdate.ProductName;

                    targetUpdate.DesignNo = product.DesignNo ?? targetUpdate.DesignNo;
                    targetUpdate.Diameter = product.Diameter ?? targetUpdate.Diameter;
                    targetUpdate.Length = product.Length ?? targetUpdate.Length;
                    targetUpdate.Weight = product.Weight ?? targetUpdate.Weight;
                    targetUpdate.ForecastsQuality = product.ForecastsQuality ?? targetUpdate.ForecastsQuality;

                    targetUpdate.Active = product.Active;
                    targetUpdate.ModifiedUser = product.ModifiedUser ?? targetUpdate.ModifiedUser;
                    targetUpdate.ModifiedDate = DateTime.Now;

                    return "1";
                }
                return "0";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        #endregion
    }
}
