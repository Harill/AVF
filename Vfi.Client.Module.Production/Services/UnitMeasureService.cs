using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using Vfi.Client.Module.Production.Interfaces;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.Repository.Production;

namespace Vfi.Client.Module.Production.Services
{
    public class UnitMeasureService : IUnitMeasureService
    {
        private readonly IUnitMeasureRepository _unitMeasureRepository;
        [InjectionConstructor]
        public UnitMeasureService(IUnitMeasureRepository unitMeasureRepository)
        {
            if (unitMeasureRepository == null) throw new ArgumentNullException("unitMeasureRepository");

            _unitMeasureRepository = unitMeasureRepository;
        }

        public IEnumerable<UnitMeasure> GetAllUnitMeasures()
        {
            try
            {
                return _unitMeasureRepository.GetAllAsNoTracking();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public UnitMeasure GetUnitMeasureByCode(string unitMeasureCode)
        {
            try
            {
                return
                    _unitMeasureRepository.FindAsNoTracking(
                        f => f.UnitMeasureCode.Equals(unitMeasureCode, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string CreateUnitMeasure(UnitMeasure unitMeasure)
        {
            try
            {
                var targetCreate =
                    _unitMeasureRepository.Find(
                        f => f.UnitMeasureCode.Equals(unitMeasure.UnitMeasureCode, StringComparison.OrdinalIgnoreCase))
                        .FirstOrDefault();
                if (targetCreate == null)
                {
                    _unitMeasureRepository.Add(unitMeasure);
                    return "1";
                }
                return "0";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateUnitMeasure(UnitMeasure unitMeasure)
        {
            try
            {
                var targetUpdate =
                    _unitMeasureRepository.Find(
                        f => f.UnitMeasureCode.Equals(unitMeasure.UnitMeasureCode, StringComparison.OrdinalIgnoreCase))
                        .FirstOrDefault();
                if (targetUpdate != null)
                {
                    targetUpdate.UnitMeasureName = unitMeasure.UnitMeasureName ?? targetUpdate.UnitMeasureName;
                    targetUpdate.Active = unitMeasure.Active;
                    targetUpdate.ModifiedUser = unitMeasure.ModifiedUser ?? targetUpdate.ModifiedUser;
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
