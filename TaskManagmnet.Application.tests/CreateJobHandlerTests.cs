using TaskManagmnet.Application.DTOs;
using TaskManagmnet.Domain.Entities;
using Xunit;

namespace TaskManagmnet.Application.tests;
using Moq;
using TaskManagmnet.Application.Interfaces.Respositories;
using TaskManagmnet.Application.Handlers.Commands;

public class CreateJobHandlerTests
{
    private readonly Mock<IJobRepository> _jobRepositoryMock;
    private readonly CreateJobCommand _handler;

   public CreateJobHandlerTests()
   {
        _jobRepositoryMock = new Mock<IJobRepository>();
        _handler = new CreateJobCommand(_jobRepositoryMock.Object);
   }

   [Fact]
   public async Task Handle_Should_Create_Job_And_Save_To_Repository()
   {
        // Given
        var createJobDto = new CreateJobDTO
        {
            Title = "Test Job",
            Description = "Test Description",
            DueDate = DateTime.UtcNow.AddDays(5),
            IsCompleted = false
        };
        // When
            await _handler.Handle(createJobDto);

        // Then
         _jobRepositoryMock.Verify(repo => repo.AddAsync(It.Is<Job>(job =>
            job.Title == createJobDto.Title &&
            job.Description == createJobDto.Description &&
            job.DueDate == createJobDto.DueDate &&
            job.IsCompleted == createJobDto.IsCompleted
        )), Times.Once);
   }

}