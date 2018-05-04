using MD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Domain.Interfaces.Services
{
    public interface ITipoHistoriaService : IDisposable
    {
        TipoHistoria Adicionar(TipoHistoria pObjeto);
        TipoHistoria ObterPorID(Guid pID);
        IEnumerable<TipoHistoria> ObterTodos();
        TipoHistoria ObterPorTitulo(string pstTitulo);
        IEnumerable<TipoHistoria> ObterAtivos();
        TipoHistoria Atualizar(TipoHistoria pObjeto);
        void Desativar(Guid pIdTipoHistoria);
    }
}
