using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using Vfi.Client.Module.Production.Interfaces;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Production;

namespace Vfi.Client.Module.Production.Services
{
    public class ParameterService: IParameterService
    {
        private readonly IParameterRepository _parameterRepository;
        [InjectionConstructor]
        public ParameterService(IParameterRepository parameterRepository)
        {
            if (parameterRepository == null) throw new ArgumentNullException("parameterRepository");
            _parameterRepository = parameterRepository;
        }

        public IEnumerable<Parameter> GetAllParameters()
        {
            try
            {
                return _parameterRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
        }

        public string CreateParameter(Parameter parameter)
        {
            try
            {
                var targetCreate =
                    _parameterRepository.FindAsNoTracking(f => f.ParamCode == parameter.ParamCode).FirstOrDefault();
                if(targetCreate == null)
                {
                    _parameterRepository.Add(parameter);

                    return "1";
                }
                return "0";
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateParameter(Parameter parameter)
        {
            try
            {
                var targetUpdate =
                    _parameterRepository.Find(f => f.ParamCode == parameter.ParamCode).Single();
                if (targetUpdate != null)
                {
                    targetUpdate.Name = parameter.Name ?? targetUpdate.Name;
                    targetUpdate.Value = parameter.Value ?? targetUpdate.Value;
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
    }
}
