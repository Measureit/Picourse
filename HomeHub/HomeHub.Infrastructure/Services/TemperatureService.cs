using HomeHub.Application.Services;
using Iot.Device.OneWire;
using System.Threading.Tasks;

namespace HomeHub.Infrastructure
{
    public class TemperatureService : ITemperatureService
    {
        public async Task<double> ReadAsync()
        {
            double temperature = 0.0;
            foreach (var dev in OneWireThermometerDevice.EnumerateDevices())
            {
                temperature = (await dev.ReadTemperatureAsync()).DegreesCelsius;
            }
            return temperature;
        }
    }
}