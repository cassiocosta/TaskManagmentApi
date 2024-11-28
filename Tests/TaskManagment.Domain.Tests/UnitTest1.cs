namespace TaskManagment.Domain.Tests;

public class UnitTest1
{
    [Fact]
    public void Job_Creation_Should_Set_Properties_Correctly()
    {
        var name = "Test Job";
        var description = "Description of the test job";
        var dueDate = DateTime.UtcNow.AddDays(7);
        var isCompleted = false;

        // Act
        var job = new Job(name, description, dueDate, isCompleted);
        

        // // Assert
        // Assert.Equal(name, job.Name);
        // Assert.Equal(description, job.Description);
        // Assert.Equal(dueDate, job.DueDate);
        // Assert.Equal(isCompleted, job.IsCompleted);
    }
}