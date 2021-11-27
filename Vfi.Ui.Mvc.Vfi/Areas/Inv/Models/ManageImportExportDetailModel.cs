using System.ComponentModel.DataAnnotations;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class ManageImportExportDetailModel
    {
        public int? PlatingDetailId { get; set; }
        public int DetailId { get; set; }
        public int ProductId { get; set; }
        [DataType("_ProductEditTemplate")]
        public string ProductCode { get; set; }
        public double Number { get; set; }
        public double Weight { get; set; }
        public string Note { get; set; }
        public string Package { get; set; }
        public long TransactionId { get; set; }
        public int FormId { get; set; }
        public int FormType { get; set; }
        public bool IsInvManager { get; set; }
    }
}