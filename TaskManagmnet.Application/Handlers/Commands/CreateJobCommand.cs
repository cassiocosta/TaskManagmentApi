using TaskManagmnet.Application.DTOs;
using TaskManagmnet.Application.Interfaces.Respositories;
using TaskManagmnet.Domain.Entities;

namespace TaskManagmnet.Application.Handlers.Commands
{
    public class CreateJobCommand
    {
        private readonly IJobRepository _jobRepository;
        public CreateJobCommand(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        public async Task Handle(CreateJobDTO createJobDto)
        {
            var job = new Job
            {
                Id = Guid.NewGuid(),
                Title = createJobDto.Title,
                Description = createJobDto.Description,
                DueDate = createJobDto.DueDate,
                IsCompleted = createJobDto.IsCompleted
                
            };
            await _jobRepository.AddAsync(job);
        }
    
    }
}