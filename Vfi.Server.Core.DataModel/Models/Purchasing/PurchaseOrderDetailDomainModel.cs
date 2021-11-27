using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Purchasing
{
    public class PurchaseOrderDetailDomainModel
    {
        public long PurchaseOrderDetailId { get; set; }
        public long PurchaseOrderId { get; set; }

        public virtual string Name { get; set; }
        public virtual string Code { get; set; }
        public virtual string CodeName { get { return Code + " -- " + Name; } set { Code = value; } }
        public string CurrencyCode { get; set; }
        public string VendorCodeName
        {
            get { return VendorCode + "-" + VendorName; }
        }

        public string VendorCode { get; set; }
        public string VendorName { get; set; }
        public string VendoId { get; set; }

        [DisplayName("Số đơn")]
        public virtual int PurchaseOrderRevisionNumber { get; set; }

        // material classified
        public virtual  int MaterialClassifiedId { get; set; }
        [DisplayName("Phân loại")]
        [UIHint("_MaterialClassifiedEditTemplate")]
        public virtual string MaterialClassifiedName { get; set; }
        // material classified

        // material type
        public virtual  int MaterialTypeId { get; set; }
        [DisplayName("Loại nguyên liệu")]
        [UIHint("_MaterialTypeEditTemplate")]
        public virtual string MaterialTypeName { get; set; }

        [DisplayName("Đơn vị tính")]
        [DataType("_PlatingUnitTemplate")]
        public virtual string Unit { get; set; }
        
        // material type
        
        // material
        public virtual  int MaterialId { get; set; }

        [DisplayName("Tên nguyên liệu")]
        public virtual string MaterialName { get; set; }
        [DisplayName("Mã nguyên liệu")]
        public virtual string MaterialCode { get; set; }

        //[Required(ErrorMessage = "*")]
        [DisplayName("Nguyên liệu")]
        [UIHint("_MaterialEditByVendorTemplate")]
        public virtual string MaterialCodeName { get { return MaterialCode + " -- " + MaterialName; } set { MaterialCode = value; } }

        // Tool
        public virtual  int ToolId { get; set; }

        [DisplayName("Tên nguyên liệu")]
        public virtual string ToolName { get; set; }
        [DisplayName("Mã nguyên liệu")]
        public virtual string ToolCode { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Nguyên liệu")]
        [UIHint("_ToolEditTemplate")]
        public virtual string ToolCodeName { get { return ToolCode + " -- " + ToolName; } set { ToolCode = value; } }

        // Tool
        public virtual  int FuelId { get; set; }

        [DisplayName("Tên nguyên liệu")]
        public virtual string FuelName { get; set; }
        [DisplayName("Mã nguyên liệu")]
        public virtual string FuelCode { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Nguyên liệu")]
        [UIHint("_FuelEditTemplate")]
        public virtual string FuelCodeName { get { return FuelCode + " -- " + FuelName; } set { FuelCode = value; } }

        // material

        [Required(ErrorMessage = "*")]
        [DataType("NumberAsInt")]
        [DisplayName("Số lượng đặt")]
        public virtual  int OrderQty { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Đơn giá")]
        [DataType("Number2")]
        public virtual  double UnitPrice { get; set; }


        public string UnitPriceString
        {
            get
            {
                return CurrencyCode.Equals("VND")
                           ? string.Format("{0:n0}", UnitPrice)
                           : string.Format("{0:n4}", UnitPrice);
            }
        }
        [DisplayName("Thành tiền")]
        [DataType("Number2")]
        public virtual  double LineTotal { get; set; }

        public string LineTotalString
        {
            get
            {
                return CurrencyCode.Equals("VND")
                           ? string.Format("{0:n0}", LineTotal)
                           : string.Format("{0:n2}", LineTotal);
            }
        }
        [DisplayName("Đã nhận")]
        [DataType("Number2")]
        public virtual  double ReceivedQty { get; set; }

        [DisplayName("Trả lại")]
        [DataType("Number2")]
        public virtual double RejectedQty { get; set; }
        [DataType("Number2")]
        public virtual double Quantity { get; set; }

        public double TotalQtyKg { get; set; }

        [DisplayName("Còn lại")]
        [DataType("Number2")]
        public virtual double RequireQty { get; set; }

        [DisplayName("Số lượng tồn")]
        [DataType("Number2")]
        public virtual  double StockedQty { get; set; }

        [DisplayName("Ngày nhận hàng")]
        [UIHint("_DateTemplate")]
        public virtual  DateTime? DueDate { get; set; }

        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }
    }
}
