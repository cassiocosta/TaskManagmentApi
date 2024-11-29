namespace TaskManagmnet.Domain.tests;

using TaskManagmnet.Domain.Entities;

public class JobUnitTest
{
    [Fact]
    public void Job_Creation_Should_Set_Properties_Correctly()
    {
        // Arrange
        var title = "Test Job";
        var description = "Description of the test job";
        var dueDate = DateTime.UtcNow.AddDays(7);
        var isCompleted = false;

        // Act
        var job = new Job
        {            
            Title = title,
            Description = description,
            DueDate = dueDate,
            IsCompleted = isCompleted
            
        };

        // Assert
        Assert.Equal(title, job.Title);
        Assert.Equal(description, job.Description);
        Assert.Equal(dueDate, job.DueDate);
        Assert.Equal(isCompleted, job.IsCompleted);
    }
}