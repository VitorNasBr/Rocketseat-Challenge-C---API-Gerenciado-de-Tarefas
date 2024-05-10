using ToDoTask.Communication.Enums;

namespace ToDoTask.Communication.Response;

public class ResponseTasks
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public PriorityTask Type { get; set; }
    public StatusTask Status { get; set; }
}
