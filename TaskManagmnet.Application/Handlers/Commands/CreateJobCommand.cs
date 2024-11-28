using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task Handle(CreateJobDTO createJobDTO)
        {
            var job = new Job
            {
                Id = Guid.NewGuid(),
                Title = createJobDTO.Title,
                Description = createJobDTO.Description,
                DueDate = createJobDTO.DueDate,
                IsCompleted = createJobDTO.IsCompleted
                
            };
            await _jobRepository.AddAsync(job);
        }
    
    }
}