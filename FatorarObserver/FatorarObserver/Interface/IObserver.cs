using FatorarObserver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorarObserver.Interface
{
    public interface IObserver
    {
        void Atualizar(List<Produto> produtos, DateTime dataAtual);
    }
}
