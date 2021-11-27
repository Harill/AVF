using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    [NotMapped]
    public class MaterialUseInShiftDetailModel
    {
        public int DetailId { get; set; }
        public int MaterialInvId { get; set; }
        public int FormId { get; set; }
        public int MachineId { get; set; }
        public string Lot { get; set; }
        public string Note { get; set; }
        public string MachineName { get; set; }
        public string ProductCode { get; set; }
        public string MaterialCode { get; set; }
        [DataType("Number")]
        public double EarlyQuantity { get; set; }
        [DataType("Number")]
        public double LastQuantity { get; set; }
        [DataType("Number")]
        public double AssignQuantity { get; set; }
        public string MaterialName { get; set; }
        public string LotNumber { get; set; }
        public string MaterialDesign { get; set; }
        public double Length { get; set; }
        [DataType("Number")]
        public double Quantity { get; set; }
        [DataType("Number")]
        public double EditQuantity { get; set; }
        [DataType("Number")]
        public double Quantity2 { get; set; }
        [DataType("Number")]
        public double EditQuantity2 { get; set; }
        [DataType("NumberAsShort")]
        public int BoxNumber { get; set; }
        [DataType("Number")]
        public double WaitingNumber { get; set; }
        public int ToMachineId { get; set; }
        [DataType("_MachineEditTemplate")]
        public string ToMachine { get; set; }

        public bool IsDestroy { get; set; }

        public bool CanReUpdate { get; set; }
    }
}