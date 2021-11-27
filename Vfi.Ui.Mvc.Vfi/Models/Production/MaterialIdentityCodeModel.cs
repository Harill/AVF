using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models.Production
{
    public class MaterialIdentityCodeModel
    {
        public List<int> ListTypeId { get; set; }
        public string IdentityCode { get; set; }
        public string MaterialTypeShortName { get; set; }
        public string MaterialTypeName { get; set; }
    }

    public static class MaterialIdentityCode
    {
        public static List<MaterialIdentityCodeModel> GetMaterialIdentityCodes(int materialTypeId) {
            var _list = new List<MaterialIdentityCodeModel>();
            using (var vfi = new tammaContext()) {
                var materialTypes = (from mt in vfi.MaterialTypes
                                     where mt.MaterialClassifiedId == 1 && mt.Active &&
                                     (materialTypeId == 0 || mt.MaterialTypeId == materialTypeId)
                                     select new {
                                         mt.MaterialTypeId,
                                         mt.IdentityCode,
                                         mt.MaterialTypeName,
                                     }).ToList();
                foreach (var materialType in materialTypes) {
                    var entity =
                        _list.FirstOrDefault(
                            mt =>
                            mt.IdentityCode.Equals(materialType.IdentityCode));
                    if (entity == null) {
                        entity = new MaterialIdentityCodeModel {
                            ListTypeId = new List<int>(),
                            IdentityCode = materialType.IdentityCode,
                            MaterialTypeShortName = materialType.MaterialTypeName,
                            MaterialTypeName = materialType.IdentityCode + ": " + materialType.MaterialTypeName,
                        };
                        entity.ListTypeId.Add(materialType.MaterialTypeId);
                        _list.Add(entity);
                    }
                    else {
                        entity.ListTypeId.Add(materialType.MaterialTypeId);
                        entity.MaterialTypeName += "-" + materialType.MaterialTypeName;
                        entity.MaterialTypeShortName += "-" + materialType.MaterialTypeName;
                    }
                }
            }
            return _list;
        }

        //public static List<int> GetMaterialIdentityType()
        //{
        //    return new List<int> { 1, 2, 3 };
        //}
        //public static  string GetMaterialIdentityTypeName(int type)
        //{
        //    switch (type)
        //    {
        //        case 1:
        //            return "Khối";
        //        case 2:
        //            return "Vụn";
        //        case 3:
        //            return "Phế phẩm";
        //        default:
        //            return "";
        //    }
        //} 
    }
}