using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomGenerics.Interfaces
{
    interface IEstructuraLineal<T>
    {
        void Insertar();
        void Delete();
        T Get();
    }
}
