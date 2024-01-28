﻿using TodoTask.Models;

namespace TodoTask.Services
{
    public interface ITodoService
    {
        public IEnumerable<TodoList> GetTasks();
        public TodoList GetTaskById(int id);
        public int AddTask(TodoList todo);
        public int UpdateTask(TodoList todo);
        public int DeleteTask(int id);
    }
}
