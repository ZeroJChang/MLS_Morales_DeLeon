using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenerics.Estructuras
{
    public class Nodo<T>
    {
        public Nodo<T> siguiente { get; set; }
        public Nodo<T> anterior { get; set; }
        public T value { get; set; }
    }
}
