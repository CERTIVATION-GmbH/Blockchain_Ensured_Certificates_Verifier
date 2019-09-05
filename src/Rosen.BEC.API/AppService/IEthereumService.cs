
using System.Threading.Tasks;

namespace Rosen.BEC.API.AppService
{
    public interface IEthereumService
    {
        Task<string> GetHashValue(string individualSmartContract);
    }
}