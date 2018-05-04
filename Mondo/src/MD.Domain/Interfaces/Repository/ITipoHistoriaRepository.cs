using MD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Domain.Interfaces.Repository
{
    public interface ITipoHistoriaRepository : IRepository<TipoHistoria>
    {
        TipoHistoria ObterPorTitulo(string pstTitulo);

        IEnumerable<TipoHistoria> ObterAtivos();

        void Desativar(Guid pIdTipoHistoria);
    }
}
