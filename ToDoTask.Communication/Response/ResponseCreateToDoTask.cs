using ToDoTask.Communication.Enums;

namespace ToDoTask.Communication.Response;

public class ResponseCreateToDoTask
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public PriorityTask Type { get; set; }

    public StatusTask Status { get; set; }
}
