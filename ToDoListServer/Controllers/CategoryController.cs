using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using ToDoListServer.Models;

namespace ToDoListServer.Controllers;

/// <summary>
/// Контроллер для работы с категориями.
/// </summary>
[Route("api/[controller]")]
[ApiController]
public class CategoryController
{
    //(GET) http://localhost:8089/api/ToDoList/GetCategories
    [HttpGet("GetCategories")]
    public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
    {
        throw new NotImplementedException();
    }

    //(GET) http://localhost:8089/api/ToDoList/RemoveCategory/{categoryId:int}
    [HttpGet("RemoveCategory")]
    public async Task<ActionResult> RemoveCategory(int id)
    {
        throw new NotImplementedException();
    }

    //(POST) http://localhost:8089/api/ToDoList/AddCategory    
    //{
    //	"id":1,
    //	"name":"categoryName",
    //	"description": "categoryDescription"
    //}
    [HttpPost("AddCategory")]
    public async Task<ActionResult> AddCategory(Category category)
    {
        throw new NotImplementedException();
    }

    //(POST) http://localhost:8089/api/ToDoList/UpdateCategory   
    //{
    //	"id":1,
    //	"name":"categoryName",
    //	"description": "categoryDescription"
    //}
    [HttpPost("UpdateCategory")]
    public async Task<ActionResult> UpdateCategory(Category category)
    {
        throw new NotImplementedException();
    }
}
