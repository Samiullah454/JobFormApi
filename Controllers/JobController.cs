using JobFormApi.Dtos;
using JobFormApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace JobFormApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobController : ControllerBase
    {
        private readonly IJobService _jobService;

        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddJob([FromBody] JobDto jobDto)
        {
            try
            {
                int jobId = await _jobService.AddJobasync(jobDto);
                return Ok(new { JobId = jobId });
            }
            catch (Exception)
            {
                return StatusCode(500, new { ErrorMessage = "Internal Server Error" });
            }
        }
    }
}