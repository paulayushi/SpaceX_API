using SpaceX.Models.DTO;

namespace SpaceX.Services
{
    public interface ILaunchService
    {
        Task<IEnumerable<Launch>> GetPastLaunches();

        Task<IEnumerable<Launch>> GetUpcomingLaunches();
        Task<Launch> GetLaunchById(long flight_number);
    }
}
