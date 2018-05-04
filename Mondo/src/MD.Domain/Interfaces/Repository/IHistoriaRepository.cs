using MD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Domain.Interfaces.Repository
{
    public interface IHistoriaRepository : IRepository<Historia>
    {
        Historia ObterPorTitulo(string pstTitulo);
        IEnumerable<Historia> ObterAtivos();

        IEnumerable<Historia> ObterPorTipoHistoria(Guid pIdTipoHistoria);

        void Desativar(Guid pIdHistoria);
    }
}
