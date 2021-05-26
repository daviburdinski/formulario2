using formulario2.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace formulario2.Controllers
{
    public class Home2Controller : Controller
    {
        // GET: Home2
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult formularios()
        {
            return View();
        }

        public JsonResult getForm(string pergunta1, string pergunta2, string pergunta3, string nome )
        {
            List<Data> list = new List<Data>();

            Data data = new Data();

            data.pergunta1 = pergunta1;
            data.pergunta2 = pergunta2;
            data.pergunta3 = pergunta3;
            data.nome = nome;

            list.Add(data);


            return Json(list);
        }
         
    }
}