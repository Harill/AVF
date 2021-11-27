using System;
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.System
{
    public class FunctionModel
    {
        public virtual long FunctionId { get; set; }

        public virtual int Creation { get; set; }

        public virtual int Modification { get; set; }

        public virtual int Deletion { get; set; }

        public virtual int Execution { get; set; }

        public virtual string FunctionCode { get; set; }

        public virtual string FunctionName { get; set; }

        public virtual string Description { get; set; }

        public virtual bool? Active { get; set; }

        public virtual DateTime ModifiedDate { get; set; }

        public virtual bool IsUserFunction { get; set; }

        public virtual IEnumerable<Permission> Permissions { get; set; }
    }

    public class WarehousePermissionModel {
        public int WarehousePermissionId { get; set; }
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public int UserId { get; set; }
        public bool Import { get; set; }
        public bool ImportReadOnly { get; set; }
        public bool Rotate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
