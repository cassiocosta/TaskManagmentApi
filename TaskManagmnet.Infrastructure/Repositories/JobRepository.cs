using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagmnet.Application.Interfaces.Respositories;
using TaskManagmnet.Domain.Entities;
using TaskManagmnet.Infrastructure.Data.Contexts;

namespace TaskManagmnet.Infrastructure.Repositories
{
    public class JobRepository : BaseRepository<Job>, IJobRepository
    {
        public JobRepository(DataContext context) : base(context)
        {
        }
    }
}