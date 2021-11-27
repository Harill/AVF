using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using Vfi.Client.Module.Factory.Interfaces;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Factory;
using Vfi.Server.Core.Repository.Factory;

namespace Vfi.Client.Module.Factory.Services
{
    public class MachineService: IMachineService
    {
        private readonly IMachineRepository _machineRepository;
        [InjectionConstructor]
        public MachineService(IMachineRepository machineRepository)
        {
            if(machineRepository == null)throw new ArgumentNullException("machineRepository");
            _machineRepository = machineRepository;
        }

        #region Machine

        public IEnumerable<Machine> GetAllMachines()
        {
            try
            {
                return _machineRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<MachineDomainModel> GetAllMachineDomainModels()
        {
            try
            {
                return GetAllMachines().Select(
                    entity => new MachineDomainModel
                    {
                        MachineId = entity.MachineId,
                        MachineName = entity.MachineName,

                        Active = entity.Active,
                        ModifiedUser = entity.ModifiedUser,
                        ModifiedDate = entity.ModifiedDate
                    });
            }
            catch
            {
                return null;
            }
        }
        public Machine GetMachineById(int machineId)
        {
            try
            {
                return
                    _machineRepository.FindAsNoTracking(f => f.MachineId == machineId).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }

        public string CreateMachine(Machine machine)
        {
            try
            {
                var targetCreate = GetMachineById(machine.MachineId);
                if (targetCreate == null)
                {
                    _machineRepository.Add(machine);

                    return "1";
                }
                return "0";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateMachine(Machine machine)
        {
            try
            {
                var targetUpdate =
                    _machineRepository.Find(f => f.MachineId == machine.MachineId)
                        .FirstOrDefault();
                if (targetUpdate != null)
                {
                    targetUpdate.MachineName = machine.MachineName ?? targetUpdate.MachineName;
                    targetUpdate.Active = machine.Active;
                    targetUpdate.ModifiedUser = machine.ModifiedUser ?? targetUpdate.ModifiedUser;
                    targetUpdate.ModifiedDate = DateTime.Now;

                    return "1";
                }
                return "0";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        #endregion
    }
}
