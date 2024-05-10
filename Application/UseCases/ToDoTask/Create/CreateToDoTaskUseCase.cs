using ToDoTask.Communication.Enums;
using ToDoTask.Communication.Request;
using ToDoTask.Communication.Response;

namespace ToDoTask.Application.UseCases.ToDoTask.Create;

public class CreateToDoTaskUseCase
{
    public ResponseCreateToDoTask Execute(RequestCreateToDoTask request)
    {
        return new ResponseCreateToDoTask()
        {
            Id = request.Id,
            Name = request.Name,
            Description = request.Description,
            Type = request.Priority,
            Status = request.Status
        };
    }
}
