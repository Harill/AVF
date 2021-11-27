using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using Vfi.Server.Core.Repository.Factory;

namespace Vfi.Client.Module.Factory.Services
{
    public class MachineAppraisalService
    {
        private readonly IMachineAppraisalRepository _machineAppraisalRepository;
        [InjectionConstructor]
        public MachineAppraisalService(IMachineAppraisalRepository machineAppraisalRepository)
        {
            if (machineAppraisalRepository == null) throw new ArgumentNullException("machineAppraisalRepository");
            _machineAppraisalRepository = machineAppraisalRepository;
        }
    }
}
