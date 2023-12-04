using JobFormApi.Dtos;
using JobFormApi.Entities;
using JobFormApi.Repository;

namespace JobFormApi.Services
{
    public class JobService : IJobService
    {
        private readonly IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<int> AddJobasync(JobDto jobDto)
        {
            if (jobDto.Sections == null)
            {
                var jobWithoutSections = new Job
                {
                    JobTitle = jobDto.JobTitle,
                    JobType = jobDto.JobType,
                    Expiry = jobDto.Expiry,
                    JobDuration = jobDto.JobDuration
                };

                return await _jobRepository.AddJobasync(jobWithoutSections);
            }
            var job = new Job
            {
                JobTitle = jobDto.JobTitle,
                JobType = jobDto.JobType,
                Expiry = jobDto.Expiry,
                JobDuration = jobDto.JobDuration,

                Sections = jobDto.Sections.Select(sectionDto => new Section
                {
                    Name = sectionDto.Name,
                    Fields = sectionDto.Fields.Select(fieldDto => new Field
                    {
                        Name = fieldDto.Name,
                        Value = fieldDto.Value
                    }).ToList()
                }).ToList()
            };
            return await _jobRepository.AddJobasync(job);
        }
    }
}