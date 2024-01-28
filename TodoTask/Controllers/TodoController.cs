using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoTask.Models;
using TodoTask.Services;

namespace TodoTask.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoService service;
        public TodoController(ITodoService service)
        {
            this.service = service;
        }
        // GET: TodoController
        public ActionResult Index()
        {
            return View(service.GetTasks());
        }

        // GET: TodoController/Details/5
        public ActionResult Details(int id)
        {
            var task = service.GetTaskById(id);
            return View(task);
        }

        // GET: TodoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TodoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TodoList todo)
        {
            try
            {
                int result = service.AddTask(todo);
                if(result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
                
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: TodoController/Edit/5
        public ActionResult Edit(int id)
        {
            var todo = service.GetTaskById(id); 
            return View(todo);
        }

        // POST: TodoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TodoList todo)
        {
            try
            {
                int result = service.UpdateTask(todo);
                if(result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
                
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: TodoController/Delete/5
        public ActionResult Delete(int id)
        {
            var todo=service.GetTaskById(id);
            return View(todo);
        }

        // POST: TodoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]  
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                int result = service.DeleteTask(id);
                if( result >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return View();
                }
                
            }
            catch (Exception ex) 
            {
                return View();
            }
        }
    }
}
