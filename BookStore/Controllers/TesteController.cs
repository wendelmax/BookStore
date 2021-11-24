using BookStore.Domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class TesteController : Controller
    {
        public ViewResult Dados(int Id)
        {
            return View(Id);
        }

        public JsonResult Teste(int id, string nome)
        {
            var autor = new Author
            {
                Id = id,
                Name = nome
            };
            return Json(autor, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ActionName("author")]
        public JsonResult Enviar(Author autor)
        {
            return Json(autor, JsonRequestBehavior.AllowGet);
        }
    }
}