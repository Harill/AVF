
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.Models.Production;

namespace Vfi.Ui.Mvc.Vfi.Models.Production
{
    public class MaterialTypeModel: MaterialTypeDomainModel {
        [DataType("ColorTemplate")]
        public string DiagramColor { get; set; }

        public int Count { get; set; }
    }
}