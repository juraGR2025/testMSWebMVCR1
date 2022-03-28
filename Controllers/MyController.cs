using Amazon.DynamoDBv2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVCR1.Models;

namespace WebMVCR1.Controllers
{
    public class MyController : Controller
    {
        private static PersonRepository db = new PersonRepository();

        [HttpGet]//Атрибут для метода InputData().
        public ViewResult InputData()
        {
            return View();
        }
        
        [HttpPost]//Атрибут для метода InputData().
        public ViewResult InputData(Person p)
        {
            db.AddResponse(p);//Добавление объекта Person в коллекцию db
            return View("Hello", p);
        }
        public ViewResult OutputData()
        {
            ViewBag.Pers = db.GetAllResponses;
            ViewBag.Count = db.NumberOfPerson;
            return View("ListPerson");
        }

        public ViewResult Index()//string hel
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро" :
           "Добрый день";
            ViewData["Mes"] = "хорошего настроения";
            return View();
        }
    }
}