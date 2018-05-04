using MD.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Application.Interfaces
{
    public interface ITipoHistoriaAppService : IDisposable
    {
        TipoHistoriaViewModel ObterPorId(Guid pIdTipoHistoria);
        IEnumerable<TipoHistoriaViewModel> ObterTodos();
        TipoHistoriaViewModel Adicionar(TipoHistoriaViewModel pTipoHistoria);
        TipoHistoriaViewModel Atualizar(TipoHistoriaViewModel pTipoHistoria);
        void Desativar(Guid pIdTipoHistoria);
    }
}
