using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Areas.Purchasing.Models;
using Vfi.Ui.Mvc.Vfi.Models.Production;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class MaterialInvShelfDiagramModel {
        public MaterialInvShelfDiagramModel() {
            Details = new List<MaterialInvShelfDiagramDetailModel>();
        }
        public string ShelfName { get; set; }
        public string ColumnName { get; set; }
        public string ColumnCode { get { return ColumnName + AdditionName; } }
        public string RowName { get; set; }
        public string AdditionName { get; set; }
        public string RowCode { get { return RowName + ShelfName; } }
        public string DrawerCode { get { return RowName + ShelfName + "-" + ColumnName + AdditionName; } }
        public List<MaterialInvShelfDiagramDetailModel> Details { get; set; }
    }

    public class MaterialInvShelfDiagramDetailModel {
        public MaterialInvShelfDiagramDetailModel() {
            Quantity = 0;
            ImportQuantity = 0;
            MaterialTypeId = 0;
            VendorId = 0;
            MaterialStateCode = "";
        }
        public DateTime OnDate { get; set; }
        
        public int ReferenceId { get; set; }
        public string ReferenceCode { get; set; }
        public int ReferenceInvId { get; set; }
        public string ReferenceInvCode { get; set; }
        public string ReferenceFullCode { get { return ReferenceCode + ReferenceInvCode + LotNumber; } }
        public string ReferenceHashCode { get { return MyUtilities.MySystem.Base64Encode(ReferenceFullCode); } }
        public string LotNumber { get; set; }
        public string OwnerName { get; set; }
        public double UnitWeight { get; set; }
        public double Quantity { get; set; }
        public string QuantityStr { get { return string.Format("{0:n2}", Quantity); } }
        public string Unit { get; set; }
        public string InventoryStateColor { get { return Quantity > 0 || ReferenceInvId == 0 ? "" : "C0C0C0"; } }

        public string ImportDateStr { get; set; }
        public double ImportQuantity { get; set; }
        public string ImportQuantityStr { get { return string.Format("{0:n2}", ImportQuantity); } }

        public int MaterialTypeId { get; set; }
        public string MaterialTypeColor { get; set; }
        public int VendorId { get; set; }
        public string VendorName { get; set; }

        public string MaterialStateCode { get; set; }
        public string MaterialStateColor { get; set; }
        public string ShelfBarcode { get; set; }
    }

    public class MaterialInvShelfDiagramColumnModel {
        public MaterialInvShelfDiagramColumnModel() {
            Drawers = new List<MaterialInvShelfDiagramModel>();
        }
        public string ColumnName { get; set; }
        public List<MaterialInvShelfDiagramModel> Drawers { get; set; }
    }

    public class MaterialInvShelfDiagramGroupModel {
        public MaterialInvShelfDiagramGroupModel() {
            Columns = new List<MaterialInvShelfDiagramColumnModel>();
            Drawers = new List<MaterialInvShelfDiagramModel>();
        }
        public string ShelfName { get; set; }
        public int RowCount { get; set; }
        public int ColumnCount { get; set; }
        public List<MaterialInvShelfDiagramColumnModel> Columns { get; set; }
        public List<MaterialInvShelfDiagramModel> Drawers { get; set; }
    }

    public class MaterialInvStateModel {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public double YearOld { get; set; }
        public double Count { get; set; }
    }

    public class MaterialInvShelfDiagramViewModel {
        public MaterialInvShelfDiagramViewModel() {
            Groups = new List<MaterialInvShelfDiagramGroupModel>();
            Types = new List<MaterialTypeModel>();
            Vendors = new List<VendorModel>();
            States = new List<MaterialInvStateModel>();
            NotOnShelf = new MaterialInvShelfDiagramModel();
        }
        public List<MaterialInvShelfDiagramGroupModel> Groups { get; set; }
        public MaterialInvShelfDiagramModel NotOnShelf { get; set; }
        public List<MaterialTypeModel> Types { get; set; }
        public List<VendorModel> Vendors { get; set; }
        public List<MaterialInvStateModel> States { get; set; }
    }
}