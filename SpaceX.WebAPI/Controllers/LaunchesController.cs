using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpaceX.Services;

namespace SpaceX.WebAPI.Controllers
{
    [ApiController]
    [Route("spacex/launches/api/")]
    [Authorize(Roles = "Admin")]
    public class LaunchesController : ControllerBase
    {
        private readonly ILaunchService _launchService;

        public LaunchesController(ILaunchService launchService)
        {
            _launchService = launchService;
        }

        [HttpGet]
        [Route("{flight_number}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetLaunchById(long flight_number)
        {
            try
            {
                var rensponse = await _launchService.GetLaunchById(flight_number);
                return Ok(rensponse);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("404 (Not Found)."))
                {
                    return NotFound();
                }
                throw new HttpRequestException(ex.Message); ;
            }
        }

        [HttpGet]
        [Route("past-launches")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetPastLaunch()
        {
            var rensponse = await _launchService.GetPastLaunches();
            return Ok(rensponse);
        }

        [HttpGet]
        [Route("upcoming-launches")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetUpcomingLaunch()
        {
            var rensponse = await _launchService.GetUpcomingLaunches();
            return Ok(rensponse);
        }        
    }
}
