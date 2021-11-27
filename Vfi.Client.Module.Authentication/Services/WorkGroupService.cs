using System;
using System.Collections.Generic;
using Microsoft.Practices.Unity;
using Vfi.Client.Module.Authentication.Interfaces;
using Vfi.Server.Core.CrossCutting.UnitOfWork;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.System;
using Vfi.Server.Core.Repository.System;

namespace Vfi.Client.Module.Authentication.Services
{
    public class WorkGroupService : IWorkGroupService
    {
        private readonly IWorkGroupRepository _workGroupRepository;
        private readonly IUnitOfWork _unitOfWork;
        [InjectionConstructor]
        public WorkGroupService(IUnitOfWork unitOfWork, IWorkGroupRepository workGroupRepository)
        {
            if (_unitOfWork == null) _unitOfWork = unitOfWork;
            if (_workGroupRepository == null) _workGroupRepository = workGroupRepository;
        }

        public IEnumerable<WorkGroup> GetAllWorkGroups()
        {
            //throw new NotImplementedException();
            return _workGroupRepository.GetAllWorkGroup();
        }
        public IEnumerable<WorkGroup> GetAllWorkGroupActive()
        {
            throw new NotImplementedException();
        }
        public WorkGroup GetWorkGroupById(int workGroupId)
        {
            return _workGroupRepository.GetWorkGroupById(workGroupId);
        }

        public void CreateWorkGroup(WorkGroupModel workGroupModel)
        {
            var workGroup = new WorkGroup
                                {
                                    WorkGroupCode = workGroupModel.WorkGroupCode,
                                    WorkGroupName = workGroupModel.WorkGroupName,
                                    Description = workGroupModel.Description,
                                    Active = workGroupModel.Active,
                                    ModifiedDate = DateTime.Now
                                };
            try
            {
                _workGroupRepository.CreateWorkGroup(workGroup);
                _unitOfWork.SaveChanges();
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public void UpdateWorkGroup(WorkGroupModel workGroupModel)
        {
            try
            {
                var target = GetWorkGroupById(workGroupModel.WorkGroupId);
                if (target != null)
                {
                    target.WorkGroupCode = workGroupModel.WorkGroupCode;
                    target.WorkGroupName = workGroupModel.WorkGroupName;
                    target.Description = workGroupModel.Description;
                    target.Active = workGroupModel.Active;
                    target.ModifiedDate = DateTime.Now;
                }
                _unitOfWork.SaveChanges();
            }
            catch (Exception)
            {
                return;
            }
        }
        
        public void DeleteWorkGroup(int workGroupId)
        {
            var target = GetWorkGroupById(workGroupId);

            try
            {
                if (target != null)
                {
                    //var user = new User { UserID = target.UserID };
                    _workGroupRepository.DeleteWorkGroup(target);
                    _unitOfWork.SaveChanges();
                }
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
