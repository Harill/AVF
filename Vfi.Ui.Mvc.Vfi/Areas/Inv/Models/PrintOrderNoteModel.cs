using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class PrintOrderNoteModel
    {
        //export form
        public string DateCreateString { get; set; }
        public string NoteNumber { get; set; }
        public string CustomerCode { get; set; } 
        public double Quality { get; set; }
        public double Weight { get; set; }
        public string Note { get; set; }
        public int NoteId { get; set; }
        public string ProductCode { get; set; }

        public string ModifiedDateString { get; set; }
        public string StatusName { get; set; }

        public string ModifiedUser { get; set; }

        public string OrderNumber { get; set; }
        public string EmployeeName { get; set; }
        public string CustomerCodeName { get; set; }


        public string Title { get; set; }
    }
}