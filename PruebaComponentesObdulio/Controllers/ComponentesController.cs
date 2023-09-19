using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PruebaComponentesObdulio.CrossCuting.Logging;
using PruebaComponentesObdulio.Data;
using PruebaComponentesObdulio.Models;
using PruebaComponentesObdulio.Services;

namespace PruebaComponentesObdulio.Controllers
{
    public class ComponentesController : Controller
    {
        private readonly IRepositoryComponentes _componentesRepository;
        private readonly ILoggerManager _loggerManager;


        public ComponentesController(IRepositoryComponentes componentesRepository, ILoggerManager loggerManager)
        {
            _componentesRepository = componentesRepository;
            _loggerManager = loggerManager;
        }

        public ActionResult Index()
        {
            _loggerManager.LogInfo("Se va a mostrar la lista de componentes");
            _loggerManager.LogDebug("Se va a mostrar la lista de componentes");
            
            
            return View("Index", _componentesRepository.ListaComponentes());
        }
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Coste,NumeroSerie,Calor,Cores,Descripcion,Megas,TipoComponente")] Componente componente)
        {


            if (ModelState.IsValid)
            {
                _componentesRepository.AddComponente(componente);
                return RedirectToAction("Index");
            }
            return View("Create", componente);
        }

        public ActionResult Edit(int id)
        {
            Componente comp = _componentesRepository.TomaComponente(id);
            if (comp == null)
            {
                _loggerManager.LogError("Se va a mostrar error en edit null");
                return null;

            }
            return View("Edit", comp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("Id,Coste,NumeroSerie,Calor,Cores,Descripcion,Megas,TipoComponente")] Componente componente)
        {
            if (ModelState.IsValid)
            {
                componente.Id = id;
                _componentesRepository.EditComponente(componente);
                return RedirectToAction("Index");
            }
            return View(componente);
        }





        public ActionResult Delete(int id)
        {
            
            var componente = _componentesRepository.TomaComponente(id);
                
            if (componente == null)
            {
                _loggerManager.LogWarn("Se va a mostrar Delete not found");
                return NotFound();
            }

            return View("Delete",componente);
        }

        // POST: Componentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var componente = _componentesRepository.TomaComponente(id);
            if (componente != null)
            {
                _componentesRepository.BorraComponente(id);
            }

            return RedirectToAction(nameof(Index));
        }

        

        
        public ActionResult Details(int id)
        {


            var componente = _componentesRepository.TomaComponente(id);
            if (componente == null)
            {
                return NotFound();
            }

            return View("Details",componente);
        }




    }
}