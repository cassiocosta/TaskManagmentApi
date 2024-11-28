using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagmnet.Application.DTOs;
using TaskManagmnet.Application.Interfaces.Respositories;
using TaskManagmnet.Domain.Entities;

namespace TaskManagmnet.Application.Handlers.Commands
{
    public class DeleteJobCommand
    {
        private readonly IJobRepository _jobRepository;
        public DeleteJobCommand(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }
        public async Task Handle(Guid id)
        {
            var existingJob = await _jobRepository.GetByIdAsync(id);
            
            if(existingJob == null)
            {
                throw new Exception("Job not found");
            }
           
            await _jobRepository.DeleteAsync(existingJob);
        }
    }
}