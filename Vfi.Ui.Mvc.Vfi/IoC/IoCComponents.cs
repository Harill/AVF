
using Microsoft.Practices.Unity;
using Vfi.Client.Module.Authentication.Interfaces;
using Vfi.Client.Module.Authentication.Services;
using Vfi.Server.Core.CrossCutting.UnitOfWork;
using Vfi.Server.Core.Infrastructure.RepositoryImpl;
using Vfi.Server.Core.Infrastructure.RepositoryImpl.Inv;
using Vfi.Server.Core.Infrastructure.RepositoryImpl.Production;
using Vfi.Server.Core.Infrastructure.RepositoryImpl.Purchasing;
using Vfi.Server.Core.Infrastructure.RepositoryImpl.Sales;
using Vfi.Server.Core.Infrastructure.RepositoryImpl.System;
using Vfi.Server.Core.Repository;
using Vfi.Server.Core.Repository.Inv;
using Vfi.Server.Core.Repository.Production;
using Vfi.Server.Core.Repository.Purchasing;
using Vfi.Server.Core.Repository.Sales;
using Vfi.Server.Core.Repository.System;

namespace Vfi.Ui.Mvc.Vfi.IoC
{
    public static class IoCComponents
    {
        public static IUnityContainer ConfigureUnity(IUnityContainer container)
        {
            // instance UnityContainer
            //var container = new UnityContainer();

            #region System

            // Controller Activator 
            //container.RegisterType<IControllerActivator, CustomControllerActivator>();

            // FormAuthenticationService
            container.RegisterType<IFormAuthenticationService, FormAuthenticationService>();

            // FormAuthenticationService
            container.RegisterType<IDatabaseFactory, DatabaseFactory>(new HttpContextLifetimeManager<IDatabaseFactory>());

            // Context
            container.RegisterType<IRepositoryContext, RepositoryContext>(new HttpContextLifetimeManager<IRepositoryContext>());

            // UnitOfWork
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HttpContextLifetimeManager<IUnitOfWork>());

            #endregion

            #region User Function Permission Menu
            
            // Menu
            container.RegisterType<IMenuRepository, MenuRepository>(new HttpContextLifetimeManager<IMenuRepository>());
            container.RegisterType<IMenuService, MenuService>(new HttpContextLifetimeManager<IMenuService>());

            // User
            container.RegisterType<IUserRepository, UserRepository>(new HttpContextLifetimeManager<IUserRepository>());
            container.RegisterType<IUserService, UserService>(new HttpContextLifetimeManager<IUserService>());

            // Permission
            container.RegisterType<IPermissionRepository, PermissionRepository>(new HttpContextLifetimeManager<IPermissionRepository>());
            container.RegisterType<IPermissionService, PermissionService>(new HttpContextLifetimeManager<IPermissionService>());

            // Function
            container.RegisterType<IFunctionRepository, FunctionRepository>(new HttpContextLifetimeManager<IFunctionRepository>());
            container.RegisterType<IFunctionService, FunctionService>(new HttpContextLifetimeManager<IFunctionService>());

            //// Parameter
            //container.RegisterType<IParameterRepository, ParameterRepository>(new HttpContextLifetimeManager<IParameterRepository>());
            //container.RegisterType<IParameterService, ParameterService>(new HttpContextLifetimeManager<IParameterService>());
            
            #endregion
            
            #region Vfi Production

            // UnitMeasure
            container.RegisterType<IUnitMeasureRepository, UnitMeasureRepository>(new HttpContextLifetimeManager<IUnitMeasureRepository>());
            //container.RegisterType<IUnitMeasureService, UnitMeasureService>(new HttpContextLifetimeManager<IUnitMeasureService>());

            // Currency
            container.RegisterType<ICurrencyRepository, CurrencyRepository>(new HttpContextLifetimeManager<ICurrencyRepository>());
            //container.RegisterType<ICurrencyService, CurrencyService>(new HttpContextLifetimeManager<ICurrencyService>());

            // Material
            container.RegisterType<IMaterialRepository, MaterialRepository>(new HttpContextLifetimeManager<IMaterialRepository>());
            //container.RegisterType<IMaterialService, MaterialService>(new HttpContextLifetimeManager<IMaterialService>());
            // MaterialClassified
            container.RegisterType<IMaterialClassifiedRepository, MaterialClassifiedRepository>(new HttpContextLifetimeManager<IMaterialClassifiedRepository>());
            // MaterialType
            container.RegisterType<IMaterialTypeRepository, MaterialTypeRepository>(new HttpContextLifetimeManager<IMaterialTypeRepository>());

            // Product
            container.RegisterType<IProductRepository, ProductRepository>(new HttpContextLifetimeManager<IProductRepository>());
            //container.RegisterType<IProductService, ProductService>(new HttpContextLifetimeManager<IProductService>());

            // Parameter
            container.RegisterType<IParameterRepository, ParameterRepository>(new HttpContextLifetimeManager<IParameterRepository>());
            //container.RegisterType<IParameterService, ParameterService>(new HttpContextLifetimeManager<IParameterService>());

            #endregion

            #region Purchasing
            
