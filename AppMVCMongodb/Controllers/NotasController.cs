﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using AppMVCMongodb.Models;
using MongoDB.Driver;
using MongoDB.Bson;

namespace AppMVCMongodb.Controllers
{
    public class NotasController : Controller
    {
        public ActionResult Index()
        {
            MongoDbContext dbContext = new MongoDbContext();
            List<Nota> listaNotas = dbContext.Notas.Find(m => true).ToList();
            return View(listaNotas);
        }
        [HttpGet]
        public IActionResult Editar(string id)
        {
            MongoDbContext dbContext = new MongoDbContext();
            var entity = dbContext.Notas.Find(m => m.Id == id).FirstOrDefault();
            return View(entity);
        }
        [HttpPost]
        public ActionResult Editar(Nota entity)
        {
            MongoDbContext dbContext = new MongoDbContext();
            dbContext.Notas.ReplaceOne(m => m.Id == entity.Id, entity);
            return RedirectToAction("Editar/" + entity.Persona, "Personas");
        }

        [HttpGet]
        public IActionResult Agregar(string id)
        {
            ViewBag.Persona = id;
            return View();
        }
        [HttpPost]
        public ActionResult Agregar(Nota entity)
        {
            MongoDbContext dbContext = new MongoDbContext();
            entity.Id = null;
            dbContext.Notas.InsertOne(entity);
            return RedirectToAction("Editar/" + entity.Persona, "Personas");
        }
        [HttpGet]
        public ActionResult Eliminar(string id)
        {
            MongoDbContext dbContext = new MongoDbContext();
            dbContext.Notas.DeleteOne(m => m.Id == id);
            return RedirectToAction("Index","Personas");
        }
    }
}