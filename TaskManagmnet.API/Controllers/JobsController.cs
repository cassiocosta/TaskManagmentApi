using Microsoft.AspNetCore.Mvc;
using TaskManagmnet.Application.DTOs;
using TaskManagmnet.Application.Services;
using TaskManagmnet.Domain.Entities;

namespace TaskManagmnet.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JobsController : ControllerBase
{
    private readonly JobService _jobService;

    public JobsController(JobService jobService)
    {
        _jobService = jobService;
    }

    [HttpPost]
    public async Task<ActionResult> CreateJob([FromBody] JobDTO createTaskDto)
    {
        await _jobService.
    }
    
}