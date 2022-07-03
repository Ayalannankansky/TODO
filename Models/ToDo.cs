using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_ToDo_Ayala.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public Boolean Complete { get; set; }
    }
}