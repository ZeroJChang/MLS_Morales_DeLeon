using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MLS_Morales_DeLeon.Models.Storage;
namespace MLS_Morales_DeLeon.Models
{
    public class Jugadores
    {
        public static int id;
        [Required]
        public string EquipoMLS { get; set; }
        [Required]
        public string NombreJugador { get; set; }
        public string Posicion { get; set; }
        public int Salario { get; set; }

        public int Id { get; set; }
        public Jugadores()
        {
            id++;
            Id = id;
        }

        public void GuardarLista()
        {
            Storage.Singleton.Instance.listaJugadores.AddFirst(this);
        }

        public void GuardarListaArtesanal()
        {
            Storage.Singleton.Instance.listaArtesanalJugadores.Add(this);
        }

        public static Comparison<Jugadores> FindById = delegate (Jugadores player1, Jugadores player2)
        {
            return player1.CompareTo(player2);
        };

        public int CompareTo(object obj)
        {
            var comparer = ((Jugadores)obj).Id;
            return comparer < 1 ? 1 : comparer == Id ? 0 : -1;
        }
    }
}
