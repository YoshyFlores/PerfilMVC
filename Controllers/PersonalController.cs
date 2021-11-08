using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PerfilMVC.Models;

namespace PerfilMVC.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            Personal personal=new Personal();
            personal.name="Yosselin";
            personal.lastname= "Flores";
            personal.age=21;
            personal.telefono= 70020601;
            personal.direccion="Colonia Jardines de la Ceiba CLL. PPAL, #3 Pol.12";
            personal.correo="yoshy.floresg17@gmail.com";
            return View(personal);

        }
    }
}

