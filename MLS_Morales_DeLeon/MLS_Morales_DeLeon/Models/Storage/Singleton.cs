using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomGenerics.Estructuras;
using MLS_Morales_DeLeon.Models;

namespace MLS_Morales_DeLeon.Models.Storage
{
    public class Singleton
    {
        private readonly static Singleton _instance = new Singleton();
        public LinkedList<Jugadores> listaJugadores;
        public ListaAretsanal<Jugadores> listaArtesanalJugadores;
        private Singleton()
        {
            listaJugadores = new LinkedList<Jugadores>();
            listaArtesanalJugadores = new ListaAretsanal<Jugadores>();
        }

        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }

        public delegate bool DelString(Jugadores value1, string value2);
        public delegate int DelInt(Jugadores value1, int value2);

        public static bool CompareByName(Jugadores value1, string value2)
        {
            if (value1.NombreJugador == value2)
            {
                return true;
            }
            return false;
        }

        /*public static bool CompareByLastName(PlayerModel value1, string value2)
        {
            if (value1.LastName == value2)
            {
                return true;
            }
            return false;
        }*/

        public static bool CompareByPosition(Jugadores value1, string value2)
        {
            if (value1.Posicion == value2)
            {
                return true;
            }
            return false;
        }

        public static bool CompareByClub(Jugadores value1, string value2)
        {
            if (value1.EquipoMLS == value2)
            {
                return true;
            }
            return false;
        }

        public static int CompareBySalary(Jugadores value1, int value2)
        {
            if (value1.Salario > value2)
            {
                return 1;
            }
            else if (value1.Salario == value2)
            {
                return 0;
            }
            return -1;
        }

        public static List<Jugadores> HandMadeListSearch(string searchingValue, string range, DelString delegateString)
        {
            List<Jugadores> finalList = new List<Jugadores>();
            foreach (var item in Storage.Singleton.Instance.listaArtesanalJugadores)
            {
                if (delegateString(item, searchingValue))
                {
                    finalList.Add(item);
                }
            }
            return finalList;
        }

        public static List<Jugadores> HandMadeListSearchSalary(int searchingValue, string range, DelInt delInt)
        {
            List<Jugadores> finalList = new List<Jugadores>();
            foreach (var item in Storage.Singleton.Instance.listaArtesanalJugadores)
            {
                switch (range)
                {
                    case "menor":
                        if (delInt(item, searchingValue) < 0)
                        {
                            finalList.Add(item);
                        }
                        break;
                    case "igual":
                        if (delInt(item, searchingValue) == 0)
                        {
                            finalList.Add(item);
                        }
                        break;
                    case "mayor":
                        if (delInt(item, searchingValue) > 0)
                        {
                            finalList.Add(item);
                        }
                        break;
                }
            }
            return finalList;
        }

        public static List<Jugadores> ListSearch(string searchingValue, DelString delegateString)
        {
            List<Jugadores> newList = new List<Jugadores>();
            foreach (var item in Storage.Singleton.Instance.listaJugadores)
            {
                if (delegateString(item, searchingValue))
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

        public static List<Jugadores> ListSearch(int searchingValue, DelInt delegateInt, string range)
        {
            List<Jugadores> newList = new List<Jugadores>();
            foreach (var item in Storage.Singleton.Instance.listaJugadores)
            {
                switch (range)
                {
                    case "menor":
                        if (delegateInt(item, searchingValue) < 0)
                        {
                            newList.Add(item);
                        }
                        break;
                    case "igual":
                        if (delegateInt(item, searchingValue) == 0)
                        {
                            newList.Add(item);
                        }
                        break;
                    case "mayor":
                        if (delegateInt(item, searchingValue) > 0)
                        {
                            newList.Add(item);
                        }
                        break;
                }
            }
            return newList;
        }




    }
}
