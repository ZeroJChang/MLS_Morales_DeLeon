﻿using MLS_Morales_DeLeon.Models;
using MLS_Morales_DeLeon.Models.Storage;
using CustomGenerics.Estructuras;
using System;
using System.IO;
using System.Web;
using System.Diagnostics;
using System.Text;


using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;




namespace MLS_Morales_DeLeon.Controllers
{
    public class JugadoresController : Controller
    {
        public static Stopwatch aTimer = new Stopwatch();
        static TimeSpan ts;
        public static string elapsedTime;

        public static bool UsarListaArtesanal;
        public static List<Jugadores> JugadoresListaCopia = new List<Jugadores>();
        
        public delegate void AddingFunc(Jugadores jugadores);
        public delegate void EditFunc(int id, IFormCollection collection);
        public delegate void DeleteFunc(int id);
        public delegate void BuscarFunc(string ParametroBusqueda, string ValorBusqueda, string Rango);

        // GET: JugadoresController
        public ActionResult Index()
        {
            return View(Singleton.Instance.listaArtesanalJugadores); //revisar sjjsjs
                                                                     //return View(Singleton.Instance.listaJugadores);
        }
        public ActionResult Time()
        {
            string time = "<script>alert('El tiempo de ejecucion fue: " + elapsedTime + "');</script>";
            TempData["msg"] = time;
            return View();
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
                aTimer.Restart();
                aTimer.Start();
                var jugador = new Jugadores
                {
                    NombreJugador = collection["NombreJugador"],
                    Posicion = collection["Posicion"],
                    Salario = Convert.ToInt32(collection["Salario"]),
                    EquipoMLS = collection["EquipoMLS"]
                };

                AddingFunc AddingFunction;

                if (UsarListaArtesanal)
                {
                    AddingFunction = new AddingFunc(ListaArtesanalAdd);
                }
                else
                {
                    AddingFunction = new AddingFunc(ListaAdd);
                }
                AddingFunction(jugador);
                aTimer.Stop();
                ts = aTimer.Elapsed;
                elapsedTime = String.Format("{0} h, {1} min, {2} s, {3} ms", ts.Hours, ts.Minutes, ts.Seconds, ts.TotalMilliseconds * 10000);
                return RedirectToAction("Time");
                //return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult listaEleccion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult listaEleccion(IFormCollection collection)
        {
            var useListaArtesanal = collection["usarLista"].ToString().Split(',')[0];
            if (useListaArtesanal.ToLower() == "true")
            {
                UsarListaArtesanal = true;
            }
            else
            {
                UsarListaArtesanal = false;
            }
            return RedirectToAction("MostrarListaJugadores");
        }

        public ActionResult MostrarListaJugadores()
        {
            if (UsarListaArtesanal)
            {
                return View(Singleton.Instance.listaArtesanalJugadores);
            }
            else
            {
                return View(Singleton.Instance.listaJugadores);
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
                aTimer.Restart();
                aTimer.Start();
                EditFunc EditFunction;
                if (UsarListaArtesanal)
                {
                    EditFunction = new EditFunc(ListaArtesanalaEdit);
                }
                else
                {
                    EditFunction = new EditFunc(ListaEdit);
                }
                EditFunction(id, collection);
                aTimer.Stop();
                ts = aTimer.Elapsed;
                elapsedTime = String.Format("{0} h, {1} min, {2} s, {3} ms", ts.Hours, ts.Minutes, ts.Seconds, ts.TotalMilliseconds * 10000);
                return RedirectToAction("Time");
            }

            catch
            {
                return View();
            }
        }

        public ActionResult CrearArchivo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CrearArchivo(IFormCollection collection)
        {
            try
            {
                aTimer.Restart();
                aTimer.Start();
                StreamReader streamReader = new StreamReader(collection["ruta"]);
                var arregloJugador = (streamReader.ReadToEnd()).Split('\r');

                for (int i = 0; i < arregloJugador.Length; i++)
                {
                    if (arregloJugador[i][0] == '\n')
                    {
                        arregloJugador[i] = arregloJugador[i].Substring(1);
                    }
                }

                foreach (var atributosJugador in arregloJugador)
                {
                    var atributosJugadorArreglo = atributosJugador.Split(',');
                    if (atributosJugadorArreglo[0] != "")
                    {
                        Jugadores jugador = new Jugadores
                        {
                            NombreJugador = atributosJugadorArreglo[0],
                            Posicion = atributosJugadorArreglo[1],
                            Salario = Convert.ToInt32(atributosJugadorArreglo[2]),
                            EquipoMLS = atributosJugadorArreglo[3]
                        };

                        AddingFunc AddingFunction;

                        if (UsarListaArtesanal)
                        {
                            AddingFunction = new AddingFunc(ListaArtesanalAdd);
                        }
                        else
                        {
                            AddingFunction = new AddingFunc(ListaAdd);
                        }
                        AddingFunction(jugador);
                    }
                    
                }
                aTimer.Stop();
                ts = aTimer.Elapsed;
                elapsedTime = String.Format("{0} h, {1} min, {2} s, {3} ms", ts.Hours, ts.Minutes, ts.Seconds, ts.TotalMilliseconds * 10000);
                return RedirectToAction("Time");
            }
            catch
            {
                return View();
            }
        }

        // GET: JugadoresController/Delete/5
        public ActionResult Delete(int id)
        {
            aTimer.Restart();
            aTimer.Start();
            var DeleteFunction = new DeleteFunc(ListaDelete);
            if (UsarListaArtesanal)
            {
                DeleteFunction = new DeleteFunc(ListaArtesanalDelete);
            }
            DeleteFunction(id);
            aTimer.Stop();
            ts = aTimer.Elapsed;
            elapsedTime = String.Format("{0} h, {1} min, {2} s, {3} ms", ts.Hours, ts.Minutes, ts.Seconds, ts.TotalMilliseconds * 10000);
            return RedirectToAction("Time");
        }


        public void ListaAdd(Jugadores jugador)
        {
            jugador.GuardarLista();
        }

        public void ListaArtesanalAdd(Jugadores jugador)
        {
            Singleton.Instance.listaArtesanalJugadores.Add(jugador);
        }

        public void ListaEdit(int id, IFormCollection collection)
        {
            foreach (var item in Singleton.Instance.listaJugadores)
            {
                if (item.Id == id)
                {
                    item.EquipoMLS = collection["EquipoMLS"];
                    item.Salario = Convert.ToInt32(collection["Salario"]);
                }
            }
        }

        public void ListaArtesanalaEdit(int id, IFormCollection collection)
        {
            foreach (var item in Singleton.Instance.listaArtesanalJugadores)
            {
                if (item.Id == id)
                {
                    item.EquipoMLS = collection["EquipoMLS"];
                    item.Salario = Convert.ToInt32(collection["Salario"]);
                }
            }
        }

        public void ListaDelete(int id)
        {
            var jugadorRemover = Singleton.Instance.listaJugadores.FirstOrDefault(i => i.Id == id);
            Singleton.Instance.listaJugadores.Remove(jugadorRemover);
        }

        public void ListaArtesanalDelete(int id)
        {
            Singleton.Instance.listaArtesanalJugadores.GetAndDelete();
        }

        /// <summary>
        /// ///////////////////////////////////////////////////////////////
        /// BUSQUEDA 
        /// </summary>
        /// <param name="ParametroBusqueda"></param>
        /// <param name="ValorBusqueda"></param>
        /// <param name="Rango"></param>
        public void BuscarLinkdedLista(string ParametroBusqueda, string ValorBusqueda, string Rango)
        {
            if (ParametroBusqueda.ToLower() != "salario")
            {
             switch (ParametroBusqueda.ToLower())
                {
                    case "nombre": JugadoresListaCopia = Singleton.BuscarLista(ValorBusqueda, Singleton.CompareByName);
                        break;
                    case "posicion": JugadoresListaCopia = Singleton.BuscarLista(ValorBusqueda, Singleton.CompareByPosition);
                        break;
                    case "club": JugadoresListaCopia = Singleton.BuscarLista(ValorBusqueda, Singleton.CompareByClub);
                        break;
                        
                    default : break;
                }    
            } else
            {
                JugadoresListaCopia = Singleton.BuscarListaSalario(int.Parse(ParametroBusqueda), Singleton.CompareBySalary,Rango);
            }
        }
        public ActionResult Busqueda()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Busqueda(IFormCollection Collection)
        {
            aTimer.Restart();
            aTimer.Start();

            try
            {
                var ParametroBusqueda = Collection["ParametroBusqueda"];
                var ValorBusqueda = Collection["ValorBusqueda"] ; 
                var Rango = Collection["Rango"];
                BuscarFunc buscarfunc;
                if (UsarListaArtesanal)
                {
                    buscarfunc = new BuscarFunc(BuscarArtesanalLista);
                }
                else
                {
                    buscarfunc = new BuscarFunc(BuscarLinkdedLista);
                }

                buscarfunc(ParametroBusqueda, ValorBusqueda, Rango);

            }
            catch
            {

            }
            aTimer.Stop();
            ts = aTimer.Elapsed;
            elapsedTime = String.Format("{0} h, {1} min, {2} s, {3} ms", ts.Hours, ts.Minutes, ts.Seconds, ts.TotalMilliseconds * 10000);
            return View("CopiaLista",JugadoresListaCopia);
        }

        public ActionResult CopiaLista()
        {
            return View(JugadoresListaCopia); 
        }

      
        public void BuscarArtesanalLista(string ParametroBusqueda, string ValorBusqueda, string Rango)
        {
            try
            {
                if (ParametroBusqueda.ToLower() != "salario")
                {
                    switch (ParametroBusqueda.ToLower())
                    {
                        case "nombre":
                            JugadoresListaCopia = Singleton.BuscarListaArtesanal(ValorBusqueda, Rango, Singleton.CompareByName);
                            break;
                        case "posicion":
                            JugadoresListaCopia = Singleton.BuscarListaArtesanal(ValorBusqueda, Rango, Singleton.CompareByPosition);
                            break;
                        case "club":
                            JugadoresListaCopia = Singleton.BuscarListaArtesanal(ValorBusqueda, Rango, Singleton.CompareByClub);
                            break;

                        default: break;
                    }
                }
                else
                {
                    JugadoresListaCopia = Singleton.BuscarListaArtesanalSalario(int.Parse(ParametroBusqueda), Rango, Singleton.CompareBySalary);
                }
            }
            catch
            {
                Console.WriteLine("Ta vacio uste´");
            }

        }
    }
}
