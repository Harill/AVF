
namespace Vfi.Server.Core.CrossCutting.UnitOfWork
{
    public interface IUnitOfWork
    {
        /// <summary>
        /// Save all changes made within the unit of work
        /// </summary>
        /// <returns>Integer with number of objects affected</returns>
        int SaveChanges();

        void Terminate();
    }
}
