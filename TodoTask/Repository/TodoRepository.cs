using TodoTask.Data;
using TodoTask.Models;

namespace TodoTask.Repository
{
    public class TodoRepository : ITodoRepository
    {
        ApplicationDbContext db;
        public TodoRepository(ApplicationDbContext db) 
        {
            this.db = db;
        }
        public int AddTask(TodoList todo)
        {
            db.Todos.Add(todo);
            int result=db.SaveChanges();
            return result;
        }

        public int DeleteTask(int id)
        {
            int res = 0;
            var result = db.Todos.Where(x =>x.Id ==id).SingleOrDefault();
            if(result != null)
            {
                db.Todos.Remove(result);
                res = db.SaveChanges();

            }
            return res;
        }

        public TodoList GetTaskById(int id)
        {
            var result = db.Todos.Where(x => x.Id == id).FirstOrDefault();
            return result;
        }

        public IEnumerable<TodoList> GetTasks()
        {
            return db.Todos.ToList();
        }

        public int UpdateTask(TodoList todo)
        {
            int res = 0;
            var result = db.Todos.Where(x => x.Id == todo.Id).SingleOrDefault();
            if (result != null)
            {
                result.Name = todo.Name;    
                result.Description = todo.Description;
                result.TaskDate = todo.TaskDate;
                res = db.SaveChanges();

            }
            return res;
        }
    }
}
