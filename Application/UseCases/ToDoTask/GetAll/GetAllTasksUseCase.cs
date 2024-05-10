using ToDoTask.Communication.Response;

namespace ToDoTask.Application.UseCases.ToDoTask.GetAll;

public class GetAllTasksUseCase
{
    public ResponseAllTasks Execute()
    {
        return new ResponseAllTasks()
        {
            Tasks = new List<ResponseTasks>
            {
                new ResponseTasks
                {
                    Id = 1,
                    Name = "Name Task",
                    Description = "Description Task",
                    Status = Communication.Enums.StatusTask.inProgress,
                    Type = Communication.Enums.PriorityTask.high
                }
            }
        };
        
    }
}
