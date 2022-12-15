
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.Models.Production;

namespace Vfi.Ui.Mvc.Vfi.Models.Production
{
    public class MaterialTypeModel: MaterialTypeDomainModel {
        [DataType("ColorTemplate")]
        public string DiagramColor { get; set; }

        public int Count { get; set; }
        [DataType("Number2Digit")]
        public double Factor { get; set; }
        [DataType("Number2Digit")]
        public double ProductionFactor { get; set; }
        [DataType("Number4Digit")]
        public double TaxFactor { get; set; }
    }
}