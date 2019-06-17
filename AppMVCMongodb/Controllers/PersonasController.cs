using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using AppMVCMongodb.Models;
using MongoDB.Driver;
using MongoDB.Bson;

namespace AppMVCMongodb.Controllers
{
    public class PersonasController : Controller
    {
        public ActionResult Index()
        {
            MongoDbContext dbContext = new MongoDbContext();
            List<Persona> listaPersonas = dbContext.Personas.Find(m => true).ToList();
            return View(listaPersonas);
        }

        [HttpGet]
        public IActionResult Editar(string id)
        {
            MongoDbContext dbContext = new MongoDbContext();
            var entity = dbContext.Personas.Find(m => m.Id == id).FirstOrDefault();
             // Obtiene los documentos Notas que tengan el campo idPersona igual al Id de la persona a editar.
            List<Nota> listaNotas = dbContext.Notas.Find(m => m.IdPersona == id).ToList();
            ViewBag.listaNotas = listaNotas;
            return View(entity);
        }
        [HttpPost]
        public ActionResult Editar(Persona entity)
        {
            MongoDbContext dbContext = new MongoDbContext();
            dbContext.Personas.ReplaceOne(m => m.Id == entity.Id, entity);
            return RedirectToAction("Index", "Personas");
        }
        [HttpGet]
        public ActionResult Agregar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Agregar(Persona entity)
        {
            MongoDbContext dbContext = new MongoDbContext();
            dbContext.Personas.InsertOne(entity);
            return RedirectToAction("Index", "Personas");
        }
        [HttpGet]
        public ActionResult Eliminar(string id)
        {
            MongoDbContext dbContext = new MongoDbContext();
            dbContext.Personas.DeleteOne(m => m.Id == id);
            return RedirectToAction("Index", "Personas");
        }
    }
}