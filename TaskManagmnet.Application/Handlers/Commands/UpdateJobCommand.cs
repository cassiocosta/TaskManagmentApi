using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagmnet.Application.DTOs;
using TaskManagmnet.Application.Interfaces.Respositories;
using TaskManagmnet.Domain.Entities;

namespace TaskManagmnet.Application.Handlers.Commands
{
    public class UpdateJobCommand
    {
        private readonly IJobRepository _jobRepository;
        public UpdateJobCommand(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        public async Task Handle(Guid jobId, UpdateJobDTO updateJobDTO)
        {
            var existingJob = await _jobRepository.GetByIdAsync(jobId);
            
            if(existingJob == null)
            {
                throw new Exception("Job not found");
            }

            
            existingJob.Id = updateJobDTO.Id;
            existingJob.Title = updateJobDTO.Title;
            existingJob.Description = updateJobDTO.Description;
            existingJob.DueDate = updateJobDTO.DueDate;
            existingJob.IsCompleted = updateJobDTO.IsCompleted;
            
            await _jobRepository.UpdateAsync(existingJob);
        }
    }
}