            // Vendor
            container.RegisterType<IVendorRepository, VendorRepository>(new HttpContextLifetimeManager<IVendorRepository>());
            //container.RegisterType<IVendorService, VendorService>(new HttpContextLifetimeManager<IVendorService>());

            // ShipMethod
            container.RegisterType<IShipMethodRepository, ShipMethodRepository>(new HttpContextLifetimeManager<IShipMethodRepository>());
            //container.RegisterType<IShipMethodService, ShipMethodService>(new HttpContextLifetimeManager<IShipMethodService>());

            // PurchaseOrder
            container.RegisterType<IPurchaseOrderRepository, PurchaseOrderRepository>(new HttpContextLifetimeManager<IPurchaseOrderRepository>());
            //container.RegisterType<IPoService, PoService>(new HttpContextLifetimeManager<IPoService>());
            // PurchaseOrderDetail
            container.RegisterType<IPurchaseOrderDetailRepository, PurchaseOrderDetailRepository>(new HttpContextLifetimeManager<IPurchaseOrderDetailRepository>());

            #endregion

            #region Sales

            // Employee
            container.RegisterType<IEmployeeRepository, EmployeeRepository>(new HttpContextLifetimeManager<IEmployeeRepository>());
            //container.RegisterType<IEmployeeService, EmployeeService>(new HttpContextLifetimeManager<IEmployeeService>());

            // Customer
            container.RegisterType<ICustomerRepository, CustomerRepository>(new HttpContextLifetimeManager<ICustomerRepository>());
            //container.RegisterType<ICustomerService, CustomerService>(new HttpContextLifetimeManager<ICustomerService>());
            // CustomerType
            container.RegisterType<ICustomerTypeRepository, CustomerTypeRepository>(new HttpContextLifetimeManager<ICustomerTypeRepository>());

            // SalesOrder
            container.RegisterType<IOrderRepository, OrderRepository>(new  HttpContextLifetimeManager<IOrderRepository>());
            //container.RegisterType<IOrderService, OrderService>(new HttpContextLifetimeManager<IOrderService>());
            // SalesOrderDetail
            container.RegisterType<IOrderDetailRepository, OrderDetailRepository>(new HttpContextLifetimeManager<IOrderDetailRepository>());

            #endregion

            #region Inv

            // Warehouse
            container.RegisterType<IWarehouseRepository, WarehouseRepository>(new HttpContextLifetimeManager<IWarehouseRepository>());
            //container.RegisterType<IWarehouseService, WarehouseService>(new HttpContextLifetimeManager<IWarehouseService>());
            // WarehouseType
            container.RegisterType<IWarehouseTypeRepository, WarehouseTypeRepository>(new HttpContextLifetimeManager<IWarehouseTypeRepository>());

            // StockOrder
            container.RegisterType<IStockOrderRepository, StockOrderRepository>(new HttpContextLifetimeManager<IStockOrderRepository>());
            //container.RegisterType<IStockOrderService, StockOrderService>(new HttpContextLifetimeManager<IStockOrderService>());
            // StockOrderType
            container.RegisterType<IStockOrderTypeRepository, StockOrderTypeRepository>(new HttpContextLifetimeManager<IStockOrderTypeRepository>());
            // StockOrderDetail
            container.RegisterType<IStockOrderDetailRepository, StockOrderDetailRepository>(new HttpContextLifetimeManager<IStockOrderDetailRepository>());

            // Transaction
            container.RegisterType<ITransactionRepository, TransactionRepository>(new HttpContextLifetimeManager<ITransactionRepository>());
            //container.RegisterType<ITransactionService, TransactionService>(new HttpContextLifetimeManager<ITransactionService>());
            // TransactionDetail
            container.RegisterType<ITransactionDetailRepository, TransactionDetailRepository>(new HttpContextLifetimeManager<ITransactionDetailRepository>());

            // MaterialInventory
            container.RegisterType<IMaterialInventoryRepository, MaterialInventoryRepository>(new HttpContextLifetimeManager<IMaterialInventoryRepository>());
            //container.RegisterType<IMaterialInventoryService, MaterialInventoryService>(new HttpContextLifetimeManager<IMaterialInventoryService>());
            
            // MaterialInventoryPeriod
            container.RegisterType<IMaterialInventoryPeriodRepository, MaterialInventoryPeriodRepository>(new HttpContextLifetimeManager<IMaterialInventoryPeriodRepository>());
            //container.RegisterType<IMaterialInventoryPeriodService, MaterialInventoryPeriodService>(new HttpContextLifetimeManager<IMaterialInventoryPeriodService>());

            // ProductInventory
            container.RegisterType<IProductInventoryRepository, ProductInventoryRepository>(new HttpContextLifetimeManager<IProductInventoryRepository>());
            //container.RegisterType<IProductInventoryService, ProductInventoryService>(new HttpContextLifetimeManager<IProductInventoryService>());

            // MaterialInventoryPeriod
            container.RegisterType<IProductInventoryPeriodRepository, ProductInventoryPeriodRepository>(new HttpContextLifetimeManager<IProductInventoryPeriodRepository>());
            //container.RegisterType<IProductInventoryPeriodService, ProductInventoryPeriodService>(new HttpContextLifetimeManager<IProductInventoryPeriodService>());

            #endregion

            return container;
        }
    }
}