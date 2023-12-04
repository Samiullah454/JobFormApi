using JobFormApi.Entities;

namespace JobFormApi.Repository
{
    public interface IJobRepository
    {
        public Task<int> AddJobasync(Job job);
    }
}