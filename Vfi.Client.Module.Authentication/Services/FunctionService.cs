
using System.Collections.Generic;
using Microsoft.Practices.Unity;
using Vfi.Client.Module.Authentication.Interfaces;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.System;

namespace Vfi.Client.Module.Authentication.Services
{
    public class FunctionService : IFunctionService
    {
        private readonly IFunctionRepository _functionRepository;

        [InjectionConstructor]
        public FunctionService(IFunctionRepository functionRepository)
        {
            if(_functionRepository == null) _functionRepository = functionRepository;
        }

        public IEnumerable<Function> GetAllFunction()
        {
            //return _functionRepository.GetAllFunction();
            return _functionRepository.GetAll();
        }
    }
}
