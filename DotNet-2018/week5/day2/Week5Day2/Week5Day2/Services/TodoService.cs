using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week5Day2.Interfaces;
using Week5Day2.Models;

namespace Week5Day2.Services
{
    public class TodoService : ITodoService
    {
        private readonly ApplicationContext applicationContext;

        public TodoService(ApplicationContext applicationContext)
        {
            this.applicationContext = applicationContext;
        }
        public void AddNewTodo(Todo newTodo)
        {
            applicationContext.Add(newTodo);
            applicationContext.SaveChanges();
        }

        public void DeleteTodo(long todoId)
        {
            var @todo = applicationContext.Todos.Find(todoId);
            applicationContext.Remove(@todo);
            applicationContext.SaveChanges();
        }

        public Todo FindTodoInDB(long id)
        {
            Todo todo = applicationContext.Todos.Find(id);
            return todo;
        }

        public void UpdateTodo(long todoId, Todo todo)
        {
            var todoFromTheDb = applicationContext.Todos.Find(todoId);
            todoFromTheDb.Title = todo.Title;
            todoFromTheDb.IsDone = todo.IsDone;
            todoFromTheDb.IsUrgent = todo.IsUrgent;
            applicationContext.SaveChanges();
        }

    }
}
