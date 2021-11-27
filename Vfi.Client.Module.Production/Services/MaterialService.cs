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
    public class MaterialService: IMaterialService
    {
        private readonly IMaterialClassifiedRepository _materialClassifiedRepository;
        private readonly IMaterialTypeRepository _materialTypeRepository;
        private readonly IMaterialRepository _materialRepository;
        [InjectionConstructor]
        public MaterialService(IMaterialClassifiedRepository materialClassifiedRepository,
            IMaterialTypeRepository materialTypeRepository,
            IMaterialRepository materialRepository)
        {
            if (materialClassifiedRepository == null) throw new ArgumentNullException("materialClassifiedRepository");
            if (materialTypeRepository == null) throw new ArgumentNullException("materialTypeRepository");
            if (materialRepository == null) throw new ArgumentNullException("materialRepository");

            _materialClassifiedRepository = materialClassifiedRepository;
            _materialTypeRepository = materialTypeRepository;
            _materialRepository = materialRepository;
        }

        #region Material Classified

        public IEnumerable<MaterialClassified> GetAllMaterialClassifieds()
        {
            try
            {
                return _materialClassifiedRepository.GetAllAsNoTracking();
            }
            catch(Exception)
            {
                return null;
            }
        }
        public IEnumerable<MaterialClassifiedDomainModel> GetAllMaterialClassifiedDomainModels()
        {
            try
            {
                return GetAllMaterialClassifieds().Select(
                    entity => new MaterialClassifiedDomainModel
                                  {
                                      MaterialClassifiedId = entity.MaterialClassifiedId,
                                      MaterialClassifiedName = entity.MaterialClassifiedName,
                                      Active = entity.Active,
                                      ModifiedUser = entity.ModifiedUser,
                                      ModifiedDate = entity.ModifiedDate
                                  });
            }
            catch(Exception)
            {
                return null;
            }
        }
        public MaterialClassified GetMaterialClassifiedById(int materialClassifiedId)
        {
            try
            {
                return
                    _materialClassifiedRepository.FindAsNoTracking(f => f.MaterialClassifiedId == materialClassifiedId)
                        .FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string CreateMaterialClassified(MaterialClassified materialClassified)
        {
            try
            {
                var targetCreate = 
                    _materialClassifiedRepository.FindAsNoTracking(
                        f => f.MaterialClassifiedId == materialClassified.MaterialClassifiedId).FirstOrDefault();
                if(targetCreate == null)
                {
                    _materialClassifiedRepository.Add(materialClassified);
                    return "1";
                }
                return "0";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateMaterialClassified(MaterialClassified materialClassified)
        {
            try
            {
                var targetUpdate =
                    _materialClassifiedRepository.Find(
                        f => f.MaterialClassifiedId == materialClassified.MaterialClassifiedId).FirstOrDefault();
                if (targetUpdate != null)
                {
                    targetUpdate.MaterialClassifiedName = materialClassified.MaterialClassifiedName ??
                                                          targetUpdate.MaterialClassifiedName;
                    targetUpdate.Active = materialClassified.Active;
                    targetUpdate.ModifiedUser = materialClassified.ModifiedUser ?? targetUpdate.ModifiedUser;
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

        #region Material Type

        public IEnumerable<MaterialType> GetAllMaterialTypes()
        {
            try
            {
                return _materialTypeRepository.FindAsNoTracking(f=>f.MaterialClassified.Active);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public IEnumerable<MaterialTypeDomainModel> GetAllMaterialTypeDomainModels()
        {
            try
            {
                return GetAllMaterialTypes().Select(
                    entity => new MaterialTypeDomainModel
                    {
                        MaterialTypeId = entity.MaterialTypeId,
                        MaterialClassifiedId = entity.MaterialClassifiedId,
                        MaterialClassifiedName = entity.MaterialClassified != null
                                                ? entity.MaterialClassified.MaterialClassifiedName : "",
                        MaterialTypeName = entity.MaterialTypeName,
                        Active = entity.Active,
                        ModifiedUser = entity.ModifiedUser,
                        ModifiedDate = entity.ModifiedDate
                    });
            }
            catch (Exception)
            {
                return null;
            }
        }
        public MaterialType GetMaterialTypeById(int materialTypeId)
        {
            try
            {
                return
                    _materialTypeRepository.FindAsNoTracking(f => f.MaterialTypeId == materialTypeId)
                        .FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string CreateMaterialType(MaterialType materialType)
        {
            try
            {
                var targetCreate =
                    _materialTypeRepository.FindAsNoTracking(
                        f => f.MaterialTypeId == materialType.MaterialTypeId).FirstOrDefault();
                if (targetCreate == null)
                {
                    _materialTypeRepository.Add(materialType);
                    return "1";
                }
                return "0";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateMaterialType(MaterialType materialType)
        {
            try
            {
                var targetUpdate =
                    _materialTypeRepository.Find(
                        f => f.MaterialTypeId == materialType.MaterialTypeId).FirstOrDefault();
                if (targetUpdate != null)
                {
                    targetUpdate.MaterialClassifiedId = materialType.MaterialClassifiedId;
                    targetUpdate.MaterialTypeName = materialType.MaterialTypeName ??
                                                          targetUpdate.MaterialTypeName;
                    targetUpdate.Active = materialType.Active;
                    targetUpdate.ModifiedUser = materialType.ModifiedUser ?? targetUpdate.ModifiedUser;
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

        #region Material

        public IEnumerable<Material> GetAllMaterials()
        {
            try
            {
                return _materialRepository.FindAsNoTracking(f => f.MaterialType.Active);
            }
            catch(Exception)
            {
                return null;
            }
        }
        public IEnumerable<MaterialDomainModel> GetAllMaterialDomainModels()
        {
            try
            {
                return GetAllMaterials().Select(
                    entity => new MaterialDomainModel
                                  {
                                      MaterialId = entity.MaterialId,
                                      MaterialCode = entity.MaterialCode,
                                      MaterialName = entity.MaterialName,

                                      MaterialTypeId = entity.MaterialTypeId,
                                      MaterialTypeName = entity.MaterialType != null ? entity.MaterialType.MaterialTypeName : "",

                                      Diameter = entity.Diameter,
                                      DiameterType = entity.DiameterType,
                                      Length = entity.Length ?? 0,
                                      Weight = entity.Weight ?? 0,

                                      Active = entity.Active,
                                      ModifiedUser = entity.ModifiedUser,
                                      ModifiedDate = entity.ModifiedDate
                                  });
            }
            catch(Exception)
            {
                return null;
            }
        }
        public IEnumerable<Material> GetMaterialsByMaterialType(int materialTypeId)
        {
            try
            {
                return _materialRepository.FindAsNoTracking(f => f.MaterialTypeId == materialTypeId);
            }
            catch
            {
                return null;
            }
        }
        public Material GetMaterialById(int materialId)
        {
            try
            {
                return _materialRepository.FindAsNoTracking(f => f.MaterialId == materialId).FirstOrDefault();
            }
            catch(Exception)
            {
                return null;
            }
        }
        public Material GetMaterialByCode(string materialCode)
        {
            try
            {
                return
                    _materialRepository.FindAsNoTracking(
                        f => f.MaterialCode.Equals(materialCode, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public bool CheckMaterialCodeByOwn(int materialId, string materialCode)
        {
            try
            {
                var result = _materialRepository.Find(
                    f => f.MaterialId != materialId &&
                    f.MaterialCode.Equals(materialCode, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
                return result != null;
            }
            catch (Exception)
            {
                throw new ArgumentNullException("materialCode");
            }
        }

        public string CreateMaterial(Material material)
        {
            try
            {
                var targetCreate = GetMaterialByCode(material.MaterialCode);
                if(targetCreate == null)
                {
                    _materialRepository.Add(material);
                    return "1";
                }
                return "0";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateMaterial(Material material)
        {
            try
            {
                var targetUpdate =
                    _materialRepository.Find(f => f.MaterialId == material.MaterialId).FirstOrDefault();
                if (targetUpdate != null)
                {
                    targetUpdate.MaterialTypeId = material.MaterialTypeId;
                    targetUpdate.MaterialCode = material.MaterialCode ?? targetUpdate.MaterialCode;
                    targetUpdate.MaterialName = material.MaterialName ?? targetUpdate.MaterialName;

                    targetUpdate.Diameter = material.Diameter ?? targetUpdate.Diameter;
                    targetUpdate.DiameterType = material.DiameterType ?? targetUpdate.DiameterType;
                    targetUpdate.Length = material.Length ?? targetUpdate.Length;
                    targetUpdate.Weight = material.Weight ?? targetUpdate.Weight;

                    targetUpdate.Active = material.Active;
                    targetUpdate.ModifiedUser = material.ModifiedUser ?? targetUpdate.ModifiedUser;
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