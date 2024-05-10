using Microsoft.AspNetCore.Mvc;
using ToDoTask.Application.UseCases.ToDoTask.Create;
using ToDoTask.Application.UseCases.ToDoTask.Delete;
using ToDoTask.Application.UseCases.ToDoTask.GetAll;
using ToDoTask.Application.UseCases.ToDoTask.GetById;
using ToDoTask.Application.UseCases.ToDoTask.Udate;
using ToDoTask.Communication.Enums;
using ToDoTask.Communication.Request;
using ToDoTask.Communication.Response;

namespace ToDoTask.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ToDoTaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreateToDoTask), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrors), StatusCodes.Status400BadRequest)]
    public IActionResult Create([FromBody] RequestCreateToDoTask request)
    {
        try
        {
            var useCase = new CreateToDoTaskUseCase();
            var response = useCase.Execute(request);

            return Created(string.Empty, response);
        }
        catch
        {
            return BadRequest();
        }

        

    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTasks), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrors), StatusCodes.Status400BadRequest)]

    public IActionResult GetAllTasks()
    {
        try
        {
            var useCase = new GetAllTasksUseCase();
            var response = useCase.Execute();
            if (response.Tasks.Any())
            {
                return Ok(response);
            }
            return NoContent();
        }
        catch
        {
            return BadRequest();
        }
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseTasks), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrors), StatusCodes.Status404NotFound)]
    public IActionResult GetTaskById(int id)
    {

        var useCase = new GetTaskByIdUseCase();
        var response = useCase.Execute(id);
        return Ok(response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public IActionResult UpdateTask([FromRoute] int id, [FromBody] ResponseCreateToDoTask request)
    {
        var useCase = new UpdateTaskUseCase();
        useCase.Execute(id, request);
        return NoContent();

    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrors), StatusCodes.Status404NotFound)]

    public IActionResult DeleteTask([FromRoute] int id)
    {
        var useCase = new DeleteTaskUseCase();
        useCase.Execute(id);
        return NoContent();
    }
}
