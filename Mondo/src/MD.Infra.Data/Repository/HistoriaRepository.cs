using MD.Domain.Entities;
using MD.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD.Infra.Data.Repository
{
    public class HistoriaRepository : Repository<Historia>, IHistoriaRepository
    {
        public IEnumerable<Historia> ObterAtivos()
        {
            return Buscar(h => h.Ativo == true);
        }

        public Historia ObterPorTitulo(string pstTitulo)
        {
            return Buscar(h => h.Titulo == pstTitulo).FirstOrDefault();
        }

        public IEnumerable<Historia> ObterPorTipoHistoria(Guid pIdTipoHistoria)
        {
            return Buscar(h => h.CodTipoHistoria == pIdTipoHistoria);
        }

        public void Desativar(Guid pIdHistoria)
        {
            var obHistoria = ObterPorID(pIdHistoria);
            obHistoria.Ativo = false;
            Atualizar(obHistoria);
        }
    }
}
