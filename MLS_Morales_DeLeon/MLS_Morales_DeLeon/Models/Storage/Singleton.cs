using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MLS_Morales_DeLeon.Models.Storage
{
    public class Singleton
    {
        private readonly static Singleton _instance = new Singleton();
        public LinkedList<Jugadores> listaJugadores;
        private Singleton()
        {
            listaJugadores = new LinkedList<Jugadores>();
        }

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
