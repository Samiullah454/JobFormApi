using JobFormApi.Dtos;

namespace JobFormApi.Services
{
    public interface IJobService
    {
        Task<int> AddJobasync(JobDto jobDto);
    }
}