using FatorarObserver.Interface;
using FatorarObserver.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorarObserver
{
    public class GerenciadorDeProdutos : ISujeito
    {
        private List<Produto> produtos = new List<Produto>();
        private List<IObserver> observadores = new List<IObserver>();

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
            NotificarObservadores(); // Notifica quando um novo produto é adicionado
        }

        public void RegistrarObservador(IObserver observador)
        {
            observadores.Add(observador);
        }

        public void RemoverObservador(IObserver observador)
        {
            observadores.Remove(observador);
        }

        public void NotificarObservadores()
        {
            DateTime dataAtual = DateTime.Now;
            foreach (var observador in observadores)
            {
                observador.Atualizar(produtos, dataAtual);
            }
        }
    }
}
