using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Week5Day2.Interfaces;
using Week5Day2.Models;

namespace Week5Day2.Controllers.TodoController
{
    [Route("todo")]
    public class TodoController : Controller
    {
        private readonly ApplicationContext applicationContext;
        private readonly ITodoService todoService;
        public TodoController(ApplicationContext context,ITodoService todoService)
        {
            this.applicationContext = context;
            this.todoService = todoService;

        }

        [HttpGet("/")]
        public IActionResult Index(string isActive)
        {
            // Create a SQL query in the background
            var todos = applicationContext.Todos.ToList();
            ViewBag.isActive = isActive;
            return View(isActive,todos);
        }
        [HttpGet("/list")]
        public IActionResult List()
        {
            return View();
        }

        [HttpGet("/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("/add")]
        public IActionResult AfterAdd(string newTodo)
        {
            todoService.AddNewTodo(new Todo(){Title = newTodo});
            var todos = applicationContext.Todos.ToList();
            return RedirectToAction(nameof(Index), "Todo",todos);
        }

        public IActionResult Delete(long deleteId)
        {
            todoService.DeleteTodo(deleteId);
            var todos = applicationContext.Todos.ToList();
            return RedirectToAction(nameof(Index),"Todo",todos);
        }

        [HttpGet("/{id}/edit")]
        public IActionResult Update(long id)
        {
            ViewBag.todoId = id;            
            return View(todoService.FindTodoInDB(id));
        }

        [HttpPost("/{id}/edit")]
        public IActionResult AfterUpdate(long id,Todo todo)
        {
            todoService.UpdateTodo(id,todo);
            var todos = applicationContext.Todos.ToList();
            return RedirectToAction(nameof(Index),"Todo",todos);
        }

    }
}