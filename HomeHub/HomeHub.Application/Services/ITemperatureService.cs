using System.Threading.Tasks;

namespace HomeHub.Application.Services
{
    public interface ITemperatureService
    {
        Task<double> ReadAsync();
    }
}
