using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ToDoListMVC.Controllers
{
    public class ToDoListController : Controller
    {
        //
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is an overview of all todo's!";
        }

        //
        // GET: /HelloWorld/Welcome/

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode(
                $"Hello = {name}, your ID is {ID}");
        }
    }
}