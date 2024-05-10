using ToDoTask.Communication.Response;

namespace ToDoTask.Application.UseCases.ToDoTask.GetById;

public class GetTaskByIdUseCase
{
    public ResponseTasks Execute(int id)
    {
        return new ResponseTasks()
        {
            Id = id,
            Name = "Task Name",
            Description = "Task Description",
            Status = Communication.Enums.StatusTask.inProgress,
            Type = Communication.Enums.PriorityTask.high
        };
    }
}
