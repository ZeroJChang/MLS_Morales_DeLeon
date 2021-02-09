using MLS_Morales_DeLeon.Models;
using MLS_Morales_DeLeon.Models.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MLS_Morales_DeLeon.Controllers
{
    public class JugadoresController : Controller
    {
        // GET: JugadoresController
        public ActionResult Index()
        {
            return View(Singleton.Instance.listaJugadores); //revisar sjjsjs
          //return View(Singleton.Instance.listaJugadores);
        }

        // GET: JugadoresController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: JugadoresController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JugadoresController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: JugadoresController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: JugadoresController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var nuevoJugador = new Jugadores
                {
                    EquipoMLS = collection["nombreC"],
                    NombreJugador = collection["apellidoC"],
                    Posicion = collection["telefonoC"],
                    Salario = Convert.ToInt32(collection["descripcionC"]),
                    Id = Convert.ToInt32(collection["descripcionC"])
    };

                Singleton.Instance.listaJugadores.AddFirst(nuevoJugador);

                return RedirectToAction(nameof(Index));
            }

            catch
            {
                return View();
            }
        }

        // GET: JugadoresController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: JugadoresController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
