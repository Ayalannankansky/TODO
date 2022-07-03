using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_ToDo_Ayala.Models
{
    public class DB
    {
        public static List<ToDo> todos;
        static DB()
        {
            todos = new List<ToDo>
            {
                new ToDo { Id = 123,Value = "take the dog for a walk" , Complete = true},
                new ToDo { Id = 345,Value = "Make soup" , Complete = true},
                new ToDo { Id = 678,Value = "clean the house" , Complete = true}
            };
        }
    }
}