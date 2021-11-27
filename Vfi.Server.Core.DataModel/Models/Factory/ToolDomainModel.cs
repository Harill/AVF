using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Factory
{
    public class ToolDomainModel: Tool
    {
        public virtual new int MachineId { get; set; }

        public virtual new int ToolId { get; set; }
        //public virtual new string TransactionCode { get; set; }
        //public virtual new string EoI { get; set; }
        //public virtual new string CreatedUser { get; set; }
        //public virtual new DateTime CreatedDate { get; set; }
        public virtual new byte Status { get; set; }
        public virtual new bool IsApprove { get; set; }
        public virtual new string Description { get; set; }

        [DisplayName("Kích hoạt")]
        public virtual new bool Active { get; set; }

        [DisplayName("Người thay đổi")]
        public virtual new string ModifiedUser { get; set; }

        [DisplayName("Ngày thay đổi")]
        public virtual new DateTime ModifiedDate { get; set; }
    }
}
