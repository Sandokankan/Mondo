using MD.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Application.Interfaces
{
    public interface IHistoriaAppService : IDisposable
    {
        HistoriaViewModel ObterPorId(Guid pIdHistoria);
        IEnumerable<HistoriaViewModel> ObterTodos();
        HistoriaViewModel Adicionar(HistoriaViewModel pHistoria);
        HistoriaViewModel Atualizar(HistoriaViewModel pHistoria);
        void Desativar(Guid pIdHistoria);
    }
}
