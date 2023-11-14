using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using ToDoListServer.Models;

namespace ToDoListServer.Controllers;

/// <summary>
/// Контроллер для работы с задачами.
/// </summary>
[Route("api/ToDoList")]
[ApiController]
public class TaskController : ControllerBase
{
    //(GET) http://localhost:8089/api/ToDoList/GetTasks
    [HttpGet("GetTasks")]
    public async Task<ActionResult<IEnumerable<UserTask>>> GetCategories()
    {
        throw new NotImplementedException();
    }

    //(GET) http://localhost:8089/api/ToDoList/RemoveTask/{taskId:int}
    [HttpGet("RemoveTask")]
    public async Task<ActionResult> RemoveTask(int taskId)
    {
        throw new NotImplementedException();
    }

    //(POST) http://localhost:8089/api/ToDoList/AddTask
    //{
    //	"id":1,
    //	"name":"taskName",
    //	"description": "taskDescription"
    //	"categoryId": 2
    //}
    [HttpPost("AddTask")]
    public async Task<ActionResult> AddTask(UserTask userTask)
    {
        throw new NotImplementedException();
    }

    //(POST) http://localhost:8089/api/ToDoList/UpdateTask
    //{
    //	"id":1,
    //	"name":"taskName",
    //	"description": "taskDescription"
    //	"categoryId": 2
    //}
    [HttpPost("UpdateTask")]
    public async Task<ActionResult> UpdateTask(UserTask userTask)
    {
        throw new NotImplementedException();
    }

}
