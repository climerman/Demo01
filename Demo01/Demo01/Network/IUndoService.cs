using System.Threading.Tasks;
using Demo01.Models;

namespace Demo01.Network
{
    /// <summary>
    /// Undo API Services
    /// </summary>
    public interface IUndoService
    {
        /// <summary>
        /// Returns API instance health status.
        /// </summary>
        /// <returns></returns>
        Task<HealthCheckModel> GetHeathCheck();

        /// <summary>
        /// Returns Test error message
        /// </summary>
        /// <returns></returns>
        Task<TestErrorModel> GetTestError();
    }
}
