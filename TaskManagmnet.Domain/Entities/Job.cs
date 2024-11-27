using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagmnet.Domain.Entities
{
    public class Job
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Status { get; set; } = "Pending"; // Default
    public DateTime DueDate { get; set; }
}

}