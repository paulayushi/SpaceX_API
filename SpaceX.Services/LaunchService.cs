using SpaceX.Models.DTO;
using SpaceX.Services.Constants;
using System.Net.Http.Json;
using System.Threading;

namespace SpaceX.Services
{
    public class LaunchService : ILaunchService
    {
        private readonly HttpClient _http;

        public LaunchService(HttpClient http)
        {
            _http = http;
        }
        public async Task<Launch> GetLaunchById(long flight_number)
        {
            try
            {
                return await _http.GetFromJsonAsync<Launch>(ApiUrlConstants.OneLaunch + flight_number).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }

        public async Task<IEnumerable<Launch>> GetPastLaunches()
        {
            try
            {
                return await _http.GetFromJsonAsync<List<Launch>>(ApiUrlConstants.PastLaunches).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }

        public async Task<IEnumerable<Launch>> GetUpcomingLaunches()
        {
            try
            {
                return await _http.GetFromJsonAsync<List<Launch>>(ApiUrlConstants.UpcomingLaunches).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                throw new HttpRequestException(ex.Message);
            }
        }
    }
}
