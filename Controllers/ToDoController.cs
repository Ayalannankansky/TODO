using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using Test_ToDo_Ayala.Models;


namespace Test_ToDo_Ayala.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class ToDoController : ApiController
    {
        private object random;
        private object list;

        [HttpGet]
        public List<ToDo> getAllTodos()
        {
            return DB.todos;
        }

        // GET api/values/5
        [HttpGet]
        public ToDo GetTodo(int id)
        {
            return DB.todos.Find(todo => todo.Id == id);

        }

        // POST api/values
        [HttpPost]
        public string createTodo([FromBody] ToDo newTodo)
        {
           
            if (DB.todos.Any(todo => todo.Id == newTodo.Id ))
            {
                return "The task Already exists";
            }
           
            DB.todos.Add(newTodo);
            return "The task has been added";
        }

        // PUT api/values/5
        [HttpPut]
        public string updateTodo([FromBody] ToDo updateTodo)
        {
            var index = DB.todos.FindIndex(todo => todo.Id == updateTodo.Id);
            if (index < 0)
            {
                return "not found task";
            }
           
            DB.todos[index]= updateTodo;
           
            return " The task has been updated";
        }

        // DELETE api/values/5
        [HttpDelete]
        public string DeleteTodo(int id)
        {
            var index = DB.todos.FindIndex(todo => todo.Id == id);
            if (index < 0)
            {
                return "not found task";
            }
            DB.todos.RemoveAt(index);
            return " The task has been deleted";
        }
        [HttpGet]
        public string getRandomTodo()
        {
            var random = new Random();
            string value;
            int index = random.Next(DB.todos.Count);
            value = functions.reverseString(DB.todos[index].Value);
            return value;
        }

    }
}
