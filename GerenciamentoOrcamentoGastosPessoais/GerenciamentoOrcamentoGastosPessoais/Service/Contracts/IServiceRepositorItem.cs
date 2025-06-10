using GerenciamentoOrcamentoGastosPessoais.Entites;

namespace GerenciamentoOrcamentoGastosPessoais.Service.Contracts;

public interface IServiceRepositorItem
{
    void Persistir(Item item,string path);
}