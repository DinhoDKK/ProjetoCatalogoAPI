using ProjetoCatalogoAPI.Entities;

namespace ProjetoCatalogoAPI.Repositores
{
    public interface IJogoRepository : IDisposable
    {
        Task<List<Jogo>> Obter(int pagina, int quantidade);
        Task<Jogo> Obter(Guid Id);
        Task<Jogo> Obter(string nome, string produtora);
        Task Inserir(Jogo jogo);
        Task Atualizar(Jogo jogo);
        Task Remover(Guid Id);
    }
}
