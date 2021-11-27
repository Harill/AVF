
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Production;

namespace Vfi.Client.Module.Production.Interfaces
{
    public interface IMaterialService
    {
        #region Material Classified

        IEnumerable<MaterialClassified> GetAllMaterialClassifieds();
        IEnumerable<MaterialClassifiedDomainModel> GetAllMaterialClassifiedDomainModels();
        MaterialClassified GetMaterialClassifiedById(int materialClassifiedId);

        string CreateMaterialClassified(MaterialClassified materialClassified);
        string UpdateMaterialClassified(MaterialClassified materialClassified);

        #endregion

        #region Material Type

        IEnumerable<MaterialType> GetAllMaterialTypes();
        IEnumerable<MaterialTypeDomainModel> GetAllMaterialTypeDomainModels();
        MaterialType GetMaterialTypeById(int materialTypeId);

        string CreateMaterialType(MaterialType materialType);
        string UpdateMaterialType(MaterialType materialType);

        #endregion

        #region Material

        IEnumerable<Material> GetAllMaterials();
        IEnumerable<MaterialDomainModel> GetAllMaterialDomainModels();
        IEnumerable<Material> GetMaterialsByMaterialType(int materialTypeId);
        Material GetMaterialById(int materialId);
        Material GetMaterialByCode(string materialCode);
        bool CheckMaterialCodeByOwn(int materialId, string materialCode);

        string CreateMaterial(Material material);
        string UpdateMaterial(Material material);

        #endregion
    }
}
