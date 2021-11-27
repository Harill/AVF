
namespace Vfi.Server.Core.Repository
{
    /// <summary>
    /// Context across all repositories
    /// </summary>
    public interface IRepositoryContext
    {

        /// <summary>
        /// Save all changes to all repositories
        /// </summary>
        /// <returns>Integer with number of objects affected</returns>
        int SaveChanges();

        /// <summary>
        /// Terminates the current repository context
        /// </summary>
        void Terminate();
    }
}
