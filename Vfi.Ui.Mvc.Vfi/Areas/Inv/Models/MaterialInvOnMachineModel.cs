using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class MaterialInvOnMachineModel
    {
        public MaterialInvOnMachineModel()
        {
            Productivity = 0;
            ProductionRate = 0;
            ProductWeight = 0;
        }
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string DateString { get; set; }
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public string Lot { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public double ProductionRate { get; set; }
        public double Productivity { get; set; }
        public double ProductivityInShift {
            get {
                return MyUtilities.Product.GetProductionRateInFactoryShiftTime(Productivity) * ProductWeight;
            }
        }
        public double MaterialInShift
        {
            get
            {
                return MyUtilities.Product.GetMaterialRateInFactoryShiftTime(Productivity, ProductionRate);
            }
        }
        public double EarlyQuantity { get; set; }

        public double MidQuantity
        {
            get { return QuantityUse1 > 0 ? EarlyQuantity + AssignQuantity - QuantityUse1 : 0; }
        }
        public string MidQuantityString
        {
            get { return QuantityUse1 > 0 ? string.Format("{0:n2}", EarlyQuantity + AssignQuantity - QuantityUse1) : ""; }
        }

        public double LastQuantity { get; set; }
        public double LastCheckQuantity
        {
            get
            {
                return EarlyQuantity + AssignQuantity -
                       QuantityUse1 - QuantityUse2 - SendBack - Destroy - LastQuantity;
            }
        }
        public double AssignQuantity { get; set; }
        public int MaterialId { get; set; }
        public int MaterialInvId { get; set; }
        public double MaterialWeight { get; set; }
        public string MaterialName { get; set; }
        public double OutDiameter { get; set; }
        public double InDiameter { get; set; }
        public string Shape { get; set; }
        public string DiameterType { get; set; }
        public double Length { get; set; }
        public string LotNumber { get; set; }
        public string MaterialDesign { get; set; }
        public string VendorCode { get; set; }

        public double QuantityUse1 { get; set; }

        public string QuantityUse1String
        {
            get { return QuantityUse1 > 0 ? string.Format("{0:n2}", QuantityUse1) : ""; }
        }

        public double QuantityUse2 { get; set; }
        public string QuantityUse2String
        {
            get { return QuantityUse2 > 0 ? string.Format("{0:n2}", QuantityUse2) : ""; }
        }

        public string LastQuantityString
        {
            get { return QuantityUse1 + QuantityUse2 > 0 ? string.Format("{0:n2}", LastQuantity) : ""; }
        }

        public bool Show
        {
            get
            {
                return
                    Math.Round(EarlyQuantity + AssignQuantity + QuantityUse1 + QuantityUse2 + SendBack + Destroy, 2) > 0;
            }
        }

        public int BoxNumber { get; set; }
        public double WaitingNumber { get; set; }
        public string Note { get; set; }
        public string Shift { get; set; }

        public double ProductWeight { get; set; }
        public double SendBack { get; set; }
        public double Destroy { get; set; }

    }
}