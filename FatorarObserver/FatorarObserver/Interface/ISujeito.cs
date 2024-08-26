using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorarObserver.Interface
{
    public interface ISujeito
    {
        void RegistrarObservador(IObserver observador);
        void RemoverObservador(IObserver observador);
        void NotificarObservadores();
    }
}
