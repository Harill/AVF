
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Factory;

namespace Vfi.Client.Module.Factory.Interfaces
{
    public interface IMachineService
    {
        IEnumerable<Machine> GetAllMachines();
        IEnumerable<MachineDomainModel> GetAllMachineDomainModels();
        Machine GetMachineById(int machineId);

        string CreateMachine(Machine machine);
        string UpdateMachine(Machine machine);
    }
}
