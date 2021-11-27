
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.Models.Inv;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class StockOrderDetailModel: StockOrderDetailDomainModel
    {
        [UIHint("_MaterialEditTemplate")]
        public override string MaterialCodeName
        {
            get
            {
                return base.MaterialCodeName;
            }
            set
            {
                base.MaterialCodeName = value;
            }
        }

        [UIHint("_ProductEditTemplate")]
        public override string ProductCodeName
        {
            get
            {
                return base.ProductCodeName;
            }
            set
            {
                base.ProductCodeName = value;
            }
        }

        [UIHint("_unitMeasureEditTemplate")]
        public override string UnitMeasureCodeName
        {
            get
            {
                return base.UnitMeasureCodeName;
            }
            set
            {
                base.UnitMeasureCodeName = value;
            }
        }
    }
}