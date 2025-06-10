using GerenciamentoOrcamentoGastosPessoais.Entites;
using GerenciamentoOrcamentoGastosPessoais.Service.Contracts;

namespace GerenciamentoOrcamentoGastosPessoais.Service;

public class ServiceItemRepositoryTxt:  IServiceRepositorItem
{
    public void Persistir(Item item,string path)
    {
        using (StreamWriter sw = File.AppendText(path))
        {
            foreach (var i in item.GetGasto())
            {
                sw.WriteLine(i);
            }
        }
    }
}