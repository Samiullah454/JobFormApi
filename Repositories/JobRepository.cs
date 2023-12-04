using JobFormApi.Data;
using JobFormApi.Entities;

namespace JobFormApi.Repository
{
    public class JobRepository : IJobRepository
    {
        private readonly JobDbContext _dbContext;

        public JobRepository(JobDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> AddJobasync(Job job)
        {
            _dbContext.Jobs.Add(job);
            await _dbContext.SaveChangesAsync();

            return job.Id;
        }
    }
}