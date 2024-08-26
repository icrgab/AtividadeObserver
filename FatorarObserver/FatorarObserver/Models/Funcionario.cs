using FatorarObserver.Interface;
using FatorarObserver.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorarObserver.Models
{
    public class Funcionario : IObserver 
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public TipoFuncionario Tipo { get; private set; }

        public Funcionario(int id, string nome, TipoFuncionario tipo)
        {
            Id = id;
            Nome = nome;
            Tipo = tipo;
        }

        public void Atualizar(List<Produto> produtos, DateTime dataAtual)
        {
            if (Tipo == TipoFuncionario.Gerente)
            {
                Console.WriteLine($"Gerente {Nome} foi notificado sobre produtos vencidos:");
                foreach (var produto in produtos)
                {
                    if (produto.EstaVencido(dataAtual))
                    {
                        Console.WriteLine($"Produto: {produto.Nome} (ID: {produto.Id}) está vencido. Data de Vencimento: {produto.DataVencimento.ToShortDateString()}");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Funcionário {Nome} (Tipo: {Tipo}) não tem permissão para verificar produtos vencidos.");
            }
        }
    }
}
