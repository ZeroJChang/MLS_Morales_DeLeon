using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomGenerics.Interfaces;
using CustomGenerics.Estructuras;

namespace CustomGenerics.Estructuras
{
    public class ListaAretsanal<T> : EstructuraLinealBase<T>, IEnumerable<T>
    {
        public CustomGenerics.Estructuras.Nodo<T> primero;
        public CustomGenerics.Estructuras.Nodo<T> ultimo;
        public int count;

        public ListaAretsanal()
        {
            primero = null;
            ultimo = null;
            count = 0;
        }

        public void Add(T value)
        {
            CustomGenerics.Estructuras.Nodo<T> nuevoNodo = new CustomGenerics.Estructuras.Nodo<T>()
            { value = value, siguiente = null, anterior = null };
            Insertar(nuevoNodo);
        }

        public T GetAndDelete()
        {
            var value = Get();
            Delete();
            return value;
        }

        public Nodo<T> GetT(int posicion)
        {
            Nodo<T> nodo = primero;
            for (int i = 0; i < posicion; i++)
            {
                nodo = nodo.siguiente;
            }
            return nodo;
        }

        protected override void Insertar(Nodo<T> nuevoNodo)
        {
            if (primero == null)
            {
                primero = nuevoNodo;
                ultimo = nuevoNodo;
                nuevoNodo.siguiente = null;
                nuevoNodo.anterior = null;
            }
            else
            {

                nuevoNodo.siguiente = primero;
                nuevoNodo.anterior = ultimo;
                primero = nuevoNodo;
                (primero.siguiente).anterior = primero;
            }
            count++;
        }

        protected override void Delete()
        {
            if (this.count <= 1)
            {
                primero = null;
                ultimo = null;
            }
            else
            {
                ultimo = ultimo.anterior;
                ultimo.siguiente = primero;
                count--;
            }
        }

        protected override T Get()
        {
            return ultimo.value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var listCopy = this;
            var actual = listCopy.primero;
            while (actual != null)
            {
                yield return actual.value;
                actual = actual.siguiente;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
