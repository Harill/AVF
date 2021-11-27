using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Sales.Models
{
    public class OrderNoteModel
    {
        public int NoteId { get; set; }
        public string NoteNumber { get; set; }
        public string TypeName { get; set; }
        public string StatusName { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime CreatedDate { get; set; }

        public string InvoiceNumber { get; set; }
        public double TotalNumber { get; set; }

        public string OrderNumber { get; set; }
        public string CustomerCode { get; set; }
    }
}