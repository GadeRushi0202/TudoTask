using TodoTask.Models;
using TodoTask.Repository;

namespace TodoTask.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoRepository repo;
        public TodoService(ITodoRepository repo)
        {
            this.repo = repo;
        }
        public int AddTask(TodoList todo)
        {
            return repo.AddTask(todo);
        }

        public int DeleteTask(int id)
        {
            return repo.DeleteTask(id);
        }

        public TodoList GetTaskById(int id)
        {
            return repo.GetTaskById(id);
        }

        public IEnumerable<TodoList> GetTasks()
        {
           return repo.GetTasks();
        }

        public int UpdateTask(TodoList todo)
        {
            return repo.UpdateTask(todo);
        }
    }
}
