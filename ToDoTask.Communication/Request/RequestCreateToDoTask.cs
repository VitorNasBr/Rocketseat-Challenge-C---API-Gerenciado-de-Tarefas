using ToDoTask.Communication.Enums;

namespace ToDoTask.Communication.Request;

public class RequestCreateToDoTask
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public PriorityTask Priority { get; set; }
    public StatusTask Status { get; set; }

}
