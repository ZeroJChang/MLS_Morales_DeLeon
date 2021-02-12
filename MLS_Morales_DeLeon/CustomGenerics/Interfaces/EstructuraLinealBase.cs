using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomGenerics.Estructuras;

namespace CustomGenerics.Interfaces
{
    public abstract class EstructuraLinealBase<T>
    {
        protected abstract void Insertar(Nodo<T> Nodo);
        protected abstract void Delete();
        protected abstract T Get();
    }
}

