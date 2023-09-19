using Microsoft.AspNetCore.Mvc;
using PruebaComponentesObdulio.CrossCuting.Logging;
using PruebaComponentesObdulio.Models;
using PruebaComponentesObdulio.Services;

namespace PruebaComponentesObdulio.Controllers
{
    public class OrdenadoresController : Controller
    {
        private readonly IRepositoryOrdenadores _ordenadoresRepository;
        private readonly ILoggerManager _loggerManager;


        public OrdenadoresController(IRepositoryOrdenadores ordenadoresRepository, ILoggerManager loggerManager)
        {
            _ordenadoresRepository = ordenadoresRepository;
            _loggerManager = loggerManager;
        }

        public ActionResult Index()
        {
            _loggerManager.LogInfo("Se va a mostrar la lista de ordenadores");
            _loggerManager.LogDebug("Se va a mostrar la lista de ordenadores");


            return View("Index", _ordenadoresRepository.ListaOrdenadores());
        }
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Descripcion")] Ordenador ordenador)
        {


            if (ModelState.IsValid)
            {
                _ordenadoresRepository.AddOrdenador(ordenador);
                return RedirectToAction("Index");
            }
            return View("Create", ordenador);
        }

        public ActionResult Edit(int id)
        {
            Ordenador pc = _ordenadoresRepository.TomaOrdenador(id);
            if (pc == null)
            {
                _loggerManager.LogError("Se va a mostrar error en edit null");
                return null;

            }
            return View("Edit", pc);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("Id,Descripcion")] Ordenador ordenador)
        {
            if (ModelState.IsValid)
            {
                ordenador.Id = id;
                _ordenadoresRepository.EditOrdenador(ordenador);
                return RedirectToAction("Index");
            }
            return View(ordenador);
        }





        public ActionResult Delete(int id)
        {

            var ordenador = _ordenadoresRepository.TomaOrdenador(id);

            if (ordenador == null)
            {
                _loggerManager.LogWarn("Se va a mostrar Delete not found");
                return NotFound();
            }

            return View("Delete", ordenador);
        }

        // POST: Componentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var componente = _ordenadoresRepository.TomaOrdenador(id);
            if (componente != null)
            {
                _ordenadoresRepository.BorraOrdenador(id);
            }

            return RedirectToAction(nameof(Index));
        }




        public ActionResult Details(int id)
        {


            var ordenador = _ordenadoresRepository.TomaOrdenador(id);
            if (ordenador == null)
            {
                return NotFound();
            }

            return View("Details", ordenador);
        }




    }
}

