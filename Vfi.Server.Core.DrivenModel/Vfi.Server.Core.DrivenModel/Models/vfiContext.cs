using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Vfi.Server.Core.DrivenModel.Models.Mapping;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class vfiContext : DbContext
    {
        static vfiContext()
        {
            Database.SetInitializer<vfiContext>(null);
        }

        public vfiContext()
            : base("Name=vfiContext")
        {
        }

        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Machine> Machines { get; set; }
        public DbSet<MachineAppraisal> MachineAppraisals { get; set; }
        public DbSet<Tool> Tools { get; set; }
        public DbSet<ToolDetail> ToolDetails { get; set; }
        public DbSet<ToolOrder> ToolOrders { get; set; }
        public DbSet<ToolPeriod> ToolPeriods { get; set; }
        public DbSet<MaterialInventory> MaterialInventories { get; set; }
        public DbSet<MaterialInventoryPeriod> MaterialInventoryPeriods { get; set; }
        public DbSet<ProductInventory> ProductInventories { get; set; }
        public DbSet<ProductInventoryPeriod> ProductInventoryPeriods { get; set; }
        public DbSet<StockOrder> StockOrders { get; set; }
        public DbSet<StockOrderDetail> StockOrderDetails { get; set; }
        public DbSet<StockOrderType> StockOrderTypes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionDetail> TransactionDetails { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<WarehouseType> WarehouseTypes { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<MaterialClassified> MaterialClassifieds { get; set; }
        public DbSet<MaterialType> MaterialTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<UnitMeasure> UnitMeasures { get; set; }
        public DbSet<PriceListMaterial> PriceListMaterials { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        public DbSet<ScrapReason> ScrapReasons { get; set; }
        public DbSet<ShipMethod> ShipMethods { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }
        public DbSet<WorkOrderRouting> WorkOrderRoutings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        public DbSet<TimeLine> TimeLines { get; set; }
        public DbSet<Function> Functions { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserWorkGroup> UserWorkGroups { get; set; }
        public DbSet<WorkGroup> WorkGroups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new MachineMap());
            modelBuilder.Configurations.Add(new MachineAppraisalMap());
            modelBuilder.Configurations.Add(new ToolMap());
            modelBuilder.Configurations.Add(new ToolDetailMap());
            modelBuilder.Configurations.Add(new ToolOrderMap());
            modelBuilder.Configurations.Add(new ToolPeriodMap());
            modelBuilder.Configurations.Add(new MaterialInventoryMap());
            modelBuilder.Configurations.Add(new MaterialInventoryPeriodMap());
            modelBuilder.Configurations.Add(new ProductInventoryMap());
            modelBuilder.Configurations.Add(new ProductInventoryPeriodMap());
            modelBuilder.Configurations.Add(new StockOrderMap());
            modelBuilder.Configurations.Add(new StockOrderDetailMap());
            modelBuilder.Configurations.Add(new StockOrderTypeMap());
            modelBuilder.Configurations.Add(new TransactionMap());
            modelBuilder.Configurations.Add(new TransactionDetailMap());
            modelBuilder.Configurations.Add(new WarehouseMap());
            modelBuilder.Configurations.Add(new WarehouseTypeMap());
            modelBuilder.Configurations.Add(new CurrencyMap());
            modelBuilder.Configurations.Add(new MaterialMap());
            modelBuilder.Configurations.Add(new MaterialClassifiedMap());
            modelBuilder.Configurations.Add(new MaterialTypeMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new UnitMeasureMap());
            modelBuilder.Configurations.Add(new PriceListMaterialMap());
            modelBuilder.Configurations.Add(new PurchaseOrderMap());
            modelBuilder.Configurations.Add(new PurchaseOrderDetailMap());
            modelBuilder.Configurations.Add(new ScrapReasonMap());
            modelBuilder.Configurations.Add(new ShipMethodMap());
            modelBuilder.Configurations.Add(new VendorMap());
            modelBuilder.Configurations.Add(new WorkOrderMap());
            modelBuilder.Configurations.Add(new WorkOrderRoutingMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new CustomerTypeMap());
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new InvoiceMap());
            modelBuilder.Configurations.Add(new InvoiceDetailMap());
            modelBuilder.Configurations.Add(new SalesOrderMap());
            modelBuilder.Configurations.Add(new SalesOrderDetailMap());
            modelBuilder.Configurations.Add(new TimeLineMap());
            modelBuilder.Configurations.Add(new FunctionMap());
            modelBuilder.Configurations.Add(new MenuMap());
            modelBuilder.Configurations.Add(new ParameterMap());
            modelBuilder.Configurations.Add(new PermissionMap());
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserWorkGroupMap());
            modelBuilder.Configurations.Add(new WorkGroupMap());
        }
    }
}
