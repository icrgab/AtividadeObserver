// Uso do sistema de monitoramento de vencimento sem Observer
using FatorarObserver.Models;
using FatorarObserver.Models.Enum;

class Program
{
    static void Main(string[] args)
    {
        // Criando produtos
        List<Produto> produtos = new List<Produto>
        {
            new Produto(1, "Leite", new DateTime(2024, 8, 20)),
            new Produto(2, "Iogurte", new DateTime(2024, 8, 22)),
            new Produto(3, "Queijo", new DateTime(2024, 8, 19))
        };

        // Criando funcionários
        Funcionario gerente = new Funcionario(1, "Ana", TipoFuncionario.Gerente);
        Funcionario supervisor = new Funcionario(2, "Carlos", TipoFuncionario.Supervisor);
        Funcionario operador = new Funcionario(3, "Mariana", TipoFuncionario.Operador);

        // Verificando produtos vencidos com a data atual
        DateTime dataAtual = DateTime.Now;

        gerente.Atualizar(produtos, dataAtual);
        supervisor.Atualizar(produtos, dataAtual);
        operador.Atualizar(produtos, dataAtual);
    }
}