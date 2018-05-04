using MD.Domain.Interfaces.Repository;
using MD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace MD.Infra.Data.Repository
{
    public class TipoHistoriaRepository : Repository<TipoHistoria>, ITipoHistoriaRepository
    {
        public void Desativar(Guid pIdTipoHistoria)
        {
            var obTipoHistoria = ObterPorID(pIdTipoHistoria);
            obTipoHistoria.Ativo = false;
            Atualizar(obTipoHistoria);
        }

        public IEnumerable<TipoHistoria> ObterAtivos()
        {
            return Buscar(t => t.Ativo == true);
        }

        public TipoHistoria ObterPorTitulo(string pstTitulo)
        {
            return Buscar(t => t.Titulo == pstTitulo).FirstOrDefault();
        }

        public override TipoHistoria ObterPorID(Guid pID)
        {
            var CN = DB.Database.Connection;
            var Query = @"SELECT TOP 1 * FROM TipoHistoria WHERE CodTipoHistoria = @qID";
            var obTipoHistoria = CN.Query<TipoHistoria>(Query, new {qId = pID});
            return obTipoHistoria.FirstOrDefault();
        }
    }
}
