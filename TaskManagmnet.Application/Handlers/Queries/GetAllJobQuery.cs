using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagmnet.Application.DTOs;
using TaskManagmnet.Application.Interfaces.Respositories;
using TaskManagmnet.Domain.Entities;

namespace TaskManagmnet.Application.Handlers.Queries
{
    public class GetAllJobQuery
    {
        private readonly IJobRepository _jobRepository;

        public GetAllJobQuery(IJobRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<JobDTO> Handle(Guid id)
        {
            var job = await _jobRepository.GetByIdAsync(id);
            
            if(job == null)
            {
                throw new Exception("Job not found");
            }

            return new JobDTO
            {
                Id = job.Id,
                Title = job.Title,
                Description = job.Description,
                IsCompleted = job.IsCompleted,
                DueDate = job.DueDate
            };

        }
    }
}