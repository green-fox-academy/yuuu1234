using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week5Day2.Models;

namespace Week5Day2.Interfaces
{
    public interface ITodoService
    {
        void AddNewTodo(Todo newTodo);
        void DeleteTodo(long todoId);
        void UpdateTodo(long todoId,Todo todo);
        Todo FindTodoInDB(long id);

    }
}